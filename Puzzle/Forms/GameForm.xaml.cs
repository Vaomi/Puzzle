using ClassLibrary;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

            //Процесс сбора пазла (label)
            LabelProcess.Content = ClassLibrary.AssemblingPuzzles.process + "%";
        }

        //Подсчёт времени
        private void timer_Tick(object sender, EventArgs e)
        {
            if ((string)LabelProcess.Content != "100%")
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


        //Animation
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

        //Проверка пазлов на соприкосновение
        private void Im1_1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im1_1, Canvas1_1);
        private void Im1_2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im1_2, Canvas1_2);
        private void Im1_3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im1_3, Canvas1_3);
        private void Im1_4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im1_4, Canvas1_4);
        private void Im2_1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im2_1, Canvas2_1);
        private void Im2_2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im2_2, Canvas2_2);
        private void Im2_3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im2_3, Canvas2_3);
        private void Im2_4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im2_4, Canvas2_4);
        private void Im3_1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im3_1, Canvas3_1);
        private void Im3_2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im3_2, Canvas3_2);
        private void Im3_3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im3_3, Canvas3_3);
        private void Im3_4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im3_4, Canvas3_4);
        private void Im4_1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im4_1, Canvas4_1);
        private void Im4_2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im4_2, Canvas4_2);
        private void Im4_3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im4_3, Canvas4_3);
        private void Im4_4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => ClassLibrary.AssemblingPuzzles.Assembly_of_Puzzles(Im4_4, Canvas4_4);
        //Процесс сбора пазла (label)
        private void ProcessMouseUp(object sender, MouseButtonEventArgs e) => LabelProcess.Content = ClassLibrary.AssemblingPuzzles.process + "%";
    }
}