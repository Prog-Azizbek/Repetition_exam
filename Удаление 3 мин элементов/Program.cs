static void Main(String[] args)
{
    int[] array = { 10, 5, 3, 7, 9, 2, 4, 3, 33, 6, 8, 1 };
    Console.WriteLine("Исходный массив: " + string.Join(", ", array));
    int[] newArray = RemoveSmallestElements(array);
    Console.WriteLine("Новый массив без " + 3 + " самых маленьких элементов: " + string.Join(", ", newArray));
}
static int[] RemoveSmallestElements(int[] array)
{
    return array.OrderBy(x => x).Skip(3).ToArray();
}