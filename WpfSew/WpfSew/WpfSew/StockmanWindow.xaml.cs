using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfSew
{
    /// <summary>
    /// Логика взаимодействия для StockmanWindow.xaml
    /// </summary>
    public partial class StockmanWindow : Window
    {
        public StockmanWindow(int w, int h, string img)
        {
            InitializeComponent();
            canvas.Width = w;
            canvas.Height = h;
            canvas.Background = new ImageBrush(new BitmapImage(new Uri(img)));
        }

        private void Bofd_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Рисунки|*.png;*.jpg;"
            };
            if (openFile.ShowDialog()==true)
            { MessageBox.Show(openFile.FileName); }
            Rectangle rec = new Rectangle()
            {
                Width = 100,
                Height = 100,
                Fill = new ImageBrush(new BitmapImage(new Uri(openFile.FileName))),
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = HorizontalAlignment.Left
            };
            rec.MouseDown += Rec_MouseDown;
            canvas.Children.Add(rec);
        }

        private void Rec_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog()
            {
                Filter = "Рисунки|*.png;"
            };
            if (saveFile.ShowDialog() == true)
            {
                RenderTargetBitmap render = new RenderTargetBitmap((int)canvas.Width, (int)canvas.Height, 96, 96, PixelFormats.Pbgra32);
                render.Render(canvas);
                using (var file = File.Open(saveFile.FileName, FileMode.OpenOrCreate))
                {
                    PngBitmapEncoder png = new PngBitmapEncoder();
                    png.Frames.Add(BitmapFrame.Create(render));
                    png.Save(file);
                }
            }


        }
    }
}
