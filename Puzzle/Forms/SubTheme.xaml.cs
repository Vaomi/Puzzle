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
    /// Логика взаимодействия для SubTheme.xaml
    /// </summary>
    public partial class SubTheme : Window
    {
        public SubTheme()
        {
            InitializeComponent();

            GlobalClass.RandomAnimalImage(B_Cats, Cat);
            GlobalClass.RandomAnimalImage(B_Dogs, Dog);
            GlobalClass.RandomAnimalImage(B_Fishs, Fish);
            GlobalClass.RandomAnimalImage(B_Insects, Insects);
            GlobalClass.RandomAnimalImage(B_Rodents, Rodent);
            GlobalClass.RandomAnimalImage(B_Snakes, Snake);
        }

        private void Dog_Click(object sender, RoutedEventArgs e)
        {
            GlobalClass.Hepler = "Dog";
            SelectPuzzle ST = new SelectPuzzle();
            ST.ShowDialog();
        }

        private void Cat_Click(object sender, RoutedEventArgs e)
        {
            GlobalClass.Hepler = "Cat";
            SelectPuzzle ST = new SelectPuzzle();
            ST.ShowDialog();
        }

        private void Fish_Click(object sender, RoutedEventArgs e)
        {
            GlobalClass.Hepler = "Fish";
            SelectPuzzle ST = new SelectPuzzle();
            ST.ShowDialog();
        }

        private void Insects_Click(object sender, RoutedEventArgs e)
        {
            GlobalClass.Hepler = "Insects";
            SelectPuzzle ST = new SelectPuzzle();
            ST.ShowDialog();
        }

        private void Rodent_Click(object sender, RoutedEventArgs e)
        {
            GlobalClass.Hepler = "Rodent";
            SelectPuzzle ST = new SelectPuzzle();
            ST.ShowDialog();
        }

        private void Snake_Click(object sender, RoutedEventArgs e)
        {
            GlobalClass.Hepler = "Snake";
            SelectPuzzle ST = new SelectPuzzle();
            ST.ShowDialog();
        }
    }
}
