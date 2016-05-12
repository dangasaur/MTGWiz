﻿namespace MTGWiz
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.resizeImageBox = new Emgu.CV.UI.ImageBox();
            this.grayImageBox = new Emgu.CV.UI.ImageBox();
            this.thresholdImageBox = new Emgu.CV.UI.ImageBox();
            this.hashLabel = new System.Windows.Forms.Label();
            this.sourceImageBox = new Emgu.CV.UI.ImageBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resizeImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sourceImageBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.openFileButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.openFileLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 509);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.infoTextBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.resizeImageBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grayImageBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.thresholdImageBox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.hashLabel, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(521, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.54256F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.45745F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(512, 467);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // resizeImageBox
            // 
            this.resizeImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resizeImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resizeImageBox.Enabled = false;
            this.resizeImageBox.Location = new System.Drawing.Point(3, 3);
            this.resizeImageBox.Name = "resizeImageBox";
            this.resizeImageBox.Padding = new System.Windows.Forms.Padding(2);
            this.resizeImageBox.Size = new System.Drawing.Size(164, 198);
            this.resizeImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resizeImageBox.TabIndex = 2;
            this.resizeImageBox.TabStop = false;
            // 
            // grayImageBox
            // 
            this.grayImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grayImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grayImageBox.Enabled = false;
            this.grayImageBox.Location = new System.Drawing.Point(173, 3);
            this.grayImageBox.Name = "grayImageBox";
            this.grayImageBox.Padding = new System.Windows.Forms.Padding(2);
            this.grayImageBox.Size = new System.Drawing.Size(164, 198);
            this.grayImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.grayImageBox.TabIndex = 2;
            this.grayImageBox.TabStop = false;
            // 
            // thresholdImageBox
            // 
            this.thresholdImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thresholdImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thresholdImageBox.Enabled = false;
            this.thresholdImageBox.Location = new System.Drawing.Point(343, 3);
            this.thresholdImageBox.Name = "thresholdImageBox";
            this.thresholdImageBox.Padding = new System.Windows.Forms.Padding(2);
            this.thresholdImageBox.Size = new System.Drawing.Size(166, 198);
            this.thresholdImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thresholdImageBox.TabIndex = 3;
            this.thresholdImageBox.TabStop = false;
            // 
            // hashLabel
            // 
            this.hashLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hashLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.hashLabel, 3);
            this.hashLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashLabel.Location = new System.Drawing.Point(3, 204);
            this.hashLabel.Name = "hashLabel";
            this.hashLabel.Size = new System.Drawing.Size(506, 27);
            this.hashLabel.TabIndex = 4;
            this.hashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sourceImageBox
            // 
            this.sourceImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceImageBox.Enabled = false;
            this.sourceImageBox.Location = new System.Drawing.Point(3, 39);
            this.sourceImageBox.Name = "sourceImageBox";
            this.sourceImageBox.Size = new System.Drawing.Size(512, 467);
            this.sourceImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourceImageBox.TabIndex = 2;
            this.sourceImageBox.TabStop = false;
            // 
            // openFileButton
            // 
            this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openFileButton.AutoSize = true;
            this.openFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileButton.Location = new System.Drawing.Point(3, 3);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(512, 30);
            this.openFileButton.TabIndex = 4;
            this.openFileButton.Text = "Open File";
            this.openFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // openFileLabel
            // 
            this.openFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.openFileLabel.AutoSize = true;
            this.openFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileLabel.Location = new System.Drawing.Point(521, 8);
            this.openFileLabel.Name = "openFileLabel";
            this.openFileLabel.Size = new System.Drawing.Size(512, 20);
            this.openFileLabel.TabIndex = 5;
            this.openFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // infoTextBox
            // 
            this.infoTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel2.SetColumnSpan(this.infoTextBox, 3);
            this.infoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTextBox.Location = new System.Drawing.Point(3, 234);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infoTextBox.Size = new System.Drawing.Size(506, 230);
            this.infoTextBox.TabIndex = 5;
            this.infoTextBox.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 509);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resizeImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Emgu.CV.UI.ImageBox resizeImageBox;
        private Emgu.CV.UI.ImageBox grayImageBox;
        private Emgu.CV.UI.ImageBox sourceImageBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label openFileLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Emgu.CV.UI.ImageBox thresholdImageBox;
        private System.Windows.Forms.Label hashLabel;
        private System.Windows.Forms.TextBox infoTextBox;
    }
}