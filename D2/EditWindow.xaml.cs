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
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        private User _user;

        public EditWindow(User user)
        {
            InitializeComponent();
            _user = user;

            // Заполняем поля данными пользователя
            FirstNameTextBox.Text = _user.first_name;
            LastNameTextBox.Text = _user.second_name;
            EmailTextBox.Text = _user.email;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Сохраняем изменения в объекте пользователя
            _user.first_name = FirstNameTextBox.Text;
            _user.second_name = LastNameTextBox.Text;
            _user.email = EmailTextBox.Text;

            // Закрываем окно
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Закрываем окно без изменений
            DialogResult = false;
            Close();
        }
    }
}
