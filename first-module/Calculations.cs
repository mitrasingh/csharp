using System;

class Program
{

    // YOUR CODE HERE: Define a method named Multiply. Remember
    // to use the "static" and "void" keywords: "static void
    // Multiply" (without quotes). Multiply should take two
    // "double" values as parameters.
    
    // static void Multiply (double num1, double num2)
    // {
    //     Console.WriteLine(num1 * num2);
    // }

    // static void Main(string[] args)
    // {
    //     // YOUR CODE HERE:
    //     // Call Multiply with two arguments: 2.5 and 2.
    //     Multiply(2.5, 2);
        
    //     // YOUR CODE HERE:
    //     // Call Multiply with two arguments: 6 and 7.
    //     Multiply(6, 7);
    // }

    static double Multiply (double num1, double num2)
  {
    return num1 * num2;
  }

  static void Main(string[] args)
  {
    double firstValue = Multiply(2.5, 2);
    double secondValue = Multiply(6,7);
    Console.WriteLine(firstValue + secondValue);
  }

}