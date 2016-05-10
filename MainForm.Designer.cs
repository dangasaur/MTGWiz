namespace MTGWiz
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
            this.sourceImageBox = new Emgu.CV.UI.ImageBox();
            this.resizeImageBox = new Emgu.CV.UI.ImageBox();
            this.grayImageBox = new Emgu.CV.UI.ImageBox();
            this.avgImageBox = new Emgu.CV.UI.ImageBox();
            this.fourthImageBox = new Emgu.CV.UI.ImageBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sourceImageBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.infoTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.openFileButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.openFileLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 690);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.resizeImageBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grayImageBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.avgImageBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.fourthImageBox, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(521, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(512, 517);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // sourceImageBox
            // 
            this.sourceImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceImageBox.Enabled = false;
            this.sourceImageBox.Location = new System.Drawing.Point(3, 39);
            this.sourceImageBox.Name = "sourceImageBox";
            this.sourceImageBox.Size = new System.Drawing.Size(512, 517);
            this.sourceImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourceImageBox.TabIndex = 2;
            this.sourceImageBox.TabStop = false;
            // 
            // resizeImageBox
            // 
            this.resizeImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resizeImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resizeImageBox.Enabled = false;
            this.resizeImageBox.Location = new System.Drawing.Point(3, 3);
            this.resizeImageBox.Name = "resizeImageBox";
            this.resizeImageBox.Padding = new System.Windows.Forms.Padding(2);
            this.resizeImageBox.Size = new System.Drawing.Size(250, 252);
            this.resizeImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resizeImageBox.TabIndex = 2;
            this.resizeImageBox.TabStop = false;
            // 
            // grayImageBox
            // 
            this.grayImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grayImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grayImageBox.Enabled = false;
            this.grayImageBox.Location = new System.Drawing.Point(259, 3);
            this.grayImageBox.Name = "grayImageBox";
            this.grayImageBox.Padding = new System.Windows.Forms.Padding(2);
            this.grayImageBox.Size = new System.Drawing.Size(250, 252);
            this.grayImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.grayImageBox.TabIndex = 2;
            this.grayImageBox.TabStop = false;
            // 
            // avgImageBox
            // 
            this.avgImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avgImageBox.Enabled = false;
            this.avgImageBox.Location = new System.Drawing.Point(3, 261);
            this.avgImageBox.Name = "avgImageBox";
            this.avgImageBox.Padding = new System.Windows.Forms.Padding(2);
            this.avgImageBox.Size = new System.Drawing.Size(250, 253);
            this.avgImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avgImageBox.TabIndex = 2;
            this.avgImageBox.TabStop = false;
            // 
            // fourthImageBox
            // 
            this.fourthImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fourthImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourthImageBox.Enabled = false;
            this.fourthImageBox.Location = new System.Drawing.Point(259, 261);
            this.fourthImageBox.Name = "fourthImageBox";
            this.fourthImageBox.Padding = new System.Windows.Forms.Padding(2);
            this.fourthImageBox.Size = new System.Drawing.Size(250, 253);
            this.fourthImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fourthImageBox.TabIndex = 2;
            this.fourthImageBox.TabStop = false;
            // 
            // infoTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.infoTextBox, 2);
            this.infoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoTextBox.Location = new System.Drawing.Point(3, 562);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.infoTextBox.Size = new System.Drawing.Size(1030, 125);
            this.infoTextBox.TabIndex = 3;
            this.infoTextBox.WordWrap = false;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 690);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sourceImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Emgu.CV.UI.ImageBox resizeImageBox;
        private Emgu.CV.UI.ImageBox grayImageBox;
        private Emgu.CV.UI.ImageBox avgImageBox;
        private Emgu.CV.UI.ImageBox fourthImageBox;
        private Emgu.CV.UI.ImageBox sourceImageBox;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label openFileLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}