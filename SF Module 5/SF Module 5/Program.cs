internal class Program
{
    private static void Main(string[] args)
    {

        (string Name, string[] Dishes) User = (Name: "",Dishes: new string[3] {"1","2","3"});

        User.Name = "";
        User.Dishes[1] = ("Tom");
        User.Dishes[2] = ("2");

    }
}