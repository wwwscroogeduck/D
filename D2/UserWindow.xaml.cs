using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        private Entities database = new Entities();
        private ObservableCollection<User> userCollection;

        public UserWindow()
        {
            InitializeComponent();
            userCollection = new ObservableCollection<User>(database.User.ToList());
            UserWindowGrid.ItemsSource = userCollection;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var selectedUser = UserWindowGrid.SelectedItem as User;
            if (selectedUser == null)
            {
                MessageBox.Show("Пожалуйста, выберите пользователя для удаления.");
                return;
            }

            if (MessageBox.Show("Вы действительно хотите удалить пользователя?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                userCollection.Remove(selectedUser);  // Удаляем из коллекции
                database.User.Remove(selectedUser);  // Удаляем из базы данных
                database.SaveChanges();              // Сохраняем изменения
                MessageBox.Show("Пользователь успешно удален.");
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var selectedUser = UserWindowGrid.SelectedItem as User;
            if (selectedUser != null)
            {
                // Открываем окно редактирования, передаем выбранного пользователя
                EditWindow editWindow = new EditWindow(selectedUser);
                var result = editWindow.ShowDialog();

                // Если изменения были сохранены, обновляем данные
                if (result == true)
                {
                    database.SaveChanges();  // Сохраняем изменения в базе данных
                    MessageBox.Show("Данные успешно обновлены.");
                    UserWindowGrid.Items.Refresh(); // Обновляем отображение в DataGrid
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите пользователя для редактирования.");
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddWindow();
            addWindow.ShowDialog(); // Ожидаем, пока пользователь закроет окно
            RefreshData();
        }

        private void RefreshData()
        {
            userCollection.Clear();
            foreach (var user in database.User.ToList()) userCollection.Add(user);
        }
    }
}