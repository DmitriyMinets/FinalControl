using System.Text;

namespace Ex_1;

public static class MyExtension
{
    private static readonly StringBuilder sb = new();

    private static readonly Dictionary<char, string> dictionary = new()
    {
        { '1', "один" },
        { '2', "два" },
        { '3', "три" },
        { '4', "четыре" },
        { '5', "пять" },
        { '6', "шесть" },
        { '7', "семь" },
        { '8', "восемь" },
        { '9', "девять" },
        { '0', "ноль" }
    };

    public static string CreateString(this int numbers)
    {
        var stringNumber = numbers.ToString();

        foreach (var item in stringNumber)
        {
            foreach (var key in dictionary)
            {
                if (item == key.Key)
                    sb.Append(key.Value + " ");
            }
        }
        return sb.ToString();
    }
}