using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.Write("Введите целое число: ");
                int X = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Второе число: ");
                int Y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное");
                int Z = Convert.ToInt32(Console.ReadLine());
                if (Z > 4)
                {
                    Console.WriteLine("Нет операции с указанным номером");
                }
                if (Z<5)
                {
                    int result=0;              
                    switch (Z)
                    {
                            case 1:
                            {
                                result = X + Y;
                                Console.WriteLine("Ваш выбор: {0}", result);
                                break;
                            }
                            case 2:
                            {
                                result = X - Y;
                                Console.WriteLine("Ваш выбор: {0}", result);
                                break;
                            }
                            case 3:
                            {
                                result = X * Y;
                                Console.WriteLine("Ваш выбор: {0}", result);
                                break;
                            }
                            case 4:
                            {
                                result = X / Y;
                                Console.WriteLine("Ваш выбор: {0}", result);
                                break;
                            }                          

                    }
                                                 
                }
            }            
            catch (InvalidCastException)
            {
                Console.WriteLine("Ошибка! Входная строка имеет неверный формат");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}            
            

        
    

