using Microsoft.Win32;
using System.Windows;
using ClassLibrary;

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

            //GlobalClass.Record(name, tim);
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            ThemePuzzle TP = new ThemePuzzle();
            Close();
            TP.ShowDialog();
        }

        private void AboutTheProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Задание: Разработать игру Пазлы. \nДанная игра содержит несколько тематических уровней, в каждом из которых имеется несколько пазлов\nРазработал: \nСтудент группы П-42 \nРумянцев Вадим Андреевич", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
