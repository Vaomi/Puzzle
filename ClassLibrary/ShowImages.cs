using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace ClassLibrary
{
    public static class ShowImages
    {
        //"Глобальные" переменные
        public static string
            Hepler, //Выбор подтемы в Animal
            Theme, //Выбор темы, не считая Animal
            Number; //Номер картинки в SelectPuzzle
        //Таблица рекордов
        public static string NicName;


        //Рандомная картинка в кнопке в "Выбор темы (ThemePuzzle)"
        public static void RandomImage(Image Im1, Button But1)
        {
            int num, theme;
            Random randNum = new Random();
            num = randNum.Next(1, 8);
            Random randTheme = new Random();
            theme = randTheme.Next(1, 6);
            BitmapImage BMI = new BitmapImage();
            BMI.BeginInit();

            //для всех остальных
            //if (But1.Name != "Animal") BMI.UriSource = new Uri($"/Image/{But1.Name}/{But1.Name}{num}.jpg", UriKind.Relative);
            if (But1.Name != "Animal") BMI.UriSource = new Uri($"/Image/{But1.Name}/{But1.Name}{num}/{But1.Name}{num}.jpg", UriKind.Relative);
            //для Animal
            else
            {
                //if (theme == 1) BMI.UriSource = new Uri($"/Image/Animal/Cat/Cat{num}.jpg", UriKind.Relative); и тд
                if (theme == 1) BMI.UriSource = new Uri($"/Image/Animal/Cat/Cat{num}/Cat{num}.jpg", UriKind.Relative);
                else if (theme == 2) BMI.UriSource = new Uri($"/Image/Animal/Dog/Dog{num}/Dog{num}.jpg", UriKind.Relative);
                else if (theme == 3) BMI.UriSource = new Uri($"/Image/Animal/Fish/Fish{num}/Fish{num}.jpg", UriKind.Relative);
                else if (theme == 4) BMI.UriSource = new Uri($"/Image/Animal/Insects/Insects{num}/Insects{num}.jpg", UriKind.Relative);
                else if (theme == 5) BMI.UriSource = new Uri($"/Image/Animal/Rodent/Rodent{num}/Rodent{num}.jpg", UriKind.Relative);
                else if (theme == 6) BMI.UriSource = new Uri($"/Image/Animal/Snake/Snake{num}/Snake{num}.jpg", UriKind.Relative);
            }
            BMI.EndInit();
            Im1.Source = BMI;
        }

        //Рандомная картинка в теме Animal (SubTheme)
        public static void RandomAnimalImage(Image Im1, Button But1)
        {
            int num;
            Random rand = new Random();
            num = rand.Next(1, 8);
            BitmapImage BMI = new BitmapImage();
            BMI.BeginInit();
            //BMI.UriSource = new Uri($"/Image/Animal/{But1.Name}/{But1.Name}{num}.jpg", UriKind.Relative);
            BMI.UriSource = new Uri($"/Image/Animal/{But1.Name}/{But1.Name}{num}/{But1.Name}{num}.jpg", UriKind.Relative);
            BMI.EndInit();
            Im1.Source = BMI;
        }

        
        //Последовательная картинка на вывод в SelectPuzzle из SubTheme
        static int num = 0; //Указатель на номер рисунка
        public static void СorrectSelectPuzzle(Image Im1)
        {
            if (num == 8) num = 0; num++; //Указатель на номер рисунка
            BitmapImage BMI = new BitmapImage();
            BMI.BeginInit();
            //if (Theme != "Animal") BMI.UriSource = new Uri($"/Image/{Hepler}/{Hepler}{num}.jpg", UriKind.Relative);
            if (Theme != "Animal") BMI.UriSource = new Uri($"/Image/{Hepler}/{Hepler}{num}/{Hepler}{num}.jpg", UriKind.Relative);
            //else BMI.UriSource = new Uri($"/Image/Animal/{Hepler}/{Hepler}{num}.jpg", UriKind.Relative);
            else BMI.UriSource = new Uri($"/Image/Animal/{Hepler}/{Hepler}{num}/{Hepler}{num}.jpg", UriKind.Relative);
            BMI.EndInit();
            Im1.Source = BMI;
        }

        //Отображение картинки в GameForm
        public static void ImageToGameForm(Image Im1)
        {
            BitmapImage BMI = new BitmapImage();
            BMI.BeginInit();
            //if (Theme != "Animal") BMI.UriSource = new Uri($"/Image/{Theme}/{Theme}{Number}.jpg", UriKind.Relative);
            if (Theme != "Animal") BMI.UriSource = new Uri($"/Image/{Theme}/{Theme}{Number}/{Theme}{Number}.jpg", UriKind.Relative);
            //else BMI.UriSource = new Uri($"/Image/Animal/{Hepler}/{Hepler}{Number}.jpg", UriKind.Relative);
            else BMI.UriSource = new Uri($"/Image/Animal/{Hepler}/{Hepler}{Number}/{Hepler}{Number}.jpg", UriKind.Relative);
            BMI.EndInit();
            Im1.Source = BMI;
        }

    }
}
