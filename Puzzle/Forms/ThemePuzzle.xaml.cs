using System.Windows;

using ClassLibrary;


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

            ShowImages.RandomImage(B_Animal,Animal);
            ShowImages.RandomImage(B_Arch, Architecture);
            ShowImages.RandomImage(B_Cartoon, Cartoons);
            ShowImages.RandomImage(B_Game, Game);
            ShowImages.RandomImage(B_Nature, Nature);

        }

        private void Animal_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Theme = "Animal";
            SubTheme ST = new SubTheme();
            ST.ShowDialog();
        }

        private void Archit_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Theme = "Architecture";
            ShowImages.Hepler = "Architecture";
            SelectPuzzle SP = new SelectPuzzle();
            SP.ShowDialog();
        }

        private void Nature_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Theme = "Nature";
            ShowImages.Hepler = "Nature";
            SelectPuzzle SP = new SelectPuzzle();
            SP.ShowDialog();
        }

        private void Cartoons_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Theme = "Cartoons";
            ShowImages.Hepler = "Cartoons";
            SelectPuzzle SP = new SelectPuzzle();
            SP.ShowDialog();
        }

        private void Games_Click(object sender, RoutedEventArgs e)
        {
            ShowImages.Theme = "Game";
            ShowImages.Hepler = "Game";
            SelectPuzzle SP = new SelectPuzzle();
            SP.ShowDialog();
        }
    }
}
