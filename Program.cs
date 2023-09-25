using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать. Нажмите на Enter клавишу для запуска калькулятора.\n");
        Console.ReadKey();

        object choice;
        object num1, num2;
        double result;

        Console.WriteLine("Список действий:");
        Console.WriteLine("1. Сложить 2 числа");
        Console.WriteLine("2. Вычесть первое из второго");
        Console.WriteLine("3. Перемножить два числа");
        Console.WriteLine("4. Разделить первое на второе");
        Console.WriteLine("5. Возвести в степень N первое число");
        Console.WriteLine("6. Найти квадратный корень из числа");
        Console.WriteLine("7. Найти 1 процент от числа");
        Console.WriteLine("8. Найти факториал из числа");
        Console.WriteLine("9. Выйти из программы");

        do
        {

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                string singl = Console.ReadLine();
                if (int.TryParse(singl, out int number))
                {
                    choice = number;
                    break;
                }

                else
                {
                    Console.WriteLine("Введены некорректные значения. Попробуйте еще раз. \n");
                }
            }

            switch (choice)
            {
                case 1:  
                    Console.WriteLine("Действие: сложение двух чисел ");
                    while (true)
                    {
                        Console.Write("Введите первое число: ");
                        string singl = Console.ReadLine();
                        if (int.TryParse(singl, out int number))
                        {
                            num1 = number;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ошибка ввода. ");
                        }
                    }

                    while (true)
                    {
                        Console.Write("Введите второе число: ");
                        string singl = Console.ReadLine();
                        if (int.TryParse(singl, out int number))
                        {
                            num2 = number;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ошибка ввода. ");
                        }
                    }

                    result = Convert.ToInt32(num1) + Convert.ToInt32(num2);
                    Console.WriteLine("Сумма равна: " + result);
                    break;

                case 2:     
                    Console.WriteLine("Действие: вычесть первое число из второго ");
                    while (true)
                    {
                        Console.Write("Введите первое число: ");
                        string singl = Console.ReadLine();
                        if (int.TryParse(singl, out int number))
                        {
                            num1 = number;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ошибка ввода. ");
                        }
                    }

                    while (true)
                    {
                        Console.Write("Введите второе число: ");
                        string singl = Console.ReadLine();
                        if (int.TryParse(singl, out int number))
                        {
                            num2 = number;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ошибка ввода. ");
                        }
                    }
                    result = Convert.ToInt32(num1) - Convert.ToInt32(num2);
                    Console.WriteLine("Результат равен: " + result);
                    break;

                case 3:    
                    Console.WriteLine("Действие: перемножить два числа ");
                    while (true)
                    {
                        Console.Write("Введите первое число: ");
                        string singl = Console.ReadLine();
                        if (int.TryParse(singl, out int number))
                        {
                            num1 = number;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ошибка ввода. ");
                        }
                    }

                    while (true)
                    {
                        Console.Write("Введите второе число: ");
                        string singl = Console.ReadLine();
                        if (int.TryParse(singl, out int number))
                        {
                            num2 = number;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ошибка ввода. ");
                        }
                    }
                    result = Convert.ToInt32(num1) * Convert.ToInt32(num2);
                    Console.WriteLine("Произведение равно: " + result);
                    break;

                case 4:   
                    Console.WriteLine("Действие: Разделить первое на второе ");
                    while (true)
                    {
                        Console.Write("Введите первое число: ");
                        string singl = Console.ReadLine();
                        if (int.TryParse(singl, out int number))
                        {
                            num1 = number;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ошибка ввода. ");
                        }
                    }
                    
                    while (true)
                    {
                        Console.Write("Введите второе число: ");
                        string singl = Console.ReadLine();
                        if (int.TryParse(singl, out int number))
                        {
                            num2 = number;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ошибка ввода. ");
                        }
                    }

                    if (Convert.ToInt32(num2) != 0)
                    {
                        result = (double)Convert.ToInt32(num1) / Convert.ToInt32(num2);
                        Console.WriteLine("Результат равен: " + result);
                    }
                    else
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                    }
                    break;

                case 5:   
                    Console.WriteLine("Действие: возвести в степень N первое число ");
                    while (true)
                    {
                        Console.Write("Введите первое число: ");
                        string singl = Console.ReadLine();
                        if (int.TryParse(singl, out int number))
                        {
                            num1 = number;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ошибка ввода. ");
                        }
                    }

                    while (true)
                    {
                        Console.Write("Введите степень: ");
                        string singl = Console.ReadLine();
                        if (int.TryParse(singl, out int number))
                        {
                            num2 = number;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ошибка ввода. ");
                        }
                    }
                    result = Math.Pow(Convert.ToInt32(num1), Convert.ToInt32(num2));
                    Console.WriteLine("Результат равен: " + result);
                    break;

                case 6: 
                    Console.WriteLine("Действие: найти квадратный корень из числа ");
                    while (true)
                    {
                        Console.Write("Введите число: ");
                        string singl = Console.ReadLine();
                        if (int.TryParse(singl, out int number))
                        {
                            num1 = number;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ошибка ввода. ");
                        }
                    }
                    result = Math.Sqrt(Convert.ToInt32(num1));
                    Console.WriteLine("Квадратный корень: " + result);
                    break;

                case 7: 
                    Console.WriteLine("Действие: найти 1 процент от числа ");
                    while (true)
                    {
                        Console.Write("Введите число: ");
                        string singl = Console.ReadLine();
                        if (int.TryParse(singl, out int number))
                        {
                            num1 = number;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ошибка ввода. ");
                        }
                    }
                    result = Convert.ToInt32(num1) * 0.01;
                    Console.WriteLine("1% от числа равен: " + result);
                    break;

                case 8: 
                    Console.WriteLine("Действие: найти факториал из числа ");
                    while (true)
                    {
                        Console.Write("Введите п число: ");
                        string singl = Console.ReadLine();
                        if (int.TryParse(singl, out int number))
                        {
                            num1 = number;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Ошибка ввода. ");
                        }
                    }
                    result = Factorial(Convert.ToInt32(num1));
                    Console.WriteLine("Факториал равен: " + result);
                    break;

                case 9:   
                    Console.WriteLine("Завершение работы.");
                    return;
                default:
                    Console.WriteLine("Данная функция отсутствует. Попробуйте еще раз. \n");
                    break;
            }
        }
        while (Convert.ToInt32(choice) != 9);
    }

    static double Factorial(int number)
    {
        double result = 1;

        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }

        return result;
    } 
}