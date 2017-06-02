namespace MusicSorter
{
    partial class PrepareForm
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
            this.ScanBtn = new MetroFramework.Controls.MetroButton();
            this.FolderPathTBox = new MetroFramework.Controls.MetroTextBox();
            this.FolderSearchBtn = new MetroFramework.Controls.MetroButton();
            this.FilesLBox = new System.Windows.Forms.ListBox();
            this.FileNameLbl = new MetroFramework.Controls.MetroLabel();
            this.ArtistLbl = new MetroFramework.Controls.MetroLabel();
            this.NameLbl = new MetroFramework.Controls.MetroLabel();
            this.FileNameTBox = new MetroFramework.Controls.MetroTextBox();
            this.ArtistTBox = new MetroFramework.Controls.MetroTextBox();
            this.NameTBox = new MetroFramework.Controls.MetroTextBox();
            this.OkBtn = new MetroFramework.Controls.MetroButton();
            this.DelBtn = new MetroFramework.Controls.MetroButton();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // ScanBtn
            // 
            this.ScanBtn.Location = new System.Drawing.Point(56, 91);
            this.ScanBtn.Name = "ScanBtn";
            this.ScanBtn.Size = new System.Drawing.Size(146, 23);
            this.ScanBtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ScanBtn.TabIndex = 0;
            this.ScanBtn.Text = "Сканировать";
            this.ScanBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ScanBtn.Click += new System.EventHandler(this.ScanBtn_Click);
            // 
            // FolderPathTBox
            // 
            this.FolderPathTBox.Location = new System.Drawing.Point(24, 62);
            this.FolderPathTBox.Name = "FolderPathTBox";
            this.FolderPathTBox.Size = new System.Drawing.Size(198, 23);
            this.FolderPathTBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.FolderPathTBox.TabIndex = 1;
            this.FolderPathTBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FolderSearchBtn
            // 
            this.FolderSearchBtn.Location = new System.Drawing.Point(233, 62);
            this.FolderSearchBtn.Name = "FolderSearchBtn";
            this.FolderSearchBtn.Size = new System.Drawing.Size(59, 23);
            this.FolderSearchBtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.FolderSearchBtn.TabIndex = 0;
            this.FolderSearchBtn.Text = "Обзор";
            this.FolderSearchBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FolderSearchBtn.Click += new System.EventHandler(this.FolderSearchBtn_Click);
            // 
            // FilesLBox
            // 
            this.FilesLBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FilesLBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilesLBox.ForeColor = System.Drawing.SystemColors.Window;
            this.FilesLBox.FormattingEnabled = true;
            this.FilesLBox.Location = new System.Drawing.Point(10, 132);
            this.FilesLBox.Name = "FilesLBox";
            this.FilesLBox.Size = new System.Drawing.Size(300, 145);
            this.FilesLBox.TabIndex = 2;
            this.FilesLBox.SelectedIndexChanged += new System.EventHandler(this.FilesLBox_SelectedIndexChanged);
            // 
            // FileNameLbl
            // 
            this.FileNameLbl.AutoSize = true;
            this.FileNameLbl.Location = new System.Drawing.Point(10, 310);
            this.FileNameLbl.Name = "FileNameLbl";
            this.FileNameLbl.Size = new System.Drawing.Size(77, 19);
            this.FileNameLbl.Style = MetroFramework.MetroColorStyle.Yellow;
            this.FileNameLbl.TabIndex = 3;
            this.FileNameLbl.Text = "Имя файла";
            this.FileNameLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ArtistLbl
            // 
            this.ArtistLbl.AutoSize = true;
            this.ArtistLbl.Location = new System.Drawing.Point(10, 380);
            this.ArtistLbl.Name = "ArtistLbl";
            this.ArtistLbl.Size = new System.Drawing.Size(89, 19);
            this.ArtistLbl.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ArtistLbl.TabIndex = 4;
            this.ArtistLbl.Text = "Исполнитель";
            this.ArtistLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(10, 451);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(68, 19);
            this.NameLbl.Style = MetroFramework.MetroColorStyle.Yellow;
            this.NameLbl.TabIndex = 5;
            this.NameLbl.Text = "Название";
            this.NameLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FileNameTBox
            // 
            this.FileNameTBox.Location = new System.Drawing.Point(10, 332);
            this.FileNameTBox.Name = "FileNameTBox";
            this.FileNameTBox.Size = new System.Drawing.Size(300, 23);
            this.FileNameTBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.FileNameTBox.TabIndex = 6;
            this.FileNameTBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ArtistTBox
            // 
            this.ArtistTBox.Location = new System.Drawing.Point(10, 403);
            this.ArtistTBox.Name = "ArtistTBox";
            this.ArtistTBox.Size = new System.Drawing.Size(300, 23);
            this.ArtistTBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ArtistTBox.TabIndex = 7;
            this.ArtistTBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // NameTBox
            // 
            this.NameTBox.Location = new System.Drawing.Point(10, 473);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.Size = new System.Drawing.Size(300, 23);
            this.NameTBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.NameTBox.TabIndex = 8;
            this.NameTBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(216, 516);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(92, 23);
            this.OkBtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.OkBtn.TabIndex = 9;
            this.OkBtn.Text = "Применить";
            this.OkBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(10, 516);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(92, 23);
            this.DelBtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.DelBtn.TabIndex = 10;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(10, 284);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(300, 23);
            this.metroProgressBar1.Step = 1;
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroProgressBar1.TabIndex = 11;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressBar1.Visible = false;
            // 
            // PrepareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 560);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.NameTBox);
            this.Controls.Add(this.ArtistTBox);
            this.Controls.Add(this.FileNameTBox);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.ArtistLbl);
            this.Controls.Add(this.FileNameLbl);
            this.Controls.Add(this.FilesLBox);
            this.Controls.Add(this.FolderPathTBox);
            this.Controls.Add(this.FolderSearchBtn);
            this.Controls.Add(this.ScanBtn);
            this.Name = "PrepareForm";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Prepare";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton ScanBtn;
        private MetroFramework.Controls.MetroTextBox FolderPathTBox;
        private MetroFramework.Controls.MetroButton FolderSearchBtn;
        private System.Windows.Forms.ListBox FilesLBox;
        private MetroFramework.Controls.MetroLabel FileNameLbl;
        private MetroFramework.Controls.MetroLabel ArtistLbl;
        private MetroFramework.Controls.MetroLabel NameLbl;
        private MetroFramework.Controls.MetroTextBox FileNameTBox;
        private MetroFramework.Controls.MetroTextBox ArtistTBox;
        private MetroFramework.Controls.MetroTextBox NameTBox;
        private MetroFramework.Controls.MetroButton OkBtn;
        private MetroFramework.Controls.MetroButton DelBtn;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
    }
}