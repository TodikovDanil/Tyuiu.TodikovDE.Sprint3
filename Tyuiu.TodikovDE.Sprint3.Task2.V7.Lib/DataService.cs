﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TodikovDE.Sprint3.Task2.V7.Lib
{
    public class DataService : ISprint3Task2V7
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            do
            {
                sumSeries += Math.Pow(1 / (Math.Sin(startValue)), 2);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(sumSeries,3);
        }
    }
}
