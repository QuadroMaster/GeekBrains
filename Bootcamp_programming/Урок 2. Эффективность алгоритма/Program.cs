﻿// Записей по буткемпам в тетради/на листах не будет, все записи здесь, в коде!
/*
Виды алгоритмов:
1. Константные O(1) - O(2).
2. Логарифмические - бинарный поиск
3. Линейные O(n), O(2 * n)...
4. Линейно-логарифмические - быстрая сортировка
5. Квадратные - пузырьковая сортировка, сортировка выбором, сортировка вставками
6. Кубические - трёхмерные массивы
*/
// Напишите программу, которая считает сумму чисел от 1 до n.
//null - пустая ячейка в БД (цитата пеподавателя)
//Console.Clear(); //ВАЖНО!!! ОЧИСТИТЬ ВСЁ В КОНСОЛИ, ЧТО БЫЛО ДО ЗАПУСКА ЭТОЙ ПРОГРАММЫ
//Console.Write("Введите число: ");
//int n = int.Parse(Console.ReadLine()!), result = 0; // ! говорит о том, что не переживай, мы НЕ будем вводить пустую строку. 
//["345"] <- 345 int.Parse берёт ячейку ["345"], создаёт число 345 и записывает в ЭТУ ЖЕ ЯЧЕЙКУ!

//int n = Convert.ToInt32(Console.ReadLine());

//Convert.ToInt32 берёт ячейку ["345"], создаёт число 345 и записывает в ДРУГУЮ ЯЧЕЙКУ!!! 
//ПОЭТОМУ Convert.ToInt32 работает ДОЛЬШЕ, чем int.Parse

//for(int i = 1; i <= n; i++) //O(n) линейный алгоритм, линейная сложность
//    result += i;

//Console.WriteLine($"Сумма чисел от 1 до {n} равна {result}");


// Арифметическая прогрессия: Sn = (Ao + An)/2 * n
// Арифметическая прогрессия для 1 2 3 4 5... n: Sn = (1 + n)/2 * n
//Console.Clear(); 
//Console.Write("Введите число: ");
//int n = int.Parse(Console.ReadLine()!);
//Console.WriteLine($"Сумма чисел от 1 до {n} равна {(1+n) / 2 * n}");


//Бинарный поиск, сложность бинарного поиска равна O(log2(n)), это 2-й тип алгоритма
// log2(1000) ~ 10

// [34, 1, 2, -10, 56, 314, 13, 1, 2, 4, 90, -123, 32, 54, 652], n- количество элементов массива
// O(n * log2(n)) + O(log2(n))

// Быстрая сортировка O(n * log2(n)) (Рекурсивный подход)

// [34, -10, 23, 5, 2, 1]
// 1. Выбирается опорный элемент (в основном берётся первый элемент массива)
// 2. Создаётся 2 массива. 1-ый массив содержит элементы меньше опорного,
// 2-ой массив содержит элементы больше или равные опорному.

// Опорный элемент равен 34 (отсортиров. [-10, 1, 2, 5, 23, 34])
// [-10, 23, 5, 2, 1] + [34] +[]
// Опорный элемент -10  (отсортиров. [-10, 1, 2, 5, 23])
// [] + [-10] + [23, 5, 2, 1]
// Опорный элемент 23 (отсортиров. [1, 2, 5, 23])
// [5, 2, 1] + [23] + []
// Опорный элемент 5 (отсортиров. [1, 2, 5])
// [2,1] + [5] + []
//Опорный элемент 2
// [1] + [2] + []