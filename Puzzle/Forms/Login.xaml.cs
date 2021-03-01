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
using System.Windows.Forms;
using System.Windows.Media.Animation;
using MessageBox = System.Windows.Forms.MessageBox;

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
