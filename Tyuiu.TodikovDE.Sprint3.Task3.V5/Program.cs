using Tyuiu.TodikovDE.Sprint3.Task3.V5.Lib;
namespace Tyuiu.TodikovDE.Sprint3.Task3.V5
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
            Console.WriteLine("* Вариант #5                                                             *");
            Console.WriteLine("* Выполнил: Тодиков Даниил Эдуардович | ИСТНб-24-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");


            DataService ds = new DataService();
            string value = "fifa al fall";
            char replaceable = 'a';
            char replacement = '*';
            Console.WriteLine("Исходная строка " + value);
            Console.WriteLine("Исходная символ " + replaceable);
            Console.WriteLine("Итоговый символ" + replacement);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Полученая строка " + ds.ReplaceCharInString(value, replaceable , replacement));
            Console.ReadKey();

        }
    }
}