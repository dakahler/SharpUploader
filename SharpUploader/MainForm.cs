using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using FTPLib;
using SharpUploader.Properties;

namespace SharpUploader
{
    public partial class MainForm : Form
    {

        List<String> pictureFiles = new List<String>();
        List<String> resizedPictureFiles = new List<String>();
        int currentPicture = -1;
        List<double> Rotations = new List<double>();

        public MainForm()
        {
            InitializeComponent();

            if (Environment.GetCommandLineArgs().Length > 1)
            {
                Parse();
                NextPicture();
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Parse(openFileDialog.FileNames);
                    NextPicture();
                }
                else
                {
                    Application.Exit();
                }
            }

            if (Settings.Default.FirstRun)
            {
                OptionsForm optionsForm = new OptionsForm();
                optionsForm.ShowDialog();

                Settings.Default.FirstRun = false;
                Settings.Default.Save();
            }
        }

        void Parse()
        {
            bool firstArg = true;
            foreach (String arg in Environment.GetCommandLineArgs())
            {
                if (firstArg)
                {
                    firstArg = false;
                    continue;
                }

                pictureFiles.Add(arg);
                Rotations.Add(0.0);
            }
        }

        void Parse(String[] files)
        {
            foreach (String file in files)
            {
                pictureFiles.Add(file);
                Rotations.Add(0.0);
            }
        }

        void NextPicture()
        {
            currentPicture++;

            if (currentPicture >= pictureFiles.Count)
            {
                UploadFiles();
                return;
            }

            String filename = pictureFiles[currentPicture];
            FileInfo imgFile = new FileInfo(filename);
            Image img = Image.FromFile(filename);

            int pboxWidth = imagePicturebox.Width;
            double aspect = (double)img.Width / (double)img.Height;

            Image pboxImg = FixedSize(img, pboxWidth, (int)(pboxWidth / aspect));
            imagePicturebox.Image = pboxImg;

            newNameBox.Text = imgFile.Name;
            newNameBox.Focus();
            newNameBox.Select(0, imgFile.Name.Length - 4);

            originalLabel.Text = imgFile.Name;
        }

        Image FixedSize(Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 1;
            int sourceY = 1;
            int destX = 0;
            int destY = 0;

            //float nPercent = 0;
            //float nPercentW = 0;
            //float nPercentH = 0;

            //nPercentW = ((float)Width / (float)sourceWidth);
            //nPercentH = ((float)Height / (float)sourceHeight);
            //if (nPercentH < nPercentW)
            //{
            //    nPercent = nPercentH;
            //    destX = System.Convert.ToInt16((Width -
            //                  (sourceWidth * nPercent)) / 2);
            //}
            //else
            //{
            //    nPercent = nPercentW;
            //    destY = System.Convert.ToInt16((Height -
            //                  (sourceHeight * nPercent)) / 2);
            //}

            int destWidth = Width+1;// (int)(sourceWidth * nPercent);
            int destHeight = Height+1;// (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width, Height,
                              PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                             imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Transparent);
            grPhoto.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            String filename = pictureFiles[currentPicture];

            FileInfo imgFile = new FileInfo(filename);
            Image img = Image.FromFile(filename);

            double aspect = (double)img.Width / (double)img.Height;
            int finalWidth = Math.Min(int.Parse(Settings.Default.MaxWidth),img.Width);
            int finalHeight = (int)(finalWidth / aspect);

            Image finalImg = (Image)img.Clone();

            img = Utilities.RotateImage(img, Rotations[currentPicture]);
            finalImg = Utilities.RotateImage(finalImg, Rotations[currentPicture]);

            if (Rotations[currentPicture]==90.0 || Rotations[currentPicture]==270.0)
                finalImg = FixedSize(finalImg, finalHeight, finalWidth);
            else
                finalImg = FixedSize(finalImg, finalWidth, finalHeight);

            String myPicturesDir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            String originalsDir = myPicturesDir + "\\Originals\\";
            String resizedDir = myPicturesDir + "\\Resized\\";

            if (!Directory.Exists(originalsDir))
                Directory.CreateDirectory(originalsDir);

            if (!Directory.Exists(resizedDir))
                Directory.CreateDirectory(resizedDir);

            String originalImgFilename = originalsDir + imgFile.Name;
            String finalImgFilename = resizedDir +
                                      newNameBox.Text.Substring(0,newNameBox.Text.LastIndexOf('.')) +
                                      newNameBox.Text.Substring(newNameBox.Text.LastIndexOf('.')).ToLower();
            SaveJpeg(finalImgFilename, finalImg, int.Parse(Settings.Default.Compression));
            img.Save(originalImgFilename);

            resizedPictureFiles.Add(finalImgFilename);

            NextPicture();
        }

        private void newNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                OKButton_Click(sender, e);
                e.Handled = true;
            }
        }

        void UploadFiles()
        {
            FTP ftplib = new FTP();

            try
            {
                // there are server, user and password properties
                // that can be set within the ftplib object as well
                // those properties are actually set when
                // you call the Connect(server, user, pass) function
                String host = Settings.Default.Host;
                ftplib.Connect("ftp." + host,
                               Settings.Default.Username,
                               Settings.Default.Password);

                InputBoxDialog inputBox = new InputBoxDialog();
                inputBox.FormPrompt = "FTP Directory";
                inputBox.FormCaption = "FTP Directory";
                inputBox.DefaultValue = Settings.Default.DefaultDir;
                inputBox.ShowDialog();
                String directory = inputBox.InputResponse;
                inputBox.Close();

                if (directory == "" || directory == null)
                    Application.Exit();


                // Populate clipboard
                String clipboard = "";
                foreach (String filename in resizedPictureFiles)
                {
                    FileInfo fileInfo = new FileInfo(filename);
                    clipboard += "http://" + host + "/" + directory + fileInfo.Name + "\r\n";
                }
                Clipboard.SetDataObject(clipboard, true);

                try
                {
                    ftplib.ChangeDir(directory);
                }
                catch (Exception)
                {
                    // Directory probably didn't exist. Create it.
                    ftplib.MakeDir(directory,true);
                }


                // open the file with resume support if it already exists, the last 
                // peram should be false for no resume
                foreach (String filename in resizedPictureFiles)
                {
                    FileInfo fileInfo = new FileInfo(filename);
                    ftplib.OpenUpload(fileInfo.FullName, fileInfo.Name);
                    while (ftplib.DoUpload() > 0)
                    {
                        //perc = (int)((ftplib.BytesTotal * 100) / ftplib.FileSize);
                        //Console.Write("\rDownloading: {0}/{1} {2}%",
                        //  ftplib.BytesTotal, ftplib.FileSize, perc);
                        //Console.Out.Flush();
                    }
                    //Console.WriteLine("");
                }

                MessageBox.Show("Upload Complete!");

                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void SaveJpeg(string path, Image img, long quality)
        {
            if (quality < 0 || quality > 100)
                throw new ArgumentOutOfRangeException("quality must be between 0 and 100.");


            // Encoder parameter for image quality
            EncoderParameter qualityParam =
                new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            // Jpeg image codec
            ImageCodecInfo jpegCodec = GetEncoderInfo("image/tiff");

            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;

            img.Save(path, jpegCodec, encoderParams);
        }

        /// <summary>
        /// Returns the image codec with the given mime type
        /// </summary>
        ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];
            return null;
        }

        private void rotateCounterClockwiseBox_Click(object sender, EventArgs e)
        {
            Rotations[currentPicture] -= 90.0;
            imagePicturebox.Image = Utilities.RotateImage(imagePicturebox.Image, -90.0);

            if (Rotations[currentPicture] <= -360.0)
                Rotations[currentPicture] += 360.0;

            if (Rotations[currentPicture] >= 360.0)
                Rotations[currentPicture] -= 360.0;
        }

        private void rotateClockwiseBox_Click(object sender, EventArgs e)
        {
            Rotations[currentPicture] += 90.0;
            imagePicturebox.Image = Utilities.RotateImage(imagePicturebox.Image, 90.0);

            if (Rotations[currentPicture] <= -360.0)
                Rotations[currentPicture] += 360.0;

            if (Rotations[currentPicture] >= 360.0)
                Rotations[currentPicture] -= 360.0;
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.ShowDialog();
        }
    }
}