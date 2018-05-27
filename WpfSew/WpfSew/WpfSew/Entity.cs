using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfSew;

namespace WpfSew
{
    public static class Entity
    {        
        public static SewEntities1 sew = new SewEntities1();

        public static Пользователь user { get; set; }

        public static void OpenWindow(dynamic thisF, dynamic newF){
            thisF.Hide();
            newF.Show();
            thisF.Close();
        }
    }
}
