namespace Ex_2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите значение от 0 до 20");
        int result;
        int.TryParse(Console.ReadLine(), out result);
        Console.WriteLine(MathOperation.Factorial(result));
    }
}