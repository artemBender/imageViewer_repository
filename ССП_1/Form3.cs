using ImageMagick;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ССП_1
{

    public partial class Form3 : Form
    {
        private Bitmap originalBitmap; // Оригинальное изображение
        private static Bitmap currentBitmap; // Текущее изображение с примененными эффектами

        private int contrastValue = 0;
        private int brightnessValue = 0;
        private int exposureValue = 0;
        private int zoomValue = 0;

        public Form3()
        {
            InitializeComponent();
            previousButton.Click += previousButton_Click;
            nextButton.Click += nextButton_Click;
            contrastTrackBar.ValueChanged += contrastTrackBar_ValueChanged;
            exposureTrackBar.ValueChanged += exposureTrackBar_ValueChanged;
            brightnessTrackBar.ValueChanged += brightnessTrackBar_Scroll;
            zoomBar.ValueChanged += zoomBar_Scroll;
            DisplaySelectedPhoto();
        }

        public void DisplaySelectedPhoto()
        {
            if (ImageViewer.currentIndex >= 0 && ImageViewer.currentIndex < ImageViewer.photoFiles.Count)
            {
                string currentFilePath = ImageViewer.photoFiles[ImageViewer.currentIndex];
                try
                {
                    CheckImage(currentFilePath);  // Проверяем изображение на повреждение
                    Text = Path.GetFileName(currentFilePath);
                    selectedPictureBox.Image = Image.FromFile(currentFilePath);
                    selectedPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    statusLabel.Text = $"Изображение {ImageViewer.currentIndex + 1} из {ImageViewer.photoFiles.Count}";
                    previousButton.Enabled = ImageViewer.currentIndex > 0;
                    nextButton.Enabled = ImageViewer.currentIndex < ImageViewer.photoFiles.Count - 1;
                    originalBitmap = new Bitmap(selectedPictureBox.Image);
                    currentBitmap = new Bitmap(originalBitmap);
                    panel3.Enabled = true;
                }
                catch (ImageCorruptedException ex)
                {
                    Text = ex.ErrorMessage;  // Отображаем сообщение об ошибке
                    statusLabel.Text = $"Изображение {ImageViewer.currentIndex + 1} из {ImageViewer.photoFiles.Count}";
                    selectedPictureBox.Image = null;
                    panel3.Enabled = false;
                }
            }
        }

        public void CheckImage(string imagePath)
        {
            try
            {
                // Проверяем доступность файла
                using (FileStream fileStream = File.OpenRead(imagePath))
                {
                    // Проверяем размер файла
                    if (fileStream.Length == 0)
                    {
                        throw new ImageCorruptedException("Файл пустой.", ImageErrorType.EmptyFile);
                    }

                    // Проверяем расширение файла

                    // Загружаем изображение
                    using (MagickImage image = new MagickImage(imagePath))
                    {
                        // Изображение не повреждено
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw new ImageCorruptedException("Файл не найден.", ImageErrorType.FileNotFound);
            }
            catch (UnauthorizedAccessException)
            {
                throw new ImageCorruptedException("Отказано в доступе к файлу.", ImageErrorType.AccessDenied);
            }
            catch (MagickException)
            {
                throw new ImageCorruptedException("Изображение повреждено или не может быть загружено.", ImageErrorType.Corrupted);
            }
        }
    


        private void recoveryBars()
        {
            contrastTrackBar.Value = 0;
            exposureTrackBar.Value = 0;
            brightnessTrackBar.Value = 0;
            contrastValue = 0;
            brightnessValue = 0;
            exposureValue = 0;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (ImageViewer.currentIndex > 0)
            {
                recoveryBars();
                ImageViewer.currentIndex--;
                DisplaySelectedPhoto();
            }
            zoomBar.Value = 0;
            zoomValue = 0;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (ImageViewer.currentIndex < ImageViewer.photoFiles.Count - 1)
            {
                recoveryBars();
                ImageViewer.currentIndex++;
                DisplaySelectedPhoto();
            }
            zoomBar.Value = 0;
            zoomValue = 0;
        }


        private void contrastTrackBar_ValueChanged(object sender, EventArgs e)
        {
            contrastValue = contrastTrackBar.Value;
            label1.Text = $"Контрастность: {contrastValue}";
            ApplyEffects();
        }

        // Обработчик события изменения значения ползунка экспозиции
        private void exposureTrackBar_ValueChanged(object sender, EventArgs e)
        {
            exposureValue = exposureTrackBar.Value;
            label2.Text = $"Экспозиция: {exposureValue}";
            ApplyEffects();
        }

        // Обработчик события изменения значения ползунка яркости
        private void brightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            brightnessValue = brightnessTrackBar.Value;
            label3.Text = $"Яркость: {brightnessTrackBar.Value}";
            ApplyEffects();
        }


        private void ApplyEffects()
        {
            currentBitmap = new Bitmap(originalBitmap);
            ImageAdjustments.AdjustContrast(currentBitmap, contrastValue);
            ImageAdjustments.AdjustBrightness(currentBitmap, brightnessValue);
            ImageAdjustments.AdjustExposure(currentBitmap, exposureValue);
            selectedPictureBox.Image = currentBitmap;
        }

      

        private void save_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Image Files (*.jpg,*.jpeg, *.png)|*.jpeg, *.jpg;*.png";
                saveDialog.Title = "Save Image";
                saveDialog.FileName = "image"; // Начальное имя файла

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveDialog.FileName;
                    originalBitmap.Save(savePath);
                    MessageBox.Show("Изображение успешно сохранено.");
                }
            }
        }


        private Bitmap RotateImage(Bitmap image, float angle)
        {
            int newWidth, newHeight;

            if (angle == 90 || angle == -90 || angle == 270 || angle == -270)
            {
                newWidth = image.Height;
                newHeight = image.Width;
            }
            else
            {
                double radians = Math.Abs(angle) * Math.PI / 180.0;
                double cosine = Math.Cos(radians);
                double sine = Math.Sin(radians);

                newWidth = (int)Math.Round(image.Width * cosine + image.Height * sine);
                newHeight = (int)Math.Round(image.Width * sine + image.Height * cosine);
            }

            Bitmap rotatedImage = new Bitmap(newWidth, newHeight);
            rotatedImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            using (Graphics graphics = Graphics.FromImage(rotatedImage))
            {
                graphics.TranslateTransform(rotatedImage.Width / 2, rotatedImage.Height / 2);
                graphics.RotateTransform(angle);
                graphics.TranslateTransform(-image.Width / 2, -image.Height / 2);
                graphics.DrawImage(image, new Point(0, 0));
            }

            return rotatedImage;
        }


        private void rotate_270_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(selectedPictureBox.Image);
            selectedPictureBox.Image = RotateImage(originalImage, -90);
        }

        private void rotate_90_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(selectedPictureBox.Image);
            selectedPictureBox.Image = RotateImage(originalImage, 90);
        }

        public Image ApplyNegativeEffect(Image originalImage)
        {
            Bitmap bitmap = new Bitmap(originalImage);
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(
                        255 - pixelColor.R,
                        255 - pixelColor.G,
                        255 - pixelColor.B
                    );
                    bitmap.SetPixel(x, y, invertedColor);
                }
            }
            return bitmap;
        }

        private void negative_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(originalBitmap);
            selectedPictureBox.Image = ApplyNegativeEffect(originalImage);
        }


        public Image ApplyBlackAndWhiteEffect(Image originalImage)
        {
            Bitmap bitmap = new Bitmap(originalImage);
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    int grayScale = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                    Color grayColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    bitmap.SetPixel(x, y, grayColor);
                }
            }
            return bitmap;
        }

        private void black_and_white_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(originalBitmap);
            selectedPictureBox.Image = ApplyBlackAndWhiteEffect(originalImage);
        }
        public Image ApplySepiaEffect(Image originalImage)
        {    
            Bitmap bitmap = new Bitmap(originalImage);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);

                    int r = (int)(pixelColor.R * 0.393 + pixelColor.G * 0.769 + pixelColor.B * 0.189);
                    int g = (int)(pixelColor.R * 0.349 + pixelColor.G * 0.686 + pixelColor.B * 0.168);
                    int b = (int)(pixelColor.R * 0.272 + pixelColor.G * 0.534 + pixelColor.B * 0.131);

                    r = Math.Min(r, 255);
                    g = Math.Min(g, 255);
                    b = Math.Min(b, 255);
                    Color sepiaColor = Color.FromArgb(r, g, b);
                    bitmap.SetPixel(x, y, sepiaColor);
                }
            }
            return bitmap;

        }

        private void sepia_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(originalBitmap);
            selectedPictureBox.Image = ApplySepiaEffect(originalImage);
        }

        private void removeAll_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(originalBitmap);
            selectedPictureBox.Image = originalImage;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            Bitmap newBitmap = new Bitmap(selectedPictureBox.Image);
            originalBitmap = newBitmap;
            recoveryBars();
        }

        
        private void zoomBar_Scroll(object sender, EventArgs e)
        {
            zoomValue = zoomBar.Value;
            label6.Text = $"Масштаб: {zoomValue + 100} %";
            selectedPictureBox.Width = (int)(selectedPictureBox.Image.Width * (zoomValue * 0.01 + 1));
            selectedPictureBox.Height = (int)(selectedPictureBox.Image.Height * (zoomValue * 0.01 + 1));
        }

        
    }
}
    
    public static class ImageAdjustments
    {

    public static void checkPixel(ref float R, ref float G, ref float B)
    {
        if (R < 0) R = 0;
        if (R > 255) R = 255;
        if (G < 0) G = 0;
        if (G > 255) G = 255;
        if (B < 0) B = 0;
        if (B > 255) B = 255;
    }
    public static void checkPixel(ref int R, ref int G, ref int B)
    {
        if (R < 0) R = 0;
        if (R > 255) R = 255;
        if (G < 0) G = 0;
        if (G > 255) G = 255;
        if (B < 0) B = 0;
        if (B > 255) B = 255;
    }
    public static void AdjustContrast(Bitmap bitmap, int contrastValue)
        {
            float contrastFactor = (float)(100 + contrastValue) / 100;
            float contrast = contrastFactor * contrastFactor;

            // Применение контраста к каждому пикселю изображения
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    float adjustedR = ((((pixel.R / 255f) - 0.5f) * contrast) + 0.5f) * 255f;
                    float adjustedG = ((((pixel.G / 255f) - 0.5f) * contrast) + 0.5f) * 255f;
                    float adjustedB = ((((pixel.B / 255f) - 0.5f) * contrast) + 0.5f) * 255f;
                    checkPixel(ref adjustedR, ref adjustedG, ref adjustedB);
                    bitmap.SetPixel(x, y, Color.FromArgb((int)adjustedR, (int)adjustedG, (int)adjustedB));
                }
            }
        }

        public static void AdjustExposure(Bitmap bitmap, int exposureValue)
        {
            float exposureFactor = (float)exposureValue / 100;

            // Применение экспозиции к каждому пикселю изображения
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    float adjustedR = pixel.R + (pixel.R * exposureFactor);
                    float adjustedG = pixel.G + (pixel.G * exposureFactor);
                    float adjustedB = pixel.B + (pixel.B * exposureFactor);
                    checkPixel(ref adjustedR, ref adjustedG, ref adjustedB);
                    adjustedR = Math.Max(0, Math.Min(255, adjustedR));
                    adjustedG = Math.Max(0, Math.Min(255, adjustedG));
                    adjustedB = Math.Max(0, Math.Min(255, adjustedB));
                    bitmap.SetPixel(x, y, Color.FromArgb((int)adjustedR, (int)adjustedG, (int)adjustedB));
                }
            }
        }

        public static void AdjustBrightness(Bitmap bitmap, int brightnessValue)
        {
            // Применение яркости к каждому пикселю изображения
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);
                    int adjustedR = pixel.R + brightnessValue;
                    int adjustedG = pixel.G + brightnessValue;
                    int adjustedB = pixel.B + brightnessValue;
                    checkPixel(ref adjustedR, ref adjustedG, ref adjustedB);
                    adjustedR = Math.Max(0, Math.Min(255, adjustedR));
                    adjustedG = Math.Max(0, Math.Min(255, adjustedG));
                    adjustedB = Math.Max(0, Math.Min(255, adjustedB));
                    bitmap.SetPixel(x, y, Color.FromArgb(adjustedR, adjustedG, adjustedB));
                }
            }
        }
    }

public class ImageCorruptedException : Exception
{
    public ImageErrorType ErrorType { get; }

    public ImageCorruptedException(string message, ImageErrorType errorType) : base(message)
    {
        ErrorType = errorType;
    }

    public string ErrorMessage
    {
        get
        {
            switch (ErrorType)
            {
                case ImageErrorType.FileNotFound:
                    return "Файл не найден";
                case ImageErrorType.EmptyFile:
                    return "Файл пустой";
                case ImageErrorType.AccessDenied:
                    return "Отказано в доступе к файлу";
                case ImageErrorType.Corrupted:
                    return "Изображение повреждено или не может быть загружено";
                default:
                    return "Неизвестная ошибка";
            }
        }
    }
}

public enum ImageErrorType
{
    FileNotFound,
    EmptyFile,
    AccessDenied,
    Corrupted
}