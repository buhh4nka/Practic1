using System;

namespace Lib_2
{
    /// <summary>
    /// ИСП-31. Назаров Д. Вариант 2.
    /// Вычислить разницу целых случайных чисел, распределенных в диапазоне от 2 до 10,
    /// пока эта разница не станет меньше некоторого числа K(K<0). Вывести на экран
    /// сгенерированные числа, значение суммы, и количество сгенерированных чисел
    /// </summary>
    public class Practice
    {
        public static void randomNumber(int minNumber, out int counter,  out int sum, out string allNumbers)
        {
            Random randomNumber = new Random();
            sum = 0;
            counter = 0;
            
            allNumbers = string.Empty;

            do
            {
                int number = randomNumber.Next(2, 10);
                allNumbers += number.ToString() + ", ";
                sum -= number;
                counter++;
            }
            while (sum > minNumber);
        }
        
    }
}
