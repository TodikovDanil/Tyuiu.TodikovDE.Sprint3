using Tyuiu.TodikovDE.Sprint3.Task4.V1.Lib;
namespace Tyuiu.TodikovDE.Sprint3.Task4.V1
{
        internal class Program
        {
            private static void Main(string[] args)
            {
                Console.Title = "Спринт #3 | Выполнил: Тодиков Д. Э. | ИСТНб-24-1";
                Console.WriteLine("**************************************************************************");
                Console.WriteLine("* Спритн #3                                                              *");
                Console.WriteLine("* Тема: Создания итогого решения по спринту                              *");
                Console.WriteLine("* Задание #3                                                             *");
                Console.WriteLine("* Вариант #1                                                             *");
                Console.WriteLine("* Выполнил: Тодиков Даниил Эдуардович | ИСТНб-24-1                       *");
                Console.WriteLine("**************************************************************************");
                Console.WriteLine("*                                                                        *");
                Console.WriteLine("**************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
                Console.WriteLine("**************************************************************************");


                DataService ds = new DataService();
                int startValue = -5;
                int stopValue = 5;

                Console.WriteLine("Начало шага " + startValue);
                Console.WriteLine("Конец шага " + startValue);
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine("Полученая строка " + ds.Calculate(startValue, stopValue));
                Console.ReadKey();
            }
        }
}