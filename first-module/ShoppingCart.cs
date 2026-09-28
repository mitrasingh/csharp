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
        int amountConvert = int.Parse(entry);
        Console.WriteLine($"For {entry} of can, your total cost will be ${amountConvert * 2} dollars");
    }
}
