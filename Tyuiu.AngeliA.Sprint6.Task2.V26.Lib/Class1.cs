using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AngeliA.Sprint6.Task2.V26.Lib
{
    public class Class1 : ISprint6Task2V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            // Вычисляем длину массива
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                // Формула: F(x) = sin(x) + (cos(2x) / 2) - 1.5x
                // Деления на ноль здесь быть не может, так как в знаменателе константа 2.

                double y = Math.Sin(x) + (Math.Cos(2 * x) / 2) - (1.5 * x);

                // Округление до двух знаков после запятой (по условию задачи)
                valueArray[count] = Math.Round(y, 2);
                count++;
            }

            return valueArray;
        }
    }
}
