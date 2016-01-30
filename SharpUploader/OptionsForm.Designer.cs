namespace SharpUploader
{
    partial class OptionsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.compressionBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FTPTab = new System.Windows.Forms.TabPage();
            this.defaultDirBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.FTPTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.generalTab);
            this.tabControl1.Controls.Add(this.FTPTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 329);
            this.tabControl1.TabIndex = 0;
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.compressionBox);
            this.generalTab.Controls.Add(this.label7);
            this.generalTab.Controls.Add(this.widthBox);
            this.generalTab.Controls.Add(this.label6);
            this.generalTab.Location = new System.Drawing.Point(4, 22);
            this.generalTab.Name = "generalTab";
            this.generalTab.Size = new System.Drawing.Size(646, 303);
            this.generalTab.TabIndex = 0;
            this.generalTab.Text = "General";
            this.generalTab.UseVisualStyleBackColor = true;
            // 
            // compressionBox
            // 
            this.compressionBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SharpUploader.Properties.Settings.Default, "Compression", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.compressionBox.Location = new System.Drawing.Point(201, 64);
            this.compressionBox.Name = "compressionBox";
            this.compressionBox.Size = new System.Drawing.Size(79, 20);
            this.compressionBox.TabIndex = 27;
            this.compressionBox.Text = global::SharpUploader.Properties.Settings.Default.Compression;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "JPEG Compression:";
            // 
            // widthBox
            // 
            this.widthBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SharpUploader.Properties.Settings.Default, "MaxWidth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.widthBox.Location = new System.Drawing.Point(201, 28);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(79, 20);
            this.widthBox.TabIndex = 25;
            this.widthBox.Text = global::SharpUploader.Properties.Settings.Default.MaxWidth;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Desired Width:";
            // 
            // FTPTab
            // 
            this.FTPTab.Controls.Add(this.defaultDirBox);
            this.FTPTab.Controls.Add(this.label5);
            this.FTPTab.Controls.Add(this.textBox1);
            this.FTPTab.Controls.Add(this.usernameBox);
            this.FTPTab.Controls.Add(this.hostBox);
            this.FTPTab.Controls.Add(this.label4);
            this.FTPTab.Controls.Add(this.label3);
            this.FTPTab.Controls.Add(this.label2);
            this.FTPTab.Controls.Add(this.label1);
            this.FTPTab.Location = new System.Drawing.Point(4, 22);
            this.FTPTab.Name = "FTPTab";
            this.FTPTab.Size = new System.Drawing.Size(646, 303);
            this.FTPTab.TabIndex = 1;
            this.FTPTab.Text = "FTP";
            this.FTPTab.UseVisualStyleBackColor = true;
            // 
            // defaultDirBox
            // 
            this.defaultDirBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SharpUploader.Properties.Settings.Default, "DefaultDir", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.defaultDirBox.Location = new System.Drawing.Point(175, 139);
            this.defaultDirBox.Name = "defaultDirBox";
            this.defaultDirBox.Size = new System.Drawing.Size(235, 20);
            this.defaultDirBox.TabIndex = 26;
            this.defaultDirBox.Text = global::SharpUploader.Properties.Settings.Default.DefaultDir;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Default Dir:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SharpUploader.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(175, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = global::SharpUploader.Properties.Settings.Default.Password;
            // 
            // usernameBox
            // 
            this.usernameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SharpUploader.Properties.Settings.Default, "Username", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.usernameBox.Location = new System.Drawing.Point(175, 66);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(235, 20);
            this.usernameBox.TabIndex = 23;
            this.usernameBox.Text = global::SharpUploader.Properties.Settings.Default.Username;
            // 
            // hostBox
            // 
            this.hostBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SharpUploader.Properties.Settings.Default, "Host", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.hostBox.Location = new System.Drawing.Point(175, 31);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(235, 20);
            this.hostBox.TabIndex = 22;
            this.hostBox.Text = global::SharpUploader.Properties.Settings.Default.Host;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "ftp.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Host:";
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(486, 349);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(567, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 384);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sharp Uploader Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            this.FTPTab.ResumeLayout(false);
            this.FTPTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.TabPage FTPTab;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox compressionBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox defaultDirBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}