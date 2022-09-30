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

//        Array.Sort(result);
        result=CustomSort(result);

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


}