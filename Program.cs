using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fibs_set;

namespace lab1_QualityPA
{
    class Program
    {
        
       
        static void Main(string[] args)
        {
           while(true)
            { 
                Console.Clear();
                Console.WriteLine("\t|--\t Главное Меню \t  --|");
                Console.WriteLine("1 - Сгенерировать числа Фибоначчи в диапазоне\n2 - Сгенерировать числа Фибоначчи в интервале\n3 - Найти сумму чисел, результат которых равен числу Фибоначчи\n4 - Выход");
                Console.Write("Выберите действие: ");
                switch (Int32.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("\t|--\t Сгенерировать числа Фибоначчи в диапазоне \t  --|");
                            Console.Write("Введите кол-во чисел: ");
                            FibsSet.ShowGeneratedFibs(FibsSet.generateInRange(Int32.Parse(Console.ReadLine())));
                            Console.WriteLine("\nНажмите любую кнопку для продолжения");
                            Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("\t|--\t Сгенерировать числа Фибоначчи в интервале \t  --|");
                            Console.Write("Введите начальное число: ");
                            int min = Int32.Parse(Console.ReadLine());
                            Console.Write("Введите кол-во чисел: ");
                            int amount = Int32.Parse(Console.ReadLine());
                            FibsSet.ShowGeneratedFibs(FibsSet.generateInInterval(min, amount));
                            Console.WriteLine("\nНажмите любую кнопку для продолжения");
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("\t|--\t Найти сумму чисел, результат которых равен числу Фибоначчи \t  --|");
                            Console.Write("Введите число Фибоначчи: ");
                            FibsSet.ShowGeneratedFibs(FibsSet.findATwoNumbers(Int32.Parse(Console.ReadLine())));
                            Console.WriteLine("\nНажмите любую кнопку для продолжения");
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Выход успешен. Нажмите любую кнопку");
                            Console.ReadLine();
                            return;
                        }
                }
            }
        }
    }
}
