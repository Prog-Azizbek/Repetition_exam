internal class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Podgotovka nachalas'");
        Console.WriteLine("Input Your Positive Real Number Please!");
        Console.WriteLine("You typed: " + InputPositiveRealNumber());
    }
    static double InputPositiveRealNumber()
    {
        var number = 0.0;
        string input = Console.ReadLine();
        bool isValid = double.TryParse(input, out number);
        
        if (isValid & number >= 0)
        {
            return number;
        }
        else
        {
            Console.WriteLine("Vi loh u vas mistake. type again");
            return InputPositiveRealNumber();
        }
    }
}