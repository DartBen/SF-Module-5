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


        //User.FavoriteColors = new string[3];

        //Console.WriteLine("Введите три любимых цвета пользователя");
        //for (int i = 0; i < User.FavoriteColors.Length; i++)
        //{
        //    User.FavoriteColors[i] = ShowColor(User.name, User.age);
        //}

        //WriteLine("Ваши любимые цвета:");
        //foreach (var color in User.FavoriteColors)
        //{
        //    WriteLine(color);
        //}


        var arr = GetArrayFromConsole();
        var sortedarray=CustomSort(arr);

        Console.Write("Сортированный массив:");
        foreach (var item in sortedarray)
        {
            Console.Write(item);
        }
        Console.WriteLine();


    }

    //static int[] GetArrayFromConsole()
    //{
    //    var result = new int[5];

    //    for (int i = 0; i < result.Length; i++)
    //    {
    //        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
    //        result[i] = int.Parse(Console.ReadLine());
    //    }

    //    //        Array.Sort(result);
    //    result = CustomSort(result);

    //    return result;
    //}

    static int[] GetArrayFromConsole(int num = 5)
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        //        Array.Sort(result);
        //        result = CustomSort(result);

        return result;
    }

    static int[] CustomSort(int[] arr)
    {
        int[] result = new int[arr.Length];
        Array.Copy(arr, result, arr.Length);

        int temp;

        for (int y = 0; y < result.Length - 1; y++)
        {
            for (int i = 0; i < result.Length - 1; i++)
            {

                if (result[i] > result[i + 1])
                {
                    temp = result[i];
                    result[i] = result[i + 1];
                    result[i + 1] = temp;
                };
            }
        }
        return result;
    }

    static string GetDataFromConsole() => Console.ReadLine();
    static string ShowColor(string name, int age)
    {
        Console.WriteLine("{0},{1} \nНапишите свой любимый цвет на английском с маленькой буквы", name, age);
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

    static void SortComplexArray(int[,] arr)
    {
        int temp;
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
                for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                    if (arr[i, j] > arr[i, k])
                    {
                        temp = arr[i, k];
                        arr[i, k] = arr[i, j];
                        arr[i, j] = temp;
                    }
        }
    }
}