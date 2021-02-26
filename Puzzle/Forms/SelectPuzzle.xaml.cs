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
            //TODO: сделать вывод на форму
            for(int i = 1; i < 9; i++)
            {
                //GlobalClass.СorrectSelectPuzzle(B_Puzzle[i],Puzzle1);
            }
        }
    }
}
