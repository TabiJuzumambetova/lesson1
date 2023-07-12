using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
       public static void task1()
        {
            Console.WriteLine("Enter first number : ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            if (firstNum % secondNum == 0)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);

            }
            Console.ReadLine();
        }
        public static void task2()
        {
            Console.WriteLine("Enter grade for Jake : ");
            int jakeGrade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter grade for John: ");
            int johnGrade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter grade for Jack : ");
            int jackGrade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter grade for Jane: ");
            int janeGrade = Convert.ToInt32(Console.ReadLine());
            double middleGrade = (jakeGrade + johnGrade + jackGrade + janeGrade) / 4;
            Console.WriteLine("Mean for grades : " + Math.Ceiling(middleGrade));

        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Выбери задание: ");
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:task1(); break;
                    case 2:task2(); break;

                }
            }
        }
    }

}
