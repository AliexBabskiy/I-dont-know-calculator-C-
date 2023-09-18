using System;

class Calculator // системное, на этом уровне нечего не ставить
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать. Нажмите на Enter клавишу для запуска калькулятора.\n"); // \n нужен для переносов строк, ктолько \n столько строк пропустится
        Console.ReadKey();   // функция ожидания ввода единичного символа

        int choice;
        int num1, num2;
        double result;

        Console.WriteLine("Список действий:");
        Console.WriteLine("1. Сложить 2 числа");
        Console.WriteLine("2. Вычесть первое из второго");
        Console.WriteLine("3. Перемножить два числа");
        Console.WriteLine("4. Разделить первое на второе");
        Console.WriteLine("5. Возвести в степень N первое число");
        Console.WriteLine("6. Найти квадратный корень из числа");        //фн6
        Console.WriteLine("7. Найти 1 процент от числа");                //фн7
        Console.WriteLine("8. Найти факториал из числа");                //фн8
        Console.WriteLine("9. Выйти из программы");                      //фн9 

        do
        {
            Console.WriteLine("Выберите действие:");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:  // первая функция
                    Console.WriteLine("Действие: сложение двух чисел");  
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    result = num1 + num2;
                    Console.WriteLine("Сумма равна: " + result);
                    break;

                case 2:     // вторая функция
                    Console.WriteLine("Действие: вычесть первое число из второго");
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    result = num1 - num2;
                    Console.WriteLine("Результат равен: " + result);
                    break;

                case 3:    // функция 3
                    Console.WriteLine("Действие: перемножить два числа");
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    result = num1 * num2;
                    Console.WriteLine("Произведение равно: " + result);
                    break;

                case 4:   // функция 4 зачем я это описываю я же и так если что вспомню
                    Console.WriteLine("Действие: Разделить первое на второе");
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    if (num2 != 0)
                    {
                        result = (double)num1 / num2;
                        Console.WriteLine("Результат равен: " + result);
                    }
                    else
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                    }
                    break;

                case 5:    // функц.5
                    Console.WriteLine("Действие: возвести в степень N первое число");
                    Console.Write("Введите число: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите степень: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    result = Math.Pow(num1, num2);
                    Console.WriteLine("Результат равен: " + result);
                    break;

                case 6:   //фн6
                    Console.WriteLine("Действие: найти квадратный корень из числа");
                    Console.Write("Введите число: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    result = Math.Sqrt(num1);
                    Console.WriteLine("Квадратный корень: " + result);
                    break;

                case 7:  //фн7
                    Console.WriteLine("Действие: найти 1 процент от числа");
                    Console.Write("Введите число: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    result = num1 * 0.01;
                    Console.WriteLine("1% от числа равен: " + result);
                    break;

                case 8:  //фн8
                    Console.WriteLine("Действие: найти факториал из числа");
                    Console.Write("Введите число: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    result = Factorial(num1);
                    Console.WriteLine("Факториал равен: " + result);
                    break;

                case 9:   //фн9 несёт в себе только визуальные функции
                    Console.WriteLine("Завершение работы.");
                    break;

                default:
                    Console.WriteLine("Данная функция отсутствует или введены некорректные значения. Попробуйте еще раз.");
                    break;
            }
            Console.WriteLine();
        }
        while (choice != 9);
        
        Console.ReadKey();  // такая же функция как в начале, только тут она даёт возможность завершить программу с не сразу поэтому видно экран завершение работы
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