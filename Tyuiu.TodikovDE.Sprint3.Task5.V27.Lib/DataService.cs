using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TodikovDE.Sprint3.Task5.V27.Lib
{
    public class DataService : ISprint3Task5V27
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            for (int i = startValue1; i <= startValue2; i++)
            {
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    sumSeries += (Math.Pow(j, x)) / Math.Cos(j);
                }
            }
            return Math.Round(sumSeries,3);
        }
    }
}
