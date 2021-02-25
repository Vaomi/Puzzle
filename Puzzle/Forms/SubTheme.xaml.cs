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

            Class1.RandomAnimalImage(B_Cats, Cat);
            Class1.RandomAnimalImage(B_Dogs, Dog);
            Class1.RandomAnimalImage(B_Fishs, Fish);
            Class1.RandomAnimalImage(B_Insects, Insects);
            Class1.RandomAnimalImage(B_Rodents, Rodent);
            Class1.RandomAnimalImage(B_Snakes, Snake);
        }

        private void Dog_Click(object sender, RoutedEventArgs e)
        {
            SelectPuzzle ST = new SelectPuzzle();
            ST.ShowDialog();
        }

        private void Cat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Fish_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Insects_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rodent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Snake_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
