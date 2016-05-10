﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
        }

        private void ProcessAndUpdateUI()
        {
            //update all ImageBoxes with source + all processed images
        }
    }
}
