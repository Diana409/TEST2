using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для WindowPillow.xaml
    /// </summary>
    public partial class WindowPillow : Window
    {
        public WindowPillow()
        {
            InitializeComponent();
        }
        string img;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Рисунки|*.png;*.jpg;"
            };
            if (openFile.ShowDialog() == true) {
                img = openFile.FileName;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Entity.OpenWindow(this, new StockmanWindow(Convert.ToInt32(tw.Text), Convert.ToInt32(th.Text), img));
        }
    }
}
