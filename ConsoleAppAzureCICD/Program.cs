// See https://aka.ms/new-console-template for more information

using ConsoleAppAzureCICD;
using System.ComponentModel;

class TestClass
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.Add(5,7));
        
    }


}

