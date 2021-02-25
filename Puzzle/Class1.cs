using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Puzzle
{
    public static class Class1
    {
        public static void RandomAnimalImage(Image Im1, Button But1)
        {
            int num;
            Random rand = new Random();
            num = rand.Next(1, 8);
            BitmapImage BMI = new BitmapImage();
            BMI.BeginInit();
            BMI.UriSource = new Uri($"/Image/Animal/{But1.Name}/{But1.Name}{num}.jpg", UriKind.Relative);
            BMI.EndInit();
            Im1.Source = BMI;
        }

        //Рандомная картинка в кнопке в "Выбор темы - ThemePuzzle"
        public static void RandomImage(Image Im1, Button But1) 
        {
            int num, theme;            
            Random randNum = new Random();
            num = randNum.Next(1, 8);
            Random randTheme = new Random();
            theme = randTheme.Next(1, 6);
            BitmapImage BMI = new BitmapImage();
            BMI.BeginInit();
            if(But1.Name !="Animal") BMI.UriSource = new Uri($"/Image/{But1.Name}/{But1.Name}{num}.jpg", UriKind.Relative);
            else
            {
                if (theme == 1) BMI.UriSource = new Uri($"/Image/Animal/Cat/Cat{num}.jpg", UriKind.Relative);
                else if (theme == 2) BMI.UriSource = new Uri($"/Image/Animal/Dog/Dog{num}.jpg", UriKind.Relative);
                else if (theme == 3) BMI.UriSource = new Uri($"/Image/Animal/Fish/Fish{num}.jpg", UriKind.Relative);
                else if (theme == 4) BMI.UriSource = new Uri($"/Image/Animal/Insects/Insects{num}.jpg", UriKind.Relative);
                else if (theme == 5) BMI.UriSource = new Uri($"/Image/Animal/Rodent/Rodent{num}.jpg", UriKind.Relative);
                else if (theme == 6) BMI.UriSource = new Uri($"/Image/Animal/Snake/Snake{num}.jpg", UriKind.Relative);
            }
            BMI.EndInit();
            Im1.Source = BMI;
        }
    }
}
