using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace jan18
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            String country;

            Console.WriteLine("please enter your name");
            name=Console.ReadLine();
            do
            {
                Console.WriteLine("please enter your name");
                name = Console.ReadLine();
            } while (!Regex.IsMatch(name, @"^[a-zA-Z]+$"));

            do{
            Console.WriteLine("Enter your country name");
            country = Console.ReadLine();
            }while(!Regex.IsMatch(country,@"^[a-zA-Z]+$"));


            Console.WriteLine("Hello  " + name + "you are from  " + country);
            Console.ReadLine();
        }
    }
}
