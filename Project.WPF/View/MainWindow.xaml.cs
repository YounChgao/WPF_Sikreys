using Project.WPF.Models;
using Project.WPF.DataBase;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Project.WPF.View;

namespace Project.WPF
{
    public partial class MainWindow : Window
    {
        AppConext db = new AppConext();
        public MainWindow()
        {
            InitializeComponent();

            /*using (AppConext db = new AppConext())
            {
                // создаем два объекта User
                User tom = new User { Name = "Tom" };
                User alice = new User { Name = "Alice" };
                User bob = new User { Name = "Bob" };

                // добавляем их в бд
                db.Users.Add(tom);
                db.Users.Add(alice);
                db.Users.Add(bob);
                db.SaveChanges();
            }*/

            List<User> users = db.Users.ToList();
            listOfChats.ItemsSource = users;
        }

        private void EnterChat_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Смена окна!");
        }
    }
}
