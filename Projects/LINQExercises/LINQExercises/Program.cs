using System;
using System.Linq;

namespace LINQExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex_three();
        }

        static void Ex_one()
        {
            //Дана целочисленная последовательность, содержащая как положительные, так и отрицательные числа. Вывести ее первый положительный элемент и последний отрицательный элемент.
            int[] sequence = {-1, 2, -4, 5, 7, 10, 45, 1, 3, 78, 43, 87, 45, 56 };

            var firtsPos = (from i in sequence 
                            where i > 0 
                            select i).FirstOrDefault();

            var lastNeg = (from i in sequence
                            where i < 0
                            select i).LastOrDefault();
            Console.WriteLine($"Fisrt positive: {(firtsPos == 0 ? "not found": firtsPos.ToString())}\nLast negative: {(lastNeg == 0 ? "not found" : lastNeg.ToString())}");
        }

        static void Ex_two()
        {
            //Дана цифра D (однозначное целое число) и целочисленная последовательность A. Вывести первый положительный элемент последовательности A, оканчивающийся
            //цифрой D. Если требуемых элементов в последовательности A нет, то вывести 0
            int[] sequence = { -1, 2, -4, 5, 7, 10, 45, 1, 2, 78, 43, 87, 45, 56 };
            int D = 3;

            var result = (from i in sequence
                            where i % 10 == D
                            select i).FirstOrDefault();

            Console.WriteLine($"Result: {result}");
        }


        static void Ex_three()
        {
            //Дан символ С и строковая последовательность A.
            //Если A содержит единственный элемент, оканчивающийся
            //символом C, то вывести этот элемент; если требуемых строк
            //в A нет, то вывести пустую строку; если требуемых строк
            //больше одной, то вывести строку «Error».
            //Указание.Использовать try-блок для перехвата возможного
            //исключения

            string[] sequence = {"Hello"};
            char C = 'o';

            string result = "";

            try
            {
                if (sequence.Length != 0 && sequence.Single<string>().Last() == C)
                {
                    result = sequence.Single<string>();
                }
            }
            catch (InvalidOperationException e)
            {
                result = "Error";
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
