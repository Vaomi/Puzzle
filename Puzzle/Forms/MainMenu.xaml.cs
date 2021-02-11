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
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            ThemePuzzle TP = new ThemePuzzle();
            TP.ShowDialog();
        }

        private void Records_Click(object sender, RoutedEventArgs e)
        {
            Records rec = new Records();
            rec.ShowDialog();
        }

        private void AboutTheProgram_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
