using System.Windows;

namespace RenderTargetBitmapTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static System.Windows.Media.Imaging.RenderTargetBitmap SaveFrameworkElementToImage(FrameworkElement ui, double renderScale = 1)
        {
            System.Windows.Media.Imaging.RenderTargetBitmap bmp = new(
                (int)(ui.ActualWidth * renderScale),
                (int)(ui.ActualHeight * renderScale),
                96d * renderScale,
                96d * renderScale,
                System.Windows.Media.PixelFormats.Default);
            bmp.Render(ui);

            return bmp;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ImageRender.Source = SaveFrameworkElementToImage(GridInViewBox, 1);
            ImageWindowRender.Source = SaveFrameworkElementToImage(this, 1);
        }
    }
}