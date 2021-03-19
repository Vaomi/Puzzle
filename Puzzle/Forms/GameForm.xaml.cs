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
            ShowImages.ImageToGameForm(Example); //подсказка

            //Процесс сбора пазла (label)
            if (AssemblingPuzzles.process == 100) AssemblingPuzzles.process = 0;
            LabelProcess.Content = AssemblingPuzzles.process + "%";
            //LabelProcess.Content = "0%";

            //Никнейм (label)
            LabelNicName.Content = GlobalClass.NickName;

            //Время (label)
            tf = new TimerForm(0, LabelTime);
            tf.Stop();
            tf.timer.Tick += timer_Tick;
            tf.Start();

            //Заполнение частей пазлов
            Image[] but = new Image[16]
            {
                Im1,
                Im2,
                Im3,
                Im4,
                Im5,
                Im6,
                Im7,
                Im8,
                Im9,
                Im10,
                Im11,
                Im12,
                Im13,
                Im14,
                Im15,
                Im16,
            };
            foreach (Image puzl in but)
            {
                AssemblingPuzzles.RandomParts(puzl);
            }
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
            else if ((string)LabelProcess.Content == "100%")
            {
                tf.Stop();
                //GlobalClass.Time = (int)LabelTime.Content;
                MessageBox.Show("Вы Молодец! Закончили за " + LabelTime.Content, "Поздравление",MessageBoxButton.OK);
            }
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
        private void Im1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im1, Canvas1);
        private void Im2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im2, Canvas2);
        private void Im3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im3, Canvas3);
        private void Im4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im4, Canvas4);
        private void Im5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im5, Canvas5);
        private void Im6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im6, Canvas6);
        private void Im7_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im7, Canvas7);
        private void Im8_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im8, Canvas8);
        private void Im9_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im9, Canvas9);
        private void Im10_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im10, Canvas10);
        private void Im11_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im11, Canvas11);
        private void Im12_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im12, Canvas12);
        private void Im13_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im13, Canvas13);
        private void Im14_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im14, Canvas14);
        private void Im15_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im15, Canvas15);
        private void Im16_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) => AssemblingPuzzles.Assembly_of_Puzzles(Im16, Canvas16);
        //Процесс сбора пазла (label)
        private void ProcessMouseUp(object sender, MouseButtonEventArgs e) => LabelProcess.Content = AssemblingPuzzles.process + "%";
    }
}