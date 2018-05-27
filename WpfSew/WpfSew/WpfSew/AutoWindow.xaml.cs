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
using System.Data.SqlClient;

namespace WpfSew
{
    /// <summary>
    /// Логика взаимодействия для AutoWindow.xaml
    /// </summary>
    public partial class AutoWindow : Window
    {
        public AutoWindow()
        {
            InitializeComponent();
        }

        private void BOK_Click(object sender, RoutedEventArgs e)
        {
            if (TLog.Text.Length > 5 && Pass.Password.Length > 5)
            {
                Пользователь пользователь = Entity.sew.Пользователь.Where(x => x.Логин == TLog.Text && x.Пароль == Pass.Password).FirstOrDefault();
                if (пользователь != null)
                { Entity.user = пользователь;
                    MessageBox.Show("Вы вошли в систему как "+пользователь.Роль);
                    switch (пользователь.Роль)
                    {
                        case "Заказчик":
                            Entity.OpenWindow(this, new ClientWindow());
                            break;
                        default:
                            break;
                    }
                }
                else
                { MessageBox.Show("Логин или пароль введен неверно!"); }
            }
            else MessageBox.Show("Не все необходимые поля заполнены!");
        }

        private void BReg_Click(object sender, RoutedEventArgs e)
        {
            Entity.OpenWindow(this, new RegWindow());
        }
    }
}
