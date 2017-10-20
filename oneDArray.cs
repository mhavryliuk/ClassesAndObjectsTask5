using System;

/*
Классы и Объекты.
Задание 5. Создать класс для работы с одномерным массивом целых чисел.
Разработать следующие члены класса:
1. Поля:
· int[] IntArray;
2. Конструктор, позволяющий создать массив размерности n.
3. Методы, позволяющие:
· ввести элементы массива с клавиатуры;
· вывести элементы массива на экран;
· отсортировать элементы массива в порядке возрастания.
4. Свойство:
· возвращающее размерность массива (доступное только для чтения);
· позволяющее домножить все элементы массива на скаляр(доступное только для записи).
5. Индексатор, позволяющий по индексу обращаться к соответствующему элементу массива.
6. Перегрузку:
· операции ++ (--): одновременно увеличивает(уменьшает) значение всех элементов массива на 1;
· операции !: возвращает значение true, если элементы массива не упорядочены по возрастанию, иначе false;
· операции бинарный *: домножить все элементы массива на скаляр;
· операции преобразования класса массив в одномерный массив(и наоборот).

Продемонстрировать работу класса.
*/

namespace ClassesAndObjectsTask5
{
    class OneDArray
    {
        // Поля
        int[] IntArray;
        int size = 0;

        // Конструктор, позволяющий создать массив размерности n.
        public OneDArray(int size)
        {
            this.size = size;
            IntArray = new int[size];
        }

        // Метод, позволяющий ввести элементы массива с клавиатуры.
        public void InputIntArray()
        {
            Console.WriteLine("Введите элименты массива: ");
            for (int i = 0; i < IntArray.Length; i++)
            {
                Console.Write("A[{0}] = ", i);
                IntArray[i] = int.Parse(Console.ReadLine());
            }
        }

        // Метод, позволяющий вывести элементы массива на экран.
        public void ShowIntArray()
        {
            foreach (int item in IntArray)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        // Метод, позволяющий отсортировать элементы массива в порядке возрастания.
        public void SortingArray() => Array.Sort(IntArray);

        // Свойство возвращающее размерность массива (доступное только для чтения).
        public string Length => $"\nРазмерность массива составляет {IntArray.Length} элемента.";

        // Свойство позволяющее домножить все элементы массива на скаляр (доступное только для записи).
        public int Scalar
        {
            set
            {
                for (int i = 0; i < IntArray.Length; i++)
                {
                    IntArray[i] *= value;
                }
            }
        }

        // Индексатор, позволяющий по индексу обращаться к соответствующему элементу массива.
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < IntArray.Length)
                {
                    return $"Индексу [{index}] соответствует элемент {IntArray[index]}.";
                }
                else
                {
                    return $"Индекс [{index}] является недопустимым.";
                }
            }
        }

        // Перегрузка операции ++: одновременно увеличивает значение всех элементов массива на 1.
        public static OneDArray operator ++(OneDArray increment)
        {
            OneDArray array = new OneDArray(increment.IntArray.Length);
            for (int i = 0; i < increment.IntArray.Length; i++)
            {
                increment.IntArray[i] += 1;
            }
            return increment;
        }

        // Перегрузка операции --: одновременно уменьшает значение всех элементов массива на 1.
        public static OneDArray operator --(OneDArray decrement)
        {
            OneDArray array = new OneDArray(decrement.IntArray.Length);
            for (int i = 0; i < decrement.IntArray.Length; i++)
            {
                decrement.IntArray[i] -= 1;
            }
            return decrement;
        }

        // Перегрузка операции !: возвращает значение true, если элементы массива не упорядочены по возрастанию, иначе false.
        public static bool operator !(OneDArray array)
        {
            bool sort = false;
            for (int i = 0; i < array.IntArray.Length - 1; i++)
                if (array.IntArray[i] > array.IntArray[i + 1])
                {
                    sort = true;
                }
            return sort;
        }

        // Перегрузка операции бинарный *: домножить все элементы массива на скаляр.
        public static OneDArray operator *(OneDArray multiplication, int scalar)
        {
            OneDArray array = new OneDArray(multiplication.IntArray.Length);
            for (int i = 0; i < multiplication.IntArray.Length; i++)
            {
                multiplication.IntArray[i] *= scalar;
            }
            return multiplication;
        }

        // Перегрузка операции преобразования класса массив в одномерный массив(и наоборот).
        public static explicit operator OneDArray (int[] array)
        {
            OneDArray transformation = new OneDArray(array.Length);
            array.CopyTo(transformation.IntArray, 0);
            return transformation;
        }

        public static explicit operator int[] (OneDArray transformation)
        {
            return transformation.IntArray;
        }
    }
}
