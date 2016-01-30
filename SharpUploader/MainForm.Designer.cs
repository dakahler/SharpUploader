namespace SharpUploader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.originalLabel = new System.Windows.Forms.Label();
            this.newNameBox = new System.Windows.Forms.TextBox();
            this.newNameLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.rotateClockwiseBox = new System.Windows.Forms.PictureBox();
            this.rotateCounterClockwiseBox = new System.Windows.Forms.PictureBox();
            this.imagePicturebox = new System.Windows.Forms.PictureBox();
            this.optionsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rotateClockwiseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateCounterClockwiseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalLabel.Location = new System.Drawing.Point(304, 14);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(0, 20);
            this.originalLabel.TabIndex = 0;
            this.originalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newNameBox
            // 
            this.newNameBox.Location = new System.Drawing.Point(194, 393);
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Size = new System.Drawing.Size(274, 20);
            this.newNameBox.TabIndex = 2;
            this.newNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newNameBox_KeyPress);
            // 
            // newNameLabel
            // 
            this.newNameLabel.AutoSize = true;
            this.newNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNameLabel.Location = new System.Drawing.Point(291, 370);
            this.newNameLabel.Name = "newNameLabel";
            this.newNameLabel.Size = new System.Drawing.Size(90, 20);
            this.newNameLabel.TabIndex = 3;
            this.newNameLabel.Text = "New Name:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(295, 429);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // rotateClockwiseBox
            // 
            this.rotateClockwiseBox.Image = global::SharpUploader.Properties.Resources.Edit_RedoHS;
            this.rotateClockwiseBox.Location = new System.Drawing.Point(598, 155);
            this.rotateClockwiseBox.Name = "rotateClockwiseBox";
            this.rotateClockwiseBox.Size = new System.Drawing.Size(16, 16);
            this.rotateClockwiseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rotateClockwiseBox.TabIndex = 7;
            this.rotateClockwiseBox.TabStop = false;
            this.rotateClockwiseBox.Click += new System.EventHandler(this.rotateClockwiseBox_Click);
            // 
            // rotateCounterClockwiseBox
            // 
            this.rotateCounterClockwiseBox.Image = global::SharpUploader.Properties.Resources.Edit_UndoHS;
            this.rotateCounterClockwiseBox.Location = new System.Drawing.Point(42, 155);
            this.rotateCounterClockwiseBox.Name = "rotateCounterClockwiseBox";
            this.rotateCounterClockwiseBox.Size = new System.Drawing.Size(16, 16);
            this.rotateCounterClockwiseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rotateCounterClockwiseBox.TabIndex = 6;
            this.rotateCounterClockwiseBox.TabStop = false;
            this.rotateCounterClockwiseBox.Click += new System.EventHandler(this.rotateCounterClockwiseBox_Click);
            // 
            // imagePicturebox
            // 
            this.imagePicturebox.BackColor = System.Drawing.Color.White;
            this.imagePicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imagePicturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePicturebox.Location = new System.Drawing.Point(77, 47);
            this.imagePicturebox.Name = "imagePicturebox";
            this.imagePicturebox.Size = new System.Drawing.Size(501, 264);
            this.imagePicturebox.TabIndex = 1;
            this.imagePicturebox.TabStop = false;
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(12, 436);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(75, 23);
            this.optionsButton.TabIndex = 8;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 471);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.rotateClockwiseBox);
            this.Controls.Add(this.rotateCounterClockwiseBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.newNameLabel);
            this.Controls.Add(this.newNameBox);
            this.Controls.Add(this.imagePicturebox);
            this.Controls.Add(this.originalLabel);
            this.Name = "MainForm";
            this.Text = "Sharp Uploader";
            ((System.ComponentModel.ISupportInitialize)(this.rotateClockwiseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateCounterClockwiseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.PictureBox imagePicturebox;
        private System.Windows.Forms.TextBox newNameBox;
        private System.Windows.Forms.Label newNameLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.PictureBox rotateCounterClockwiseBox;
        private System.Windows.Forms.PictureBox rotateClockwiseBox;
        private System.Windows.Forms.Button optionsButton;
    }
}

