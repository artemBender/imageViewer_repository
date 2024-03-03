using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ССП_1
{
    
    public partial class ImageViewer : Form
    {
        private List<Photo> playlist = new List<Photo>();
        private string folderPath; // Путь к папке с фотографиями
        public static List<string> photoFiles; // Список путей к фотографиям
        public static int currentIndex; // Индекс текущей отображаемой фотографии
        private string[] supportedExtensions = { ".jpg", ".jpeg", ".png" }; // Поддерживаемые форматы файлов

        public ImageViewer()
        {
            InitializeComponent();
            browseButton.Click += browseButton_Click;
            addButton.Click += addButton_Click;
            removeButton.Click += deleteButton_Click;
            listView.MouseDoubleClick += listView_MouseDoubleClick;
            photoFiles = new List<string>();
            //ImageViewer_Load();
            //FormClosing += ImageViewer_FormClosing;
        }


        private void ImageViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Записываем адреса открытых фотографий в файл при закрытии приложения
            if (photoFiles != null)
            {
                File.WriteAllLines("opened_photos.txt", photoFiles);
            }
        }

        private async void ImageViewer_Load()
        {
            // Читаем адреса открытых фотографий из файла при открытии приложения
            if (File.Exists("opened_photos.txt"))
            {
                List<string> importedPhotoFiles = File.ReadAllLines("opened_photos.txt")
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .ToList();
                if (importedPhotoFiles.Count > 0)
                {
                    currentIndex = 0;
                    foreach (string filePath in importedPhotoFiles)
                    {
                       
                            string fileName = Path.GetFileName(filePath);
                            playlist.Add(new Photo(fileName, filePath));
                            photoFiles.Add(filePath);
                        
                    }

                    await DisplayPhotosAsync();
                }
                else
                {
                    MessageBox.Show("Плейлист пуст.");

                }
                UpdatePlaylist();
            }
        }
        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selected = listView.GetItemAt(e.X, e.Y);
            if (selected != null)
            {
                string fileName = selected.Text;
                Photo photo = playlist.FirstOrDefault(p => p.FileName == fileName);
                if (photo != null)
                {
                    currentIndex = photoFiles.IndexOf(photo.FilePath);
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                    form3.DisplaySelectedPhoto();
                }
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selected in listView.SelectedItems)
            {
                string fileName = selected.Text;
                Photo photo = playlist.FirstOrDefault(p => p.FileName == fileName);
                if (photo != null)
                {
                    playlist.Remove(photo);
                    photoFiles.Remove(photo.FilePath);
                    flowLayoutPanel.Controls.RemoveByKey(photo.FilePath);
                }
            }

            UpdatePlaylist();
        }

        private void LoadPhotos()
        {
            List<string> newPhotoFiles = Directory.GetFiles(folderPath)
                .Where(file => supportedExtensions.Contains(Path.GetExtension(file).ToLower()))
                .ToList();

            foreach (string filePath in newPhotoFiles)
            {
                string fileName = Path.GetFileName(filePath);
                playlist.Add(new Photo(fileName, filePath));
                photoFiles.Add(filePath);
            }

            UpdatePlaylist();
        }

        private void UpdatePlaylist()
        {
            listView.Items.Clear();

            foreach (Photo photo in playlist)
            {
                listView.Items.Add(photo.FileName);
            }
        }

        private async Task DisplayPhotosAsync()
        {
            flowLayoutPanel.Controls.Clear();

            foreach (string filePath in photoFiles)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Width = 200;
                pictureBox.Height = 200;
                pictureBox.Margin = new Padding(5);
                pictureBox.Tag = filePath;
                pictureBox.Click += pictureBox_Click;
                pictureBox.Name = filePath;

                flowLayoutPanel.Controls.Add(pictureBox);
                await LoadImageAsync(pictureBox, filePath);
            }

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            string filePath = (string)pictureBox.Tag;
            currentIndex = photoFiles.IndexOf(filePath);
            Form3 form3 = new Form3();
            form3.ShowDialog();
            form3.DisplaySelectedPhoto();
        }

        private async void browseButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    folderPath = folderDialog.SelectedPath;
                    LoadPhotos();
                    if (photoFiles.Count > 0)
                    {
                        currentIndex = 0;
                        await DisplayPhotosAsync();
                    }
                    else
                    {
                        MessageBox.Show("В выбранной папке нет поддерживаемых изображений.");
                    }
                }
            }
        }


        private async void addButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений|*.jpg;*.jpeg;*.png";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    currentIndex = 0;
                    PictureBox pictureBox = new PictureBox();
                    photoFiles.Add(filePath);
                    string fileName = Path.GetFileName(filePath);
                    playlist.Add(new Photo(fileName, filePath));
                    await LoadImageAsync(pictureBox, filePath);
                }
                UpdatePlaylist();
            }
            await DisplayPhotosAsync();
        }

        private async Task LoadImageAsync(PictureBox pictureBox, string filePath)
        {
            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    await Task.Run(() =>
                    {
                        Image image = Image.FromStream(stream);
                        pictureBox.Image = image;
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);
            }

        }

        private void removeAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selected in listView.Items)
            {
                string fileName = selected.Text;
                Photo photo = playlist.FirstOrDefault(p => p.FileName == fileName);
                if (photo != null)
                {
                    playlist.Remove(photo);
                    photoFiles.Remove(photo.FilePath);
                    flowLayoutPanel.Controls.RemoveByKey(photo.FilePath);
                }
            }

            UpdatePlaylist();
        }

        private void writePlaylist_Click(object sender, EventArgs e)
        {
            if (photoFiles != null)
            {
                File.WriteAllLines("opened_photos.txt", photoFiles);
            }
        }

        private void openPlaylist_Click(object sender, EventArgs e)
        {
            ImageViewer_Load();
        }
    }
}


public class Photo
{
    public string FileName { get; set; }
    public string FilePath { get; set; }

    public Photo(string fileName, string filePath)
    {
        FileName = fileName;
        FilePath = filePath;
    }
}