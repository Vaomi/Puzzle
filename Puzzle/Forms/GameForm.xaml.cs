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

namespace Puzzle
{
    /// <summary>
    /// Логика взаимодействия для GameForm.xaml
    /// </summary>
    public partial class GameForm : Window
    {
        public GameForm()
        {
            InitializeComponent();

            GlobalClass.ImageToGameForm(Example);
            NicName.Content = "Никнейм - "+GlobalClass.NicName;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ExitToMainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainMenu Mm = new MainMenu();
            Close();
            Mm.Show();
        }
    }
}
