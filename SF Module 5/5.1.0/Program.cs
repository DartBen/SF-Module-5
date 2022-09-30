using static System.Console;

internal class Program
{

    static string GetDataFromConsole() => Console.ReadLine();
    static string ShowColor()
    {
        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
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

    public static void Main(string[] args)
    {

         
        (string name, int age) User;


        //Console.WriteLine("Мое имя: {0}", name);
        //Console.WriteLine("Мой возраст: {0}", age);

        Console.Write("Введите имя: ");
        User.name = Console.ReadLine();
        Console.Write("Введите возраст с цифрами:");
        User.age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: {0}", User.name);
        Console.WriteLine("Ваш возраст: {0}", User.age);

        string[] favoriteColors = new string[3];


        for (int i = 0; i < favoriteColors.Length; i++)
        {
            favoriteColors[i] = ShowColor();
        }

        foreach (string color in favoriteColors)
        {
            WriteLine(color);
        }






    }
}
