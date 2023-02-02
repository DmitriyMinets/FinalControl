namespace Ex_2;

public static class MathOperation
{
    public static int? Factorial(int n)
    {
        if (n < 0)
        {
            Console.WriteLine("Введены некорректные данные");
            return null;
        }

        if (n == 0) return 1;

        try
        {
            checked
            {
                return n * Factorial(n - 1);
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return null;
    }
}