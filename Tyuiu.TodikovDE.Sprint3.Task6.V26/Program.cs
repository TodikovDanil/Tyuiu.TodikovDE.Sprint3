using Tyuiu.TodikovDE.Sprint3.Task6.V26.Lib;
namespace Tyuiu.TodikovDE.Sprint3.Task6.V26
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Тодиков Д. Э. | ИСТНб-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спритн #3                                                              *");
            Console.WriteLine("* Тема: Создания итогого решения по спринту                              *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #26                                                            *");
            Console.WriteLine("* Выполнил: Тодиков Даниил Эдуардович | ИСТНб-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");


            DataService ds = new DataService();

            int startValue = 15;
            int stopValue = 22;
            Console.WriteLine("Начало шага " + startValue);
            Console.WriteLine("Конец шага " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма делителей " + ds.GetSumTheDivisors(startValue,stopValue));
        }
    }
}