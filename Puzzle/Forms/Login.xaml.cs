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
            if (InputName.Text == "") MessageBox.Show("Введите свой никнейм (хотя бы 1 символ)","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            else
            {
                //Закрытие Login и открытие MainMenu
                GlobalClass.NickName = InputName.Text;
                MainMenu Mm = new MainMenu();
                Close();
                Mm.Show();
            }
        }
    }
}
