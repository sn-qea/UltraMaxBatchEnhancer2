namespace UltraMaxBatchEnhancer2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_imageFiles = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox_SelectedFolderPath = new System.Windows.Forms.TextBox();
            this.button_enhance = new MetroFramework.Controls.MetroButton();
            this.button_reset = new MetroFramework.Controls.MetroButton();
            this.button_view = new MetroFramework.Controls.MetroButton();
            this.button_upload = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_imageFiles
            // 
            this.listBox_imageFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBox_imageFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_imageFiles.ForeColor = System.Drawing.Color.Black;
            this.listBox_imageFiles.FormattingEnabled = true;
            this.listBox_imageFiles.ItemHeight = 16;
            this.listBox_imageFiles.Location = new System.Drawing.Point(38, 133);
            this.listBox_imageFiles.Name = "listBox_imageFiles";
            this.listBox_imageFiles.Size = new System.Drawing.Size(259, 180);
            this.listBox_imageFiles.TabIndex = 2;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // textBox_SelectedFolderPath
            // 
            this.textBox_SelectedFolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_SelectedFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SelectedFolderPath.ForeColor = System.Drawing.Color.Black;
            this.textBox_SelectedFolderPath.Location = new System.Drawing.Point(39, 105);
            this.textBox_SelectedFolderPath.Name = "textBox_SelectedFolderPath";
            this.textBox_SelectedFolderPath.Size = new System.Drawing.Size(259, 22);
            this.textBox_SelectedFolderPath.TabIndex = 7;
            // 
            // button_enhance
            // 
            this.button_enhance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_enhance.ForeColor = System.Drawing.Color.Black;
            this.button_enhance.Location = new System.Drawing.Point(48, 335);
            this.button_enhance.Name = "button_enhance";
            this.button_enhance.Size = new System.Drawing.Size(75, 23);
            this.button_enhance.TabIndex = 11;
            this.button_enhance.Text = "Enhance";
            this.button_enhance.UseCustomBackColor = true;
            this.button_enhance.UseCustomForeColor = true;
            this.button_enhance.UseSelectable = true;
            this.button_enhance.UseStyleColors = true;
            this.button_enhance.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_reset.ForeColor = System.Drawing.Color.Black;
            this.button_reset.Location = new System.Drawing.Point(129, 335);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 12;
            this.button_reset.Text = "Reset";
            this.button_reset.UseCustomBackColor = true;
            this.button_reset.UseCustomForeColor = true;
            this.button_reset.UseSelectable = true;
            this.button_reset.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // button_view
            // 
            this.button_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_view.ForeColor = System.Drawing.Color.Black;
            this.button_view.Location = new System.Drawing.Point(210, 335);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(75, 23);
            this.button_view.TabIndex = 13;
            this.button_view.Text = "View";
            this.button_view.UseCustomBackColor = true;
            this.button_view.UseCustomForeColor = true;
            this.button_view.UseSelectable = true;
            this.button_view.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // button_upload
            // 
            this.button_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_upload.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.button_upload.ForeColor = System.Drawing.Color.Black;
            this.button_upload.Location = new System.Drawing.Point(38, 76);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(75, 23);
            this.button_upload.TabIndex = 14;
            this.button_upload.Text = "Upload";
            this.button_upload.UseCustomBackColor = true;
            this.button_upload.UseCustomForeColor = true;
            this.button_upload.UseSelectable = true;
            this.button_upload.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UltraMaxBatchEnhancer2.Properties.Resources.QEAlogo;
            this.pictureBox1.Location = new System.Drawing.Point(135, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(198, 76);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(100, 23);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroProgressBar1.TabIndex = 17;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // metroLink1
            // 
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroLink1.ForeColor = System.Drawing.Color.Black;
            this.metroLink1.Location = new System.Drawing.Point(201, 404);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(180, 23);
            this.metroLink1.TabIndex = 18;
            this.metroLink1.Text = "QEA Tech Inc.";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroLink2.Location = new System.Drawing.Point(2, 404);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(75, 23);
            this.metroLink2.TabIndex = 19;
            this.metroLink2.Text = "User Manual";
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(332, 429);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.button_view);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_enhance);
            this.Controls.Add(this.textBox_SelectedFolderPath);
            this.Controls.Add(this.listBox_imageFiles);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "UltraMax Batch Enhancer";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_imageFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox_SelectedFolderPath;
        private MetroFramework.Controls.MetroButton button_enhance;
        private MetroFramework.Controls.MetroButton button_reset;
        private MetroFramework.Controls.MetroButton button_view;
        private MetroFramework.Controls.MetroButton button_upload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLink metroLink2;
    }
}

