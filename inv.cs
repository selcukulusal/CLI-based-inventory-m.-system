using System;
namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            string username = "userA";
            int password = 12345;

            Console.WriteLine("Welcome to Selcuk's CLI based Inventory Management System!"));
            Console.WriteLine();

            bool IsLoggedin = true;

            while (IsLoggedin)
            {
                Console.Write("Please entry your username: ".Pastel(ConsoleColor.Blue));
                string? inputUsername = (Console.ReadLine());

                Console.Write("Please entry your password: ".Pastel(ConsoleColor.Blue));
                int inputPassword = int.TryParse(Console.ReadLine(), out int parsedPassword) ? parsedPassword : 0;
                Console.WriteLine();

                if (inputUsername == username && inputPassword == password)
                {
                    Console.WriteLine($"Entry is Successful! Welcome {username}!".Pastel(ConsoleColor.Green));
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid username or password. Please try again.".Pastel(ConsoleColor.Red));

                }

            }

            Console.WriteLine();
            Console.WriteLine("Make a choice ");
            Console.WriteLine("1. Add new product");
            Console.WriteLine("2. Update product");
            Console.WriteLine("3. Delete product");
            Console.WriteLine("4. View all products");
            Console.WriteLine("5. Exit");

            Console.WriteLine();

            bool select = false;
            while (!select)
            {
                int choice = int.TryParse(Console.ReadLine(), out int parsedChoice) ? parsedChoice : 0;

                switch (choice)
                {
                    case 1:
                        Console.Write("please entry a name: ");
                        string? name = Console.ReadLine();
                        Console.WriteLine($" '{name}' ADDED!");
                        break;
                    case 2:
                        Console.WriteLine("Products Updated!");
                        break;

                    case 3:
                        Console.Write("Please entry a product name: ");
                        string? product = Console.ReadLine(); 

                        if (!string.IsNullOrWhiteSpace(product))
                        {
                            DeleteProduct(product);
                            Console.WriteLine($"'{product}' DELETED! ");
                        }
                        else
                        {
                            Console.WriteLine("Error: Product name cannot be left blank!");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Keyboard, Mouse, Headphones,");
                        break;
                    case 5:
                        select = true;
                        break;

                    default:
                        Console.WriteLine("invalid choice or value");
                        break;
                }

            }

        }

        public static void DeleteProduct(string productName)
        { }

    }
}
