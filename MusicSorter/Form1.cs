using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicSorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                folderPath1TBox.Text = fbd.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                folderPath2TBox.Text = fbd.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderPath1TBox.Text!="" && folderPath2TBox.Text!="")
            {
                string[] files = Directory.GetFiles(folderPath1TBox.Text);
                for (int i = 0; i < files.Length; i++)
                {
                    if (files[i].Contains("mp3"))
                    {
                        var mp3file = TagLib.File.Create(files[i]);
                        string dir = String.Join(", ", mp3file.Tag.Performers);
                        for (int k = 0; k < dir.Length; k++)
                            if (dir[k] == ':' || dir[k] == '\\' || dir[k] == '|' || dir[k] == '/' || dir[k] == '<' || dir[k] == '>' || dir[k] == '*' || dir[k] == '?' || dir[k]=='\"')
                            {
                                dir = dir.Remove(k, 1);
                                k--;
                            }
                        string[] str = files[i].Split('\\');
                        string name = str[str.Length - 1];
                        for (int k=0; k<name.Length; k++)
                            if (name[k] == ':' || name[k] == '\\' || name[k] == '|' || name[k] == '/' || name[k] == '<' || name[k] == '>' || name[k] == '*' || name[k] == '?' || name[k] == '\"')
                            {
                                name = name.Remove(k, 1);
                                k--;
                            }
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
                MessageBox.Show("Завершено");
            }
        }
    }
}
