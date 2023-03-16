using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Project.WPF.View.UserControls;
using Faker;
using Project.WPF.Models;
using Project.WPF.DataBase;

namespace Project.WPF.View
{
    public partial class ChatPage : Page
    {
        AppConext db = new AppConext();
        private ObservableCollection<ChatItem> chatItems = new ObservableCollection<ChatItem>();

        public ChatPage()
        {
            InitializeComponent();
        }

        private void LoadPage(object sender, RoutedEventArgs e)
        {
            chatItems.Clear();
            // connect with db

        }

        private void textBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Отправка сообщения!");
            Message message = new Message() { Text = textBox.Text, Avtor = "I" };
            db.Messages.Add(message);
            db.SaveChanges();
        }
    }
}
