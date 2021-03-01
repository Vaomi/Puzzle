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

using ClassLibrary;

namespace Puzzle
{
    /// <summary>
    /// Логика взаимодействия для SubTheme.xaml
    /// </summary>
    public partial class SubTheme : Window
    {
        public SubTheme()
        {
            InitializeComponent();

            ShowImages.RandomAnimalImage(B_Cats, Cat);
            ShowImages.RandomAnimalImage(B_Dogs, Dog);
            ShowImages.RandomAnimalImage(B_Fishs, Fish);
            ShowImages.RandomAnimalImage(B_Insects, Insects);
            ShowImages.RandomAnimalImage(B_Rodents, Rodent);
            ShowImages.RandomAnimalImage(B_Snakes, Snake);
        }

        private void Dog_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Hepler = "Dog";
            SelectPuzzle ST = new SelectPuzzle();
            ST.ShowDialog();
        }

        private void Cat_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Hepler = "Cat";
            SelectPuzzle ST = new SelectPuzzle();
            ST.ShowDialog();
        }

        private void Fish_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Hepler = "Fish";
            SelectPuzzle ST = new SelectPuzzle();
            ST.ShowDialog();
        }

        private void Insects_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Hepler = "Insects";
            SelectPuzzle ST = new SelectPuzzle();
            ST.ShowDialog();
        }

        private void Rodent_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Hepler = "Rodent";
            SelectPuzzle ST = new SelectPuzzle();
            ST.ShowDialog();
        }

        private void Snake_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Hepler = "Snake";
            SelectPuzzle ST = new SelectPuzzle();
            ST.ShowDialog();
        }
    }
}
