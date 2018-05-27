using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для WindowFabric.xaml
    /// </summary>
    public partial class WindowFabric : Window
    {
        public WindowFabric()
        {
            InitializeComponent();
            dgf.ItemsSource = Entity.sew.Ткани.Select(x => new { x.Артикул, x.Длина, x.Ширина, x.Наименование, x.Состав, x.Цвет, x.Цена }).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
