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
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
        }

        private void BOK_Click(object sender, RoutedEventArgs e)
        {
            if (TLog.Text.Length > 5 && Pass.Password.Length > 5 && ConfirmPass.Password.Length > 5)
            {
                if (Pass.Password == ConfirmPass.Password)
                {
                    Пользователь пользователь = new Пользователь()
                    {
                        Логин = TLog.Text,
                        Наименование = TName.Text,
                        Роль = "Заказчик",
                        Пароль = Pass.Password
                    };
                    Entity.sew.Пользователь.Add(пользователь);
                    Entity.sew.SaveChanges();
                    MessageBox.Show("Пользователь успешно зарегистрирован!");
                    Entity.OpenWindow(this, new AutoWindow());
                }
                else { MessageBox.Show("Пароли не совпадают!"); }
            }
            else MessageBox.Show("Не все необходимые поля заполнены!");
        }
    }
}
