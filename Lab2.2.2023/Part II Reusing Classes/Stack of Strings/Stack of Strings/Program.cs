
using static Stack_of_Strings.CustomStack;

public class StartUp
{
    static void Main(string[] args)
    {
        StackOfStrings stack = new StackOfStrings();
        stack.Push("Hello");
        stack.Push("World");
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.IsEmpty());
    }
}