using System.Windows;
using System.Windows.Controls;

using ClassLibrary;

namespace Puzzle
{
    /// <summary>
    /// Логика взаимодействия для SelectPuzzle.xaml
    /// </summary>
    public partial class SelectPuzzle : Window
    {
        public SelectPuzzle()
        {
            InitializeComponent();
            //Вывод на форму SelectPuzzle картинки в button

            Button[] but = new Button[8]
            {
                Puzzle1,
                Puzzle2,
                Puzzle3,
                Puzzle4,
                Puzzle5,
                Puzzle6,
                Puzzle7,
                Puzzle8,
            };
            foreach(Button puzl in but)
            {
                ShowImages.СorrectSelectPuzzle((Image)puzl.Content);
            }
        }

        
        //Присваивание бля каждого button определённого индекса и вызов SelectPuzzle
        private void Puzzle1_Click(object sender, RoutedEventArgs e) 
        {
            ShowImages.Number = "1";
            GameForm gf = new GameForm();
            gf.ShowDialog();
        }

        private void Puzzle2_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Number = "2";
            GameForm gf = new GameForm();
            gf.ShowDialog();
        }

        private void Puzzle3_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Number = "3";
            GameForm gf = new GameForm();
            gf.ShowDialog();
        }
        private void Puzzle4_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Number = "4";
            GameForm gf = new GameForm();
            gf.ShowDialog();
        }

        private void Puzzle5_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Number = "5";
            GameForm gf = new GameForm();
            gf.ShowDialog();
        }

        private void Puzzle6_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Number = "6";
            GameForm gf = new GameForm();
            gf.ShowDialog();
        }

        private void Puzzle7_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Number = "7";
            GameForm gf = new GameForm();
            gf.ShowDialog();
        }

        private void Puzzle8_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Number = "8";
            GameForm gf = new GameForm();
            gf.ShowDialog();
        }
    }
}
