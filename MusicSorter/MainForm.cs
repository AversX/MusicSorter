using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MusicSorter
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            if (folderPath1TBox.Text != "" && folderPath2TBox.Text != "")
            {
                string[] files = Directory.GetFiles(folderPath1TBox.Text);
                for (int i = 0; i < files.Length; i++)
                {
                    if (files[i].Contains("mp3"))
                    {
                        var mp3file = TagLib.File.Create(files[i]);
                        string dir = String.Join(", ", mp3file.Tag.Performers.Length != 0 ? StringConverter.toUtf8(mp3file.Tag.Performers[0]) : "");
                        for (int k = 0; k < dir.Length; k++)
                            if (dir[k] == ':' || dir[k] == '\\' || dir[k] == '|' || dir[k] == '/' || dir[k] == '<' || dir[k] == '>' || dir[k] == '*' || dir[k] == '?' || dir[k] == '\"')
                            {
                                dir = dir.Remove(k, 1);
                                k--;
                            }
                        string name = StringConverter.toUtf8(mp3file.Tag.Title) + ".mp3";
                        string path = folderPath2TBox.Text + @"\" + dir;
                        if (dir != "")
                        {
                            if (!Directory.Exists(path))
                                Directory.CreateDirectory(path);
                            try
                            {
                                File.Copy(files[i], path + @"\" + name);
                            }
                            catch (IOException)
                            {
                                File.Copy(files[i], path + @"\" + "111" + name);
                            }
                        }
                        else
                        {
                            if (!Directory.Exists("1Unknown")) Directory.CreateDirectory(folderPath2TBox.Text + @"\" + "1Unknown");
                            try
                            {
                                File.Copy(files[i], path + @"\" + name);
                            }
                            catch (IOException)
                            {
                                File.Copy(files[i], path + @"\" + "111" + name);
                            }
                        }
                    }
                }
                MetroFramework.Forms.MetroMessageBox msgBox = new MetroFramework.Forms.MetroMessageBox();
                msgBox.Text = "Завершено";
                msgBox.Style = MetroFramework.MetroColorStyle.Yellow;
                msgBox.Theme = MetroFramework.MetroThemeStyle.Light;
                msgBox.Size = new Size(284,109);
                msgBox.Show();
            }
        }

        private void SearchBtn2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                folderPath2TBox.Text = fbd.SelectedPath;
            }
        }

        private void SearchBtn1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                folderPath1TBox.Text = fbd.SelectedPath;
            }
        }

        private void PrepareFormShowBtn_Click(object sender, EventArgs e)
        {
            PrepareForm pFrom = new PrepareForm();
            pFrom.ShowDialog();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex==1 && this.Height!=595)
            {
                for(int i=0; i<67; i++)
                    this.Height+=5;
            }
            else if(metroTabControl1.SelectedIndex == 0 && this.Height != 260)
            {
                for (int i = 0; i < 67; i++)
                    this.Height -= 5;
            }
        }
    }
}
