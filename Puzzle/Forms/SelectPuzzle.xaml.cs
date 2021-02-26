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
                GlobalClass.СorrectSelectPuzzle((Image)puzl.Content);
            }
        }

        //Присваивание бля каждого button определённого индекса
        private void Puzzle1_Click(object sender, RoutedEventArgs e) => GlobalClass.Number = "1";

        private void Puzzle2_Click(object sender, RoutedEventArgs e) => GlobalClass.Number = "2";

        private void Puzzle3_Click(object sender, RoutedEventArgs e) => GlobalClass.Number = "3";

        private void Puzzle4_Click(object sender, RoutedEventArgs e) => GlobalClass.Number = "4";

        private void Puzzle5_Click(object sender, RoutedEventArgs e) => GlobalClass.Number = "5";

        private void Puzzle6_Click(object sender, RoutedEventArgs e) => GlobalClass.Number = "6";

        private void Puzzle7_Click(object sender, RoutedEventArgs e) => GlobalClass.Number = "7";

        private void Puzzle8_Click(object sender, RoutedEventArgs e) => GlobalClass.Number = "8";
    }
}
