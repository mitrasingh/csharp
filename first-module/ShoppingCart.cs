class ShoppingCart
{
    static string Ask(string question)
  {
    Console.Write(question);
    return Console.ReadLine();
  }
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the cat food store!");
        string entry = Ask("How many cans of food do you need? ");
        Console.WriteLine(entry);
    }
}
