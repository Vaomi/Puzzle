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
    /// Логика взаимодействия для ThemePuzzle.xaml
    /// </summary>
    public partial class ThemePuzzle : Window
    {
        public ThemePuzzle()
        {
            InitializeComponent();

            Class1.RandomImage(B_Animal,Animal);
            Class1.RandomImage(B_Arch, Architecture);
            Class1.RandomImage(B_Cartoon, Cartoons);
            Class1.RandomImage(B_Game, Game);
            Class1.RandomImage(B_Nature, Nature);

        }

        private void Animal_Click(object sender, RoutedEventArgs e)
        {
            SubTheme ST = new SubTheme();
            ST.ShowDialog();
        }

        private void Archit_Click(object sender, RoutedEventArgs e)
        {
            SelectPuzzle SP = new SelectPuzzle();
            SP.ShowDialog();
        }

        private void Nature_Click(object sender, RoutedEventArgs e)
        {
            SelectPuzzle SP = new SelectPuzzle();
            SP.ShowDialog();
        }

        private void Cartoons_Click(object sender, RoutedEventArgs e)
        {
            SelectPuzzle SP = new SelectPuzzle();
            SP.ShowDialog();
        }

        private void Games_Click(object sender, RoutedEventArgs e)
        {
            SelectPuzzle SP = new SelectPuzzle();
            SP.ShowDialog();
        }
    }
}
