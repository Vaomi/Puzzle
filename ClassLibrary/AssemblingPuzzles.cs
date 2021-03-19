using System;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ClassLibrary
{
    public static class AssemblingPuzzles
    {
        public static double process;

        //СБОРОЧКА ПАЗЛИКОВ (сравнение координат источника и итога) можно подкоректироватть координаты, а так работает
        public static void Assembly_of_Puzzles(Image Orig, Image Place)
        {
            
            int O_V = Convert.ToInt32(Canvas.GetTop(Orig)),
                O_H = Convert.ToInt32(Canvas.GetLeft(Orig));

            int V_From = 158, V_Before = 198,
                H_From = 221, H_Before = 261;
            for(int i = 1; i <= 16; i++)
            {
                if (i == 5 || i == 9 || i == 13) { V_From += 147; V_Before += 147; H_From = 221; H_Before = 261; }
                if (Convert.ToInt32(Orig.Tag) == i)
                {
                    if (O_V >= V_From && O_V <= V_Before &&
                        O_H >= H_From && O_H <= H_Before)
                    {
                        Place.Source = Orig.Source;
                        Orig.Visibility = Visibility.Collapsed;
                        process += 6.25;
                        break;
                    }
                }
                else
                {
                    H_From += 260; H_Before += 260;
                }
            }
        }

        static int number = 0;
        //вставка частей
        public static void RandomParts(Image Im)
        {
            string theme = ShowImages.Theme,
                          Help = ShowImages.Hepler,
                          num = ShowImages.Number;

            if (number == 16) number = 0; number++;
            BitmapImage BMI = new BitmapImage();
            BMI.BeginInit();
            if (theme != "Animal") BMI.UriSource = new Uri($"/Image/{theme}/{theme}{num}/Im{number}.jpg", UriKind.Relative);
            else BMI.UriSource = new Uri($"/Image/Animal/{Help}/{Help}{num}/Im{number}.jpg", UriKind.Relative);
            BMI.EndInit();
            Im.Source = BMI;
        }
    }
}
