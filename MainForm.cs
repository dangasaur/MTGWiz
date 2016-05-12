﻿using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// images: source, resized, grayscaled, avg-grayscaled

namespace MTGWiz
{
    public partial class MainForm : Form, IInfoWriter
    {
       
        private ImageHasher hasher;

        public MainForm()
        {
            InitializeComponent();
            hasher = new ImageHasher(this);
        }

        public void WriteInfo(string message)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(WriteInfo), new object[] { message });
            } else
            {
                infoTextBox.Text += message;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //close all windows here?
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            //open the file dialog button here
            DialogResult dialogResult = openFileDialog.ShowDialog();

            //picked something incorrect or cancels
            if (dialogResult != DialogResult.OK || openFileDialog.FileName.Equals(""))
            {
                openFileLabel.Text = "file not found";
                return;
            }

            openFileLabel.Text = openFileDialog.FileName;
            ProcessAndUpdateUI(openFileDialog.FileName);
        }

        private void ProcessAndUpdateUI(string fileName)
        {
            HashResult result = hasher.HashImage(fileName);

            //update UI
            hashLabel.Text = result.Hash;
            sourceImageBox.Image = result.Source;
            resizeImageBox.Image = result.Resize;
            grayImageBox.Image = result.Grayscale;
            thresholdImageBox.Image = result.Threshold;
        }
    }
}
