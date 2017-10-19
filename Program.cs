using System;

namespace ClassesAndObjectsTask5
{
    class Program
    {
        static void Main()
        {
            OneDArray array = new OneDArray(4);   // Задаем размер одномерного массива
            array.InputIntArray();                // Ввод элементов массива с клавиатуры
            Console.WriteLine("\nИсходный массив:");
            array.ShowIntArray();                 // Вывод на экран исходных элементов массива

            array.SortingArray();                 // Сортировка элементов массива в порядке возростания
            Console.WriteLine("\nОтсортированный в порядке возростания массив:");
            array.ShowIntArray();                 // Вывод на экран отсортированных элементов массива

            Console.ReadKey();
        }
    }
}
