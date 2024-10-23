using Tyuiu.TodikovDE.Sprint3.Task0.V17.Lib;
namespace Tyuiu.TodikovDE.Sprint3.Task0.V17
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Тодиков Д. Э. | ИСТНб-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спритн #3                                                              *");
            Console.WriteLine("* Тема: Создания итогого решения по спринту                              *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #17                                                            *");
            Console.WriteLine("* Выполнил: Тодиков Даниил Эдуардович | ИСТНб-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            
            
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine("Начало шага " + startValue);
            Console.WriteLine("Конец шага " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries( startValue, stopValue));
        }

    }
}