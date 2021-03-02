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
    /// Логика взаимодействия для Records.xaml
    /// </summary>
    public partial class RecordsForm : Window
    {
        //List<RecordList> recordLists;
        //public RecordsForm(List<RecordList> lists)
        public RecordsForm()
        {
            InitializeComponent();

            //recordLists = lists;
            //Score.ItemsSource = recordLists;

        }

        private void Record_Loaded(object sender, RoutedEventArgs e)
        {

        }

    }
}
