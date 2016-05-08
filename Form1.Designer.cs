namespace MTGWiz
{
    partial class Form1
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.labelChosenFile = new System.Windows.Forms.Label();
            this.imageBox = new Emgu.CV.UI.ImageBox();
            this.textInfo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.btnOpenFile, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelChosenFile, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.imageBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.textInfo, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1247, 690);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.AutoSize = true;
            this.btnOpenFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(3, 3);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(83, 30);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "OpenFile";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // labelChosenFile
            // 
            this.labelChosenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChosenFile.AutoSize = true;
            this.labelChosenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChosenFile.Location = new System.Drawing.Point(92, 8);
            this.labelChosenFile.Name = "labelChosenFile";
            this.labelChosenFile.Size = new System.Drawing.Size(1152, 20);
            this.labelChosenFile.TabIndex = 1;
            this.labelChosenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelChosenFile.Click += new System.EventHandler(this.labelChosenFile_Click);
            // 
            // imageBox
            // 
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel.SetColumnSpan(this.imageBox, 2);
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox.Enabled = false;
            this.imageBox.Location = new System.Drawing.Point(3, 39);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(1241, 517);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // textInfo
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textInfo, 2);
            this.textInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textInfo.Location = new System.Drawing.Point(3, 562);
            this.textInfo.Multiline = true;
            this.textInfo.Name = "textInfo";
            this.textInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textInfo.Size = new System.Drawing.Size(1241, 125);
            this.textInfo.TabIndex = 3;
            this.textInfo.WordWrap = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 690);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label labelChosenFile;
        private Emgu.CV.UI.ImageBox imageBox;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

