using static Random_List.CustomRandomList;

public class StartUp
{
    static void Main(string[] args)
    {
        RandomList list = new RandomList();
        list.Add("item1");
        list.Add("item2");
        list.Add("item3");

        Console.WriteLine("Random item: " + list.RandomString());
        Console.WriteLine("Random item: " + list.RandomString());
    }
}