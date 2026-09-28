class ShoppingCart
{
    static string Ask(string question)
  {
    Console.Write(question);
    return Console.ReadLine();
  }

  static double Price (int quantity)
  {
    double finalCost;
    if (quantity >= 100)
    {
      finalCost = quantity * 1.25;
    }
    else if (quantity >= 50)
    {
      finalCost = quantity * 1.50;
    }
    else
    {
      finalCost = quantity * 2;
    }
    return finalCost;
  }
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the cat food store!");
        string entry = Ask("How many cans of food do you need? ");
        int amountConvert = int.Parse(entry);
        double finalPrice = Price(amountConvert);
        Console.WriteLine($"For {entry} of can, your total cost will be ${finalPrice} dollars");
    }
}
