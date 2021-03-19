using System.Windows;

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
            RecordsForm rec = new RecordsForm();
            rec.ShowDialog();
        }

        private void AboutTheProgram_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
