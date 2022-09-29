using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author: Andrew Marshall
 * Date: 01/28/2021
 * File: program.cs
 * Description: contains the store class item class and all its subclasses and functions 
 * Programming Environment: windows with visual studio
 */
namespace PA_1
{
    //this is the store class which sets up a menu drivin interface and asks the user what they want to do 
    class Store
    {
        //main which is prints out the menu and aks user for input 
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to the store here are the items available");
            Console.WriteLine("Vegatable, Textbook, and Dog");
            Console.WriteLine("enter which item you would like to edit");
            string input = Console.ReadLine();
            if (input == "Vegatable")
            {
                Vegatable v = new Vegatable();
                Console.WriteLine("you have selected vegatable would you like to check the price, print info,or you can purchase the item?");
                string choice = Console.ReadLine();
                if(choice == "check the price")
                {
                    
                    v.checkPrice();

                }
                if (choice == "print info")
                {
                    v.printInfo();
                    
                }
                if(choice=="purchase the item")
                {
                    v.purchase();
                   
                }
              
            }
            if (input == "Textbook")
            {
                Textbook v = new Textbook();
                Console.WriteLine("you have selected Textbook would you like to check the price, print info,or you can purchase the item?");
                string choice = Console.ReadLine();
                if (choice == "check the price")
                {

                    v.checkPrice();
                    

                }
                if (choice == "print info")
                {
                    v.printInfo();Console.ReadLine();
                }
                if (choice == "purchase the item")
                {
                    v.purchase();
                   
                }


            }
            if (input == "Dog")
            {
                Dog v = new Dog();
                Console.WriteLine("you have selected dog would you like to check the price, print info,or you can purchase the item?");
                string choice = Console.ReadLine();
                if (choice == "check the price")
                {

                    v.checkPrice();
                    

                }
                if (choice == "print info")
                {
                    v.printInfo();
                    
                }
                if (choice == "purchase the item")
                {
                    v.purchase();

                   
                }


            }
            //check to make sure user is entering a valid item 
            else
            {
                Console.WriteLine("error command not recognized");
            }
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
    //this is the abstract base class for Items it contains the declares the three diffrent functions that the derived class can override
    abstract class Item
    {
        public abstract void checkPrice();
        public abstract void printInfo();
        public abstract void purchase();

    }
    //This is the first derived class from item which overides the three functions and declares the type name quantity and price
    class Vegatable : Item
    {
        private string Type = "food";
        private string Name = "Vegatable";
        private int Quantity = 10;
        private double Price = 1.00;
        //prints out the price of the vegatable 
        public override void checkPrice()
        {
            
            Console.WriteLine(Price);
        }
        //prints out all the info about the vegatable 
        public override void printInfo()
        {
            Console.WriteLine(Type);
            Console.WriteLine(Name);
            Console.WriteLine(Quantity);
            Console.WriteLine(Price);
        }
        //takes input from user with how many they want to buy and subtracts that from quantity 
        public override void purchase()
        {
            
            Console.WriteLine("enter amount you want to purchase");
            string line = Console.ReadLine();
            int a = int.Parse(line);
            //makes sure quantity is a positive number 
            if (Quantity > 0)
            {
                Quantity = Quantity - a;

            }
            //this makes sure that the user cant buy anymore if the item is sold out 
            else
            {
                Console.WriteLine("this item is sold out :(");
            }
           

        }
    

    }
    //This is the second derived class from item which overides the three functions and declares the type name quantity and price 
    class Textbook : Item
    {
        private string Type = "Literature";
        private string Name = "Textbook";
        private int Quantity = 5;
        private double Price = 5.00;
        //prints out the price of the Textbook
        public override void checkPrice()
        {
            Console.WriteLine(Price);
        }
        //prints out all the info about the Textbook
        public override void printInfo()
        {
            Console.WriteLine(Type);
            Console.WriteLine(Name);
            Console.WriteLine(Quantity);
            Console.WriteLine(Price);
        }
        //takes input from user with how many they want to buy and subtracts that from quantity 
        public override void purchase()
        {

            Console.WriteLine("enter amount you want to purchase");
            string line = Console.ReadLine();
            int a = int.Parse(line);
            //makes sure quantity is a positive number 
            if (Quantity > 0)
            {
                Quantity = Quantity - a;

            }
            //this makes sure that the user cant buy anymore if the item is sold out 
            else
            {
                Console.WriteLine("this item is sold out :(");
            }




        }


    }
    //This is the third derived class from item which overides the three functions and declares the type name quantity and price
    class Dog : Item
    {
        private string Type = "Animal";
        private string Name = "Dog";
        private int Quantity = 2;
        private double Price = 100.00;
        //Prints out the price of the Dog
        public override void checkPrice()
        {
            Console.WriteLine(Price);
        }
        //prints out all the info about the dog 
        public override void printInfo()
        {
            Console.WriteLine(Type);
            Console.WriteLine(Name);
            Console.WriteLine(Quantity);
            Console.WriteLine(Price);
        }
        //takes input from user with how many they want to buy and subtracts that from quantity 
        public override void purchase()
        {

            Console.WriteLine("enter amount you want to purchase");
            string line = Console.ReadLine();
            int a = int.Parse(line);
            //makes sure quantity is a positive number 
            if (Quantity > 0)
            {
                Quantity = Quantity - a;

            }
            //this makes sure that the user cant buy anymore if the item is sold out 
            else
            {
                Console.WriteLine("this item is sold out :(");
            }




        }


    }

}
