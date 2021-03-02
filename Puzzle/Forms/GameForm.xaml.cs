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
using System.Windows.Threading;
//using System.Windows.Forms;

using ClassLibrary;

namespace Puzzle
{
    /// <summary>
    /// Логика взаимодействия для GameForm.xaml
    /// </summary>
    /// 
    public partial class GameForm : Window
    {

        TimerForm tf;

        public GameForm()
        {
            InitializeComponent();
            //Визуализация картинки 
            //ShowImages.ImageToGameForm(Place); //(главной) //думаю не нужна
            //ShowImages.ImageToGameForm(Example); //(примера-маленькой)

            //Никнейм (label)
            LabelNicName.Content = ShowImages.NicName;

            //Время (label)
            tf = new TimerForm(0, LabelTime);
            tf.timer.Tick += timer_Tick;
            tf.Start();

            //TODO:Процесс сбора пазла (label)

		}

        //Подсчёт времени
		private void timer_Tick(object sender, EventArgs e)
		{
            if (LabelProcess.Content != "100") //LabelProcess.Content <= 100
            {
                tf.Second++;
                tf.span = TimeSpan.FromSeconds(tf.Second);
                tf.labelName.Content = tf.span.ToString("mm':'ss");
            }
            else tf.Stop();
        }
        

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ExitToMainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainMenu Mm = new MainMenu();
            Close();
            Mm.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
        }




        Vector relativeMousePos;
        FrameworkElement draggedObject;

        void StartDrag(object sender, MouseButtonEventArgs e)
        {
            draggedObject = (FrameworkElement)sender;
            relativeMousePos = e.GetPosition(draggedObject) - new Point();
            draggedObject.MouseMove += OnDragMove;
            draggedObject.LostMouseCapture += OnLostCapture;
            draggedObject.MouseUp += OnMouseUp;
            Mouse.Capture(draggedObject);
        }
        void OnDragMove(object sender, MouseEventArgs e)
        {
            UpdatePosition(e);
        }
        void UpdatePosition(MouseEventArgs e)
        {
            var point = e.GetPosition(CanvasArena);
            var newPos = point - relativeMousePos;
            Canvas.SetLeft(draggedObject, newPos.X);
            Canvas.SetTop(draggedObject, newPos.Y);
        }
        void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            FinishDrag(sender, e);
            Mouse.Capture(null);
        }

        void OnLostCapture(object sender, MouseEventArgs e)
        {
            FinishDrag(sender, e);
        }
        void FinishDrag(object sender, MouseEventArgs e)
        {
            draggedObject.MouseMove -= OnDragMove;
            draggedObject.LostMouseCapture -= OnLostCapture;
            draggedObject.MouseUp -= OnMouseUp;
            UpdatePosition(e);
        }


        //проверка на совпадение и постановку
        private void ImMouseUp(object sender, MouseButtonEventArgs e) //при отпускании кнопки мыши
        {
            //if (Im1_1.Source == Im1_1_Nice.Source) Im1_1_Nice.Source = Im1_1.Source;
            if (Im1_1.Tag == Canvas1_1.Tag) Canvas1_1.Source = Im1_1.Source;


        }
    }
}
