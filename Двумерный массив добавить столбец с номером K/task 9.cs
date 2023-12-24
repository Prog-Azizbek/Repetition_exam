//Написать функцию, которая добавляет в двумерный массив столбец с номером К.
//Предусмотреть, что К может быть больше, чем количество столбцов в массиве или меньше 0.


internal class Program
{
    // Функция, которая добавляет в двумерный массив столбец с номером K
    static void AddColumn(int[,] array, int K, int[] column)
    {
        // Проверяем, что K не меньше 0 и не больше количества столбцов в массиве
        if (K < 0 || K > array.GetLength(1)) // здесь K может быть равно 3 так как в массиве 0-2 индексы 3 столбик будет новым
        {
            Console.WriteLine("Неверное значение K");
            return;
        }

        // Проверяем, что длина нового столбца равна количеству строк в массиве
        if (column.Length != array.GetLength(0))
        {
            Console.WriteLine("Неверная длина нового столбца");
            return;
        }

        // Создаем новый массив, увеличивая количество столбцов на 1
        int[,] newArray = new int[array.GetLength(0), array.GetLength(1) + 1];

        // Копируем элементы из старого массива в новый, вставляя новый столбец на место K
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                if (j < K)
                {
                    // Копируем элементы до K
                    newArray[i, j] = array[i, j];
                }
                else if (j == K)
                {
                    // Вставляем новый столбец
                    newArray[i, j] = column[i];
                }
                else
                {
                    // Копируем элементы после K
                    newArray[i, j] = array[i, j - 1];
                }
            }
        }

        // Выводим новый массив на экран
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                Console.Write(newArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        // Пример использования функции AddColumn

        // Исходный двумерный массив
        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        // Новый столбец, который хотим добавить
        int[] column = { 10, 11, 12 };

        // Номер столбца, куда хотим добавить новый столбец
        int K = 3;

        // Вызываем функцию AddColumn
        AddColumn(array, K, column);
    }
}