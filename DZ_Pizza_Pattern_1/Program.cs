// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using DZ_Pizza_Pattern_1;

Pizza pizza_margarita = new Pizza(new Margarita());
Console.WriteLine($"\t{(nameof(pizza_margarita).ToUpper())}\n");
Console.WriteLine(pizza_margarita.ToString());
double price_margarita = pizza_margarita.CalculatePrice();
Console.WriteLine($"Price of {nameof(pizza_margarita)} = {String.Format("{0:0.00}",price_margarita)} Euro");
Console.WriteLine("----------------------------------");

Pizza pizza_pepperoni = new Pizza(new PepperoniP());
Console.WriteLine($"\t{(nameof(pizza_pepperoni).ToUpper())}\n");
Console.WriteLine(pizza_pepperoni.ToString());
double price_pepperoni = pizza_pepperoni.CalculatePrice();
Console.WriteLine($"Price of {nameof(pizza_pepperoni)} = {String.Format("{0:0.00}", price_pepperoni)} Euro");
Console.WriteLine("----------------------------------");

Pizza pizza_marinara = new Pizza(new Marinara());
Console.WriteLine($"\t{(nameof(pizza_marinara).ToUpper())}\n");
Console.WriteLine(pizza_marinara.ToString());
double price_marinara = pizza_marinara.CalculatePrice();
Console.WriteLine($"Price of {nameof(pizza_marinara)} = {String.Format("{0:0.00}", price_marinara)} Euro");
Console.WriteLine("----------------------------------");

Pizza pizza_supreme = new Pizza(new Supreme());
Console.WriteLine($"\t{(nameof(pizza_supreme).ToUpper())}\n");
Console.WriteLine(pizza_supreme.ToString());
double price_supreme = pizza_supreme.CalculatePrice();
Console.WriteLine($"Price of {nameof(pizza_supreme)} = {String.Format("{0:0.00}", price_supreme)} Euro");
Console.WriteLine("----------------------------------");

