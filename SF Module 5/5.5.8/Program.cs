using System.Drawing;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {

        //Console.WriteLine("Напишите что-то");
        //var str = Console.ReadLine();
        ////var str = "пиздец грянул";

        //Console.WriteLine("Укажите глубину эха");
        //var deep = int.Parse(Console.ReadLine());

        //Echo(str, deep);

        //Console.ReadKey();

        //var i = Factorial(20);
        //Console.WriteLine(i);

        for (int i = 0; i <= 10; i++)
        {
            var tmpByte = (byte)i;
            var result = PowerUp(2, tmpByte);
            WriteLine($"Степень {i}: "+result);
        }

    }

    static int[] GetArrayFromConsole(ref int num)
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

    static void SortArray(in int[] arrIn, out int[] arrAsc, out int[] arrDesc)
    {
        arrAsc = new int[arrIn.Length];
        arrDesc = new int[arrIn.Length];

        SortArrayDesc(arrIn, out arrDesc);
        SortArrayAsc(arrIn, out arrAsc);
    }

    /// <summary>
    /// Сортировка по уменьшению
    /// </summary>
    /// <param name="arrIn"></param>
    /// <param name="arrResult"></param>
    static void SortArrayDesc(in int[] arrIn, out int[] arrResult)
    {
        int temp;
        int[] arrTmp = new int[arrIn.Length];
        Array.Copy(arrIn, arrTmp, arrIn.Length);

        for (int y = 0; y < arrTmp.Length - 1; y++)
        {
            for (int i = 0; i < arrTmp.Length - 1; i++)
            {

                if (arrTmp[i] < arrTmp[i + 1])
                {
                    temp = arrTmp[i];
                    arrTmp[i] = arrTmp[i + 1];
                    arrTmp[i + 1] = temp;
                };
            }
        }
        arrResult = arrTmp;
    }

    /// <summary>
    /// Сортировка во возрастанию
    /// </summary>
    /// <param name="arrIn"></param>
    /// <param name="arrResult"></param>
    static void SortArrayAsc(in int[] arrIn, out int[] arrResult)
    {
        int temp;
        int[] arrTmp = new int[arrIn.Length];
        Array.Copy(arrIn, arrTmp, arrIn.Length);

        for (int y = 0; y < arrTmp.Length - 1; y++)
        {
            for (int i = 0; i < arrTmp.Length - 1; i++)
            {

                if (arrTmp[i] > arrTmp[i + 1])
                {
                    temp = arrTmp[i];
                    arrTmp[i] = arrTmp[i + 1];
                    arrTmp[i + 1] = temp;
                };
            }
        }
        arrResult = arrTmp;
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

    static void ShowArray(int[] arr, bool needsort = false)
    {
        int[] tempArr = new int[arr.Length];

        Array.Copy(arr, tempArr, arr.Length);

        if (needsort)
        {
            tempArr = CustomSort(tempArr);
        }

        Write("Сортированный массив методом ShowArray:");
        foreach (var a in tempArr)
        {
            Write(" " + a + " ");
        }
        WriteLine();

    }

    static void ChangeAge(ref int age)
    {
        WriteLine("Изменение возраста в кортеже:");
        age = Int32.Parse(ReadLine());
    }

    static int SumNumbers(ref int num1, in int num2, out int num3, int num4)
    {
        int result = 0;


        num3 = 0;
        return result;
    }

    static void Echo(string saidworld, int deep)
    {
        var modif = saidworld;
        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);
        }
        ConsoleColor color = (ConsoleColor)deep;

        Console.BackgroundColor = color;
        Console.WriteLine("..." + modif);

        if (deep > 1)
        {
            Echo(modif, deep - 1);
        }
    }

    static decimal Factorial(int x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }

    private static int PowerUp(int N, byte pow)
    {
        int result = N;


        if (pow == 0)
        {
            return 1;
        }
        else if (pow == 1)
        {
            return N;
        }
        else if (pow > 1)
        {
            var tmp = PowerUp(N, (byte)(--pow)) * N;
            result = tmp;
        }
        return result;

    }

}