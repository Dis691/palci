using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            if (number > 0)
            {
                result = number % 10;

                //Console.Write(result);
            }

            if (number > 0)
            {
                number /= 10;

                int b = number % 10;

                // Console.Write(b);
            }

            void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }
            void checkFingers(int num) {
                switch (num)
                {
                    case 1:
                        PrintMessage("Большой палец");
                        break;

                    case 2:
                        PrintMessage("Указательный палец");
                        break;

                    case 3:
                        PrintMessage("Средний палец");
                        break;

                    case 4:
                        PrintMessage("Безымянный палец");
                        break;

                    case 5:
                        PrintMessage("Маленький палец");
                        break;


                }
            }
            checkFingers(number);
            checkFingers(result);
            









           

            Console.ReadKey();



        }
    }
}
