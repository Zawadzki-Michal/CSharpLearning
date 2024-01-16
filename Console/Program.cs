using System;
class Program
{
  static void Main()
  {
    PrintToConsole();
    VariablesAndDataTypes();
    MathOperations();
  }
  static void PrintToConsole()
  {
    Console.WriteLine("Hello World!");
  }
  static void VariablesAndDataTypes()
  {
    int age = 35;
    Console.WriteLine(age);
    float temperature = 30.5f;
    Console.WriteLine(temperature);
    double interest = 5.53;
    Console.WriteLine("Interest: " + interest);

    decimal stockPrice = 123.4543434M;
    Console.WriteLine("Stock Price: " + stockPrice);

    char grade = 'A';
    Console.WriteLine("Grade: " + grade);

    string name = "John";
    Console.WriteLine($"My name is {name}.");

    bool isStudent = true;
    Console.WriteLine(isStudent);

    int quantity;
    string productName;
    quantity = 5;
    productName = "Bananas";
    Console.WriteLine($"I have {quantity} {productName}.");

    const double Pi = 3.14;
    Console.WriteLine(Pi);

  }
  static void MathOperations()
  {


  }

}