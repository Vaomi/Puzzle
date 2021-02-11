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
using System.Windows.Forms;
using System.Windows.Media.Animation;


namespace Puzzle
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();

            /*DoubleAnimation buttonAnimation = new DoubleAnimation();
            //buttonAnimation.From = helloButton.ActualWidth;
            buttonAnimation.From = 75;
            buttonAnimation.To = 150;
            buttonAnimation.SpeedRatio = 2;
            buttonAnimation.Duration = TimeSpan.FromSeconds(3);
            helloButton.BeginAnimation(System.Windows.Controls.Button.WidthProperty, buttonAnimation);
            */
        }

        private void helloButton_Click(object sender, RoutedEventArgs e)
        {




            //Закрытие Login и открытие MainMenu
            MainMenu Mm = new MainMenu();
            Close();
            Mm.Show();
            
        }
    }
}
