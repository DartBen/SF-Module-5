internal class Program
{
    private static void Main(string[] args)
    {
        var arr = GetArrayFromConsole();

        Console.Write("Сортированный массив:");
        foreach(var item in arr)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }

    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(result);


        return result;
    }
}