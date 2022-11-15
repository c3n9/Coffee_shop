using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffee_shop
{
    internal class Program
    {
        public class Coffee
        {
            public string Latte = "Latte";
            public string Rough = "Rough";
            public string Americano = "Americano";
            public string Turkish = "Turkish";
            public string Milk = "Milk";
            public string Cream = "Сream";
            public string Sugar = "Sugar";
            public string Vanilla = "Vanilla";
            public double Price = 0;
            public double yourMoney = 0;
            public int Count = 0;
            public double Change = 0;
            public string[] Bill = new string[16];
            public double[] Cost = new double[16];
        }
        internal class CoffeeShop
        {
            static void DrawOffice()
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Good afternoon, what would you like?");
                Console.WriteLine("------------------------------------");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("     Our assortment ^-^\n");
                Console.WriteLine("Coffee:\t\tToppings:\n" +
                                  $"\nLatte - 0,5$\t Milk - 0,1$\n" +
                                  $"Rough - 0,9$\t Cream - 0,25$\n" +
                                  $"Americano - 0,3$ Sugar - 0,09$\n" +
                                  $"Turkish - 1$\t Vanilla - 0,05$\n");
                Console.WriteLine("-----------------------------------");
                Console.ReadLine();
                Cart();
            }
            static void Cart()
            {
                Coffee c = new Coffee();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("   Adding to cart, what do you want");
                Console.WriteLine("-----------------------------------");
                bool l = true;
                while (l)
                {
                    string n = Console.ReadLine();
                    switch (n)
                    {
                        case "Latte":
                            c.Price += 0.5;
                            c.Bill[c.Count] = "Latte";
                            c.Cost[c.Count] = 0.5;
                            c.Count++;
                            Console.WriteLine("\nAnything else? Maybe toppings?\n");
                            break;
                        case "Rough":
                            c.Price += 0.9;
                            c.Bill[c.Count] = "Rough";
                            c.Cost[c.Count] = 0.9;
                            c.Count++;
                            Console.WriteLine("\nAnything else? Maybe toppings?\n");
                            break;
                        case "Americano":
                            c.Price += 0.3;
                            c.Bill[c.Count] = "Americano";
                            c.Cost[c.Count] = 0.3;
                            c.Count++;
                            Console.WriteLine("\nAnything else? Maybe toppings?\n");
                            break;
                        case "Turkish":
                            c.Price += 1;
                            c.Bill[c.Count] = "Turkish";
                            c.Cost[c.Count] = 1;
                            c.Count++;
                            Console.WriteLine("\nAnything else? Maybe toppings?\n");
                            break;
                        case "Milk":
                            c.Price += 0.1;
                            c.Bill[c.Count] = "Milk";
                            c.Cost[c.Count] = 0.1;
                            c.Count++;
                            Console.WriteLine("\nAnything else? Maybe toppings?\n");
                            break;
                        case "Cream":
                            c.Price += 0.25;
                            c.Bill[c.Count] = "Cream";
                            c.Cost[c.Count] = 0.25;
                            c.Count++;
                            Console.WriteLine("\nAnything else? Maybe toppings?\n");
                            break;
                        case "Sugar":
                            c.Price += 0.09;
                            c.Bill[c.Count] = "Sugar";
                            c.Cost[c.Count] = 0.09;
                            c.Count++;
                            Console.WriteLine("\nAnything else? Maybe toppings?\n");
                            break;
                        case "Vanilla":
                            c.Price += 0.05;
                            c.Bill[c.Count] = "Vanilla";
                            c.Cost[c.Count] = 0.05;
                            c.Count++;
                            Console.WriteLine("\nAnything else? Maybe toppings?\n");
                            break;
                        case "No":
                            l = false;
                            break;
                        default:
                            Console.WriteLine("\nI don't understand you. Try again.\n");
                            break;
                    }

                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Your order:");
                for (int i = 0; i < c.Count; i++)
                {
                    Console.WriteLine($"{c.Bill[i]}:.................{c.Cost[i]}$");
                }
                Console.WriteLine($"\nTotal:.................{c.Price}$\n\n");
                bool j = true;
                while (j)
                {

                    Console.Write("Enter the amount to pay for the order: ");
                    try
                    {
                        c.yourMoney = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введи номинал!");
                    }
                    Console.WriteLine("-----------------------------------");
                    if (c.yourMoney < c.Price)
                    {
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("You don't have enough money, try again!");
                        Console.WriteLine("-----------------------------------");
                    }
                    else if (c.yourMoney == c.Price)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Ho-ho, no change, thank you! Come to us again :)");
                        Console.WriteLine("------------------------------------------------");
                        j = false;
                    }
                    else if (c.yourMoney > c.Price)
                    {
                        Console.Clear();
                        c.Change = c.yourMoney - c.Price;
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine($"You gave: {c.yourMoney}$, your change: {c.Change}$\n" +
                            $"Come to us again :)");
                        Console.WriteLine("------------------------------------------------");
                        j = false;
                    }
                    else
                    {
                        Console.WriteLine("\nI don't understand you!!!!\n");

                    }
                } 
                
            }
            static void Main(string[] args)
            {
                DrawOffice();
            }
        }
    }
}
