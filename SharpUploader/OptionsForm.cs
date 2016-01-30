using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SharpUploader.Properties;

namespace SharpUploader
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save settings
            Settings.Default.Save();
        }
    }
}