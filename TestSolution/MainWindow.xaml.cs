using Microsoft.Win32;
using System.Windows;
using System.Windows.Media.Imaging;

namespace TestSolution;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

    }

    private void LoadFromUrl_Click(object sender, RoutedEventArgs e)
    {
        UpdateSkin(UrlInput.Text);
    }

    private void LoadFromFile_Click(object sender, RoutedEventArgs e)
    {
        var openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Minecraft Skin (*.png)|*.png";
        if (openFileDialog.ShowDialog() == true)
        {
            UrlInput.Text = openFileDialog.FileName;
            UpdateSkin(openFileDialog.FileName);
        }
    }


    private void UpdateSkin(string path)
    {
        try
        {
            var bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(path, UriKind.RelativeOrAbsolute);
            bitmap.CacheOption = BitmapCacheOption.OnLoad;
            bitmap.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
            bitmap.EndInit();

            PlayerPreview.SkinSource = bitmap;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка: {ex.Message}");
        }

    }
}