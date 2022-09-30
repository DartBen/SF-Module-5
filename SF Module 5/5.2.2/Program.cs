using System.Drawing;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {

        (string name, int age, string[] FavoriteColors) User;

        WriteLine("Введите имя:");
        User.name = ReadLine();
        WriteLine("Введите возраст:");
        int.TryParse(ReadLine(), out User.age);


        User.FavoriteColors = new string[3];

        Console.WriteLine("Введите три любимых цвета пользователя");
        for (int i = 0; i < User.FavoriteColors.Length; i++)
        {
            User.FavoriteColors[i] = ShowColor(User.name);
        }

        WriteLine("Ваши любимые цвета:");
        foreach(var color in User.FavoriteColors)
        {
            WriteLine(color);
        }



    }

    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        //        Array.Sort(result);
        result = CustomSort(result);

        return result;
    }

    static int[] CustomSort(int[] arr)
    {
        int temp;

        for (int y = 0; y < arr.Length - 1; y++)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i] > arr[i + 1])
                {
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                };
            }
        }
        return arr;
    }

    static string GetDataFromConsole() => Console.ReadLine();
    static string ShowColor(string name)
    {
        Console.WriteLine("{0} Напишите свой любимый цвет на английском с маленькой буквы",name);
        var color = GetDataFromConsole();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }

        return color;
    }

}