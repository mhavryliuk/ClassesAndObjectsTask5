using System;

namespace ClassesAndObjectsTask5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Задайте размер массива: ");
            int size = int.Parse(Console.ReadLine());

            OneDArray array = new OneDArray(size);   // Инициализация одномерного массива
            array.InputIntArray();                   // Ввод элементов массива с клавиатуры
            Console.WriteLine("\nИсходный массив:");
            array.ShowIntArray();                    // Вывод на экран исходных элементов массива

            array.SortingArray();                    // Сортировка элементов массива в порядке возростания
            Console.WriteLine("\nОтсортированный в порядке возростания массив:");
            array.ShowIntArray();                    // Вывод на экран отсортированных элементов массива

            Console.WriteLine(array.Length);         // Информация о размерности массива
            Console.WriteLine("\nМассив, элементы которого умножены на скаляр (3):");
            array.Scalar = 3;
            array.ShowIntArray();                    // Элементы массива умноженные на скаляр
            
            Console.WriteLine("\nОбращение к элементам массива по индексу:");
            Console.WriteLine(array[-1]);            // Обращение к элементам массива по индексу
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[10]);

            Console.WriteLine("\nДемонстрация перегрузки операций");
            ++array;                                 // Перегрузка операции ++
            array.ShowIntArray();
            --array;                                 // Перегрузка операции --
            array.ShowIntArray();


            Console.ReadKey();
        }
    }
}
