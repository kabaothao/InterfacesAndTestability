// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new orderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }
    }
}


/*
 
What is an interface?

An interface is a language construct that is similar to class in terms of syntax but it's fundamentally

different.

For example:

public interface ITaxCalculator
{

 int Calculate*();

}
 

So wherever you see a type that starts with I that represents an interface it's a convention but unlike

classes interfaces do not have implementation.


 */