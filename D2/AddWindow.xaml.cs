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

namespace D2
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private Entities database = new Entities();

        public AddWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var newUser = new User
            {
                first_name = FirstNameTextBox.Text,
                second_name = LastNameTextBox.Text,
                email = EmailTextBox.Text
            };

            database.User.Add(newUser);
            database.SaveChanges();
            Close(); // Закрыть окно после сохранения
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close(); // Закрыть окно без изменений
        }
    }

}
