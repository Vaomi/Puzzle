using System.Windows;

using ClassLibrary;

namespace Puzzle
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void RegistrButton_Click(object sender, RoutedEventArgs e)
        {
            //Закрытие Login и открытие MainMenu
            ShowImages.NicName = InputName.Text;
            MainMenu Mm = new MainMenu();
            Close();
            Mm.Show();
        }
    }
}
