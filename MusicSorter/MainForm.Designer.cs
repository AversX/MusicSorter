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
            this.PrepareFormShowBtn = new MetroFramework.Controls.MetroButton();
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
            this.SortBtn.Location = new System.Drawing.Point(102, 172);
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
            this.SearchBtn2.Location = new System.Drawing.Point(203, 125);
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
            this.SearchBtn1.Location = new System.Drawing.Point(203, 63);
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
            this.folderPath1TBox.Location = new System.Drawing.Point(12, 63);
            this.folderPath1TBox.Name = "folderPath1TBox";
            this.folderPath1TBox.Size = new System.Drawing.Size(185, 23);
            this.folderPath1TBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.folderPath1TBox.TabIndex = 4;
            this.folderPath1TBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // folderPath2TBox
            // 
            this.folderPath2TBox.Location = new System.Drawing.Point(12, 125);
            this.folderPath2TBox.Name = "folderPath2TBox";
            this.folderPath2TBox.Size = new System.Drawing.Size(185, 23);
            this.folderPath2TBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.folderPath2TBox.TabIndex = 5;
            this.folderPath2TBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // PrepareFormShowBtn
            // 
            this.PrepareFormShowBtn.Location = new System.Drawing.Point(3, 242);
            this.PrepareFormShowBtn.Name = "PrepareFormShowBtn";
            this.PrepareFormShowBtn.Size = new System.Drawing.Size(284, 40);
            this.PrepareFormShowBtn.Style = MetroFramework.MetroColorStyle.Yellow;
            this.PrepareFormShowBtn.TabIndex = 6;
            this.PrepareFormShowBtn.Text = "Подготовка";
            this.PrepareFormShowBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PrepareFormShowBtn.Click += new System.EventHandler(this.PrepareFormShowBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 288);
            this.Controls.Add(this.PrepareFormShowBtn);
            this.Controls.Add(this.folderPath2TBox);
            this.Controls.Add(this.folderPath1TBox);
            this.Controls.Add(this.SearchBtn1);
            this.Controls.Add(this.SearchBtn2);
            this.Controls.Add(this.SortBtn);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "MusicSorter";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
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
        private MetroFramework.Controls.MetroButton PrepareFormShowBtn;
    }
}

