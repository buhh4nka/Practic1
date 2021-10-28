using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lib_2;

namespace Practic1
{
    /// <summary>
    /// ИСП-31. Назаров Д. Вариант 2.
    /// Вычислить сумму целых случайных чисел, распределенных в диапазоне от 2 до 10, 
    /// пока эта сумма не превышает некоторого числа K.Вывести на экран
    /// сгенерированные числа, значение суммы, и количество сгенерированных чисел.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startProgramm_Click(object sender, RoutedEventArgs e)
        {
            
            
            
            bool isNotError = Int32.TryParse(enterMinSumOfNumbers.Text, out int minSumOfNumbers);
            if (isNotError && minSumOfNumbers < 0)
            {
                string allNumbers = string.Empty;
                int counter;
                int sumNum;

                minSumOfNumbers = Convert.ToInt32(enterMinSumOfNumbers.Text);

                Practice.randomNumber(minSumOfNumbers, out counter, out sumNum, out allNumbers);

                allRandomNumbers.Text = allNumbers;
                numberCounter.Text = counter.ToString();
                endSumOfNumbers.Text = sumNum.ToString();
            }
            else
            {
                MessageBox.Show("Число введено неверное или оно не отрицательное. \nВведите другое значение.", "Ошибка");
                enterMinSumOfNumbers.Clear();
            }

        }
        private void help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-31. Назаров Д. Вариант 2. \nВычислить сумму целых случайных чисел, распределенных в диапазоне от 2 до 10, \nпока эта сумма не превышает некоторого числа K.Вывести на экран \nсгенерированные числа, значение суммы, и количество сгенерированных чисел." , "Данные о программе");
        }
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void enterMinSumOfNumbers_TextChanged(object sender, TextChangedEventArgs e)
        {
            allRandomNumbers.Clear();
            endSumOfNumbers.Clear();
            numberCounter.Clear();
        }

    }
}
