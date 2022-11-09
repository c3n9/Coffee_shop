using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
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
    }
    internal class Program
    {   
        static void DrawOffice()
        {
            Coffee coffee = new Coffee();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Good afternoon, what would you like?");
            Console.WriteLine("------------------------------------");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("     Our assortment ^-^\n");
            Console.WriteLine("Coffe:\t\tToppings:\n" +
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
            string n = Console.ReadLine();
            bool l = true;
            while (l) 
            { 
                switch ("n")
                {
                    case "Latte":
                        c.Price += 0.5;
                        break;
                    case "Rough":
                        c.Price += 0.9;
                        break;
                    case "Americano":
                        c.Price += 0.3;
                        break;
                    case "Turkish":
                        c.Price += 1;
                        break;
                    default:
                        Console.WriteLine("\nAnything else?\n");
                        Console.ReadLine();
                        l =false;
                        break;
                }
            }
        }
        static void Bill()
        {

        }
        static void Main(string[] args)
        {
            DrawOffice();
        }
    }
}
