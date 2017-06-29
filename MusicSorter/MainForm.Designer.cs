namespace MusicSorter
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SortBtn = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SearchBtn2 = new MetroFramework.Controls.MetroButton();
            this.SearchBtn1 = new MetroFramework.Controls.MetroButton();
            this.folderPath1TBox = new MetroFramework.Controls.MetroTextBox();
            this.folderPath2TBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.DelBtn = new MetroFramework.Controls.MetroButton();
            this.OkBtn = new MetroFramework.Controls.MetroButton();
            this.NameTBox = new MetroFramework.Controls.MetroTextBox();
            this.ArtistTBox = new MetroFramework.Controls.MetroTextBox();
            this.FileNameTBox = new MetroFramework.Controls.MetroTextBox();
            this.NameLbl = new MetroFramework.Controls.MetroLabel();
            this.ArtistLbl = new MetroFramework.Controls.MetroLabel();
            this.FileNameLbl = new MetroFramework.Controls.MetroLabel();
            this.FilesLBox = new System.Windows.Forms.ListBox();
            this.FolderPathTBox = new MetroFramework.Controls.MetroTextBox();
            this.FolderSearchBtn = new MetroFramework.Controls.MetroButton();
            this.ScanBtn = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // SortBtn
            // 
            this.SortBtn.Location = new System.Drawing.Point(101, 122);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(95, 23);
            this.SortBtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.SortBtn.TabIndex = 2;
            this.SortBtn.Text = "Сортировать";
            this.SortBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            // 
            // SearchBtn2
            // 
            this.SearchBtn2.Location = new System.Drawing.Point(202, 75);
            this.SearchBtn2.Name = "SearchBtn2";
            this.SearchBtn2.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.SearchBtn2.TabIndex = 3;
            this.SearchBtn2.Text = "Обзор...";
            this.SearchBtn2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SearchBtn2.Click += new System.EventHandler(this.SearchBtn2_Click);
            // 
            // SearchBtn1
            // 
            this.SearchBtn1.Location = new System.Drawing.Point(202, 13);
            this.SearchBtn1.Name = "SearchBtn1";
            this.SearchBtn1.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.SearchBtn1.TabIndex = 3;
            this.SearchBtn1.Text = "Обзор...";
            this.SearchBtn1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SearchBtn1.Click += new System.EventHandler(this.SearchBtn1_Click);
            // 
            // folderPath1TBox
            // 
            this.folderPath1TBox.Location = new System.Drawing.Point(11, 13);
            this.folderPath1TBox.Name = "folderPath1TBox";
            this.folderPath1TBox.Size = new System.Drawing.Size(185, 23);
            this.folderPath1TBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.folderPath1TBox.TabIndex = 4;
            this.folderPath1TBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // folderPath2TBox
            // 
            this.folderPath2TBox.Location = new System.Drawing.Point(11, 75);
            this.folderPath2TBox.Name = "folderPath2TBox";
            this.folderPath2TBox.Size = new System.Drawing.Size(185, 23);
            this.folderPath2TBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.folderPath2TBox.TabIndex = 5;
            this.folderPath2TBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.ItemSize = new System.Drawing.Size(145, 31);
            this.metroTabControl1.Location = new System.Drawing.Point(8, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(301, 535);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTabControl1.TabIndex = 7;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseStyleColors = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.folderPath2TBox);
            this.metroTabPage1.Controls.Add(this.folderPath1TBox);
            this.metroTabPage1.Controls.Add(this.SortBtn);
            this.metroTabPage1.Controls.Add(this.SearchBtn1);
            this.metroTabPage1.Controls.Add(this.SearchBtn2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroTabPage1.Size = new System.Drawing.Size(293, 496);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Sort";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTabPage2.Controls.Add(this.metroProgressBar1);
            this.metroTabPage2.Controls.Add(this.DelBtn);
            this.metroTabPage2.Controls.Add(this.OkBtn);
            this.metroTabPage2.Controls.Add(this.NameTBox);
            this.metroTabPage2.Controls.Add(this.ArtistTBox);
            this.metroTabPage2.Controls.Add(this.FileNameTBox);
            this.metroTabPage2.Controls.Add(this.NameLbl);
            this.metroTabPage2.Controls.Add(this.ArtistLbl);
            this.metroTabPage2.Controls.Add(this.FileNameLbl);
            this.metroTabPage2.Controls.Add(this.FilesLBox);
            this.metroTabPage2.Controls.Add(this.FolderPathTBox);
            this.metroTabPage2.Controls.Add(this.FolderSearchBtn);
            this.metroTabPage2.Controls.Add(this.ScanBtn);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(293, 496);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Prepare";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(0, 232);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(293, 23);
            this.metroProgressBar1.Step = 1;
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroProgressBar1.TabIndex = 24;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressBar1.Visible = false;
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(0, 464);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(92, 23);
            this.DelBtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.DelBtn.TabIndex = 23;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(198, 464);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(92, 23);
            this.OkBtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.OkBtn.TabIndex = 22;
            this.OkBtn.Text = "Применить";
            this.OkBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // NameTBox
            // 
            this.NameTBox.Location = new System.Drawing.Point(0, 421);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.Size = new System.Drawing.Size(293, 23);
            this.NameTBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.NameTBox.TabIndex = 21;
            this.NameTBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ArtistTBox
            // 
            this.ArtistTBox.Location = new System.Drawing.Point(0, 351);
            this.ArtistTBox.Name = "ArtistTBox";
            this.ArtistTBox.Size = new System.Drawing.Size(293, 23);
            this.ArtistTBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ArtistTBox.TabIndex = 20;
            this.ArtistTBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FileNameTBox
            // 
            this.FileNameTBox.Location = new System.Drawing.Point(0, 280);
            this.FileNameTBox.Name = "FileNameTBox";
            this.FileNameTBox.Size = new System.Drawing.Size(293, 23);
            this.FileNameTBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.FileNameTBox.TabIndex = 19;
            this.FileNameTBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(-4, 399);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(68, 19);
            this.NameLbl.Style = MetroFramework.MetroColorStyle.Yellow;
            this.NameLbl.TabIndex = 18;
            this.NameLbl.Text = "Название";
            this.NameLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // ArtistLbl
            // 
            this.ArtistLbl.AutoSize = true;
            this.ArtistLbl.Location = new System.Drawing.Point(-4, 328);
            this.ArtistLbl.Name = "ArtistLbl";
            this.ArtistLbl.Size = new System.Drawing.Size(89, 19);
            this.ArtistLbl.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ArtistLbl.TabIndex = 17;
            this.ArtistLbl.Text = "Исполнитель";
            this.ArtistLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FileNameLbl
            // 
            this.FileNameLbl.AutoSize = true;
            this.FileNameLbl.Location = new System.Drawing.Point(-4, 258);
            this.FileNameLbl.Name = "FileNameLbl";
            this.FileNameLbl.Size = new System.Drawing.Size(77, 19);
            this.FileNameLbl.Style = MetroFramework.MetroColorStyle.Yellow;
            this.FileNameLbl.TabIndex = 16;
            this.FileNameLbl.Text = "Имя файла";
            this.FileNameLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FilesLBox
            // 
            this.FilesLBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FilesLBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilesLBox.ForeColor = System.Drawing.SystemColors.Window;
            this.FilesLBox.FormattingEnabled = true;
            this.FilesLBox.Location = new System.Drawing.Point(0, 80);
            this.FilesLBox.Name = "FilesLBox";
            this.FilesLBox.Size = new System.Drawing.Size(293, 145);
            this.FilesLBox.TabIndex = 15;
            this.FilesLBox.SelectedIndexChanged += new System.EventHandler(this.FilesLBox_SelectedIndexChanged);
            // 
            // FolderPathTBox
            // 
            this.FolderPathTBox.Location = new System.Drawing.Point(10, 10);
            this.FolderPathTBox.Name = "FolderPathTBox";
            this.FolderPathTBox.Size = new System.Drawing.Size(198, 23);
            this.FolderPathTBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.FolderPathTBox.TabIndex = 14;
            this.FolderPathTBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // FolderSearchBtn
            // 
            this.FolderSearchBtn.Location = new System.Drawing.Point(219, 10);
            this.FolderSearchBtn.Name = "FolderSearchBtn";
            this.FolderSearchBtn.Size = new System.Drawing.Size(59, 23);
            this.FolderSearchBtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.FolderSearchBtn.TabIndex = 12;
            this.FolderSearchBtn.Text = "Обзор";
            this.FolderSearchBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FolderSearchBtn.Click += new System.EventHandler(this.FolderSearchBtn_Click);
            // 
            // ScanBtn
            // 
            this.ScanBtn.Location = new System.Drawing.Point(42, 39);
            this.ScanBtn.Name = "ScanBtn";
            this.ScanBtn.Size = new System.Drawing.Size(146, 23);
            this.ScanBtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.ScanBtn.TabIndex = 13;
            this.ScanBtn.Text = "Сканировать";
            this.ScanBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ScanBtn.Click += new System.EventHandler(this.ScanBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 260);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "MusicSorter";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroButton SortBtn;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton SearchBtn2;
        private MetroFramework.Controls.MetroButton SearchBtn1;
        private MetroFramework.Controls.MetroTextBox folderPath1TBox;
        private MetroFramework.Controls.MetroTextBox folderPath2TBox;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroButton DelBtn;
        private MetroFramework.Controls.MetroButton OkBtn;
        private MetroFramework.Controls.MetroTextBox NameTBox;
        private MetroFramework.Controls.MetroTextBox ArtistTBox;
        private MetroFramework.Controls.MetroTextBox FileNameTBox;
        private MetroFramework.Controls.MetroLabel NameLbl;
        private MetroFramework.Controls.MetroLabel ArtistLbl;
        private MetroFramework.Controls.MetroLabel FileNameLbl;
        private System.Windows.Forms.ListBox FilesLBox;
        private MetroFramework.Controls.MetroTextBox FolderPathTBox;
        private MetroFramework.Controls.MetroButton FolderSearchBtn;
        private MetroFramework.Controls.MetroButton ScanBtn;
    }
}

