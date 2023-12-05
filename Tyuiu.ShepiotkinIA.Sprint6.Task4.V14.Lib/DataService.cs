using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShepiotkinIA.Sprint6.Task4.V14.Lib
{
    public class DataService : ISprint6Task4V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double F;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                F = Math.Round((2 * x - 4 + (2 * x - 1) / (Math.Sin(x) + 1)), 2);
                valueArray[count] = F;
                count++;

            }
            return valueArray;
        }
    }
}
