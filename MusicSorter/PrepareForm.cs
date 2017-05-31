using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

namespace MusicSorter
{
    public partial class PrepareForm : MetroFramework.Forms.MetroForm
    {
        List<Mp3file> mp3files;

        struct Mp3file
        {
            string artist;
            string name;
            string fileName;
            string fullPath;

            public string Name { get => name; set => name = value; }
            public string Artist { get => artist; set => artist = value; }
            public string FileName { get => fileName; set => fileName = value; }
            public string FullPath { get => fullPath; set => fullPath = value; }
        }

        public static string toUtf8(string unknown)
        {
            return new string(unknown.ToCharArray().
                Select(x => ((x + 848) >= 'А' && (x + 848) <= 'ё') ? (char)(x + 848) : x).
                ToArray());
        }

        public PrepareForm()
        {
            InitializeComponent();
        }

        private void FolderSearchBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                FolderPathTBox.Text = fbd.SelectedPath;
            }
        }

        private void ScanBtn_Click(object sender, EventArgs e)
        {
            FilesLBox.Items.Clear();
            mp3files = new List<Mp3file>();
            string[] files = Directory.GetFiles(FolderPathTBox.Text);
            for (int i = 0; i < files.Length; i++)
                if (files[i].Contains("mp3"))
                {
                    var mp3file = TagLib.File.Create(files[i]);
                    Mp3file newFile = new Mp3file();
                    newFile.Artist = mp3file.Tag.Performers.Length != 0 ? toUtf8(mp3file.Tag.Performers[0]) : "";
                    newFile.Name = mp3file.Tag.Title != null ? toUtf8(mp3file.Tag.Title) : "";
                    newFile.FileName = Path.GetFileNameWithoutExtension(files[i]);
                    newFile.FullPath = files[i];
                    mp3files.Add(newFile);
                    FilesLBox.Items.Add(mp3files[mp3files.Count - 1].FileName);
                }
        }

        private void FilesLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilesLBox.SelectedIndex >= 0)
            {
                FileNameTBox.Text = mp3files[FilesLBox.SelectedIndex].FileName;
                ArtistTBox.Text = mp3files[FilesLBox.SelectedIndex].Artist;
                NameTBox.Text = mp3files[FilesLBox.SelectedIndex].Name;
            }
            else
            {
                FileNameTBox.Text = "";
                ArtistTBox.Text = "";
                NameTBox.Text = "";
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            TagLib.File tagFile = TagLib.File.Create(mp3files[FilesLBox.SelectedIndex].FullPath);
            tagFile.Tag.Performers = new string[1] { ArtistTBox.Text };
            tagFile.Tag.Title = new string(NameTBox.Text.ToCharArray());
            tagFile.Tag.Album = new string(String.Empty.ToCharArray());
            tagFile.Save();
            mp3files.RemoveAt(FilesLBox.SelectedIndex);
            FilesLBox.Items.RemoveAt(FilesLBox.SelectedIndex);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (FilesLBox.SelectedIndex >= 0)
            {
                int oldIndex = FilesLBox.SelectedIndex;
                FileSystem.DeleteFile(mp3files[FilesLBox.SelectedIndex].FullPath, UIOption.AllDialogs, RecycleOption.SendToRecycleBin, UICancelOption.ThrowException);
                mp3files.RemoveAt(FilesLBox.SelectedIndex);
                FilesLBox.Items.RemoveAt(FilesLBox.SelectedIndex);
                if (FilesLBox.Items.Count > 0)
                    if (oldIndex - 1 == FilesLBox.Items.Count - 1) FilesLBox.SelectedIndex = oldIndex - 1;
                    else FilesLBox.SelectedIndex = oldIndex;
            }
        }
    }
}
