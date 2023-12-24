static void Main(String[] args)
{
    int[] numbers = { 1, 3, 4, 9, 2 ,4, 2, 3, 5, 6};
    Console.WriteLine("Исходный массив: " + string.Join(", ", DeleteThreeMinElements(numbers)));
}
static int[] DeleteThreeMinElements(int[] numbers)
{
    for (int i = 1; i <= 3; i++)
    {
        int numToRemove = numbers.Min();
        numbers = numbers.Where(val => val != numToRemove).ToArray();
    }
    return numbers;
}