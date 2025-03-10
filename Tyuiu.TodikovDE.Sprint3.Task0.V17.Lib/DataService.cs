﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TodikovDE.Sprint3.Task0.V17.Lib
{
    public class DataService : ISprint3Task0V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries += Math.Cos(i) * 1 / 2;
            }
            return Math.Round(sumSeries,3);
        }
    }
}
