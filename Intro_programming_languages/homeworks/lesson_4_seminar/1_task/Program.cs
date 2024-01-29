// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

//using System.Globalization;


string inputText;
while(true) {
    Console.Write("Введите целое число: ");
    inputText = Console.ReadLine()!;
    if (inputText == "q")
        {
            Console.Write("Выход из цикла");
            return;
        }
    //number = Convert.ToInt32(inputText);
    int sum = 0;
    foreach (char i in inputText)
        {   
            sum += Convert.ToInt32(i);
        }
    if (sum % 2 == 0)
    {   
        Console.WriteLine(sum % 2);
        Console.Write("Введено число, сумма цифр которого чётная, выход из цикла");
        return;
    }
    
}