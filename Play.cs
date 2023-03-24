using System;
using System.Collections.Generic;
namespace Project
{
    public class Play
    {
        public User Newuser { get; set; }
        public VendingMachine vendingMachine;



        public List<string> commands { get; } = new List<string>()
        {
            "list",
            "choose",
            "leave",
            "items",
            "inventory",
            "wallet",

        };


        public void PlayGame()
        {
            Console.WriteLine("Welcome to this amazing vendin machine");
            Console.WriteLine("Type 'items' to see all our products. And list for all the commands");
            Console.WriteLine("The company is tight on money, so there's only one piece of each snack.... Sorry");
            string command;

            do
            {

                command = GetCommand();


                if (command == "list")
                {

                    ShowCommands();
                }

                if (command == "choose")
                {
                    Choose();

                }

                if (command == "items")
                {
                    ShowItems();
                }

                if (command == "inventory")
                {
                    ShowInventory();
                }

                if (command == "wallet")
                {
                    ShowWallet();
                }




            }
            while (command != "leave");
        }

        public string GetCommand()
        {
            while (true)
            {
                Console.WriteLine("Please input a command");


                var input = Console.ReadLine();

                if (commands.Contains(input))
                {

                    return input;
                };

            };

        }

        public void ShowCommands()
        {
            foreach (var command in commands)
            {
                Console.WriteLine(command);
            }
        }



        public void Choose()
        {
            Console.WriteLine("Please select a snack");
            var choice = Console.ReadLine();


            Item foundItem = null;
            foreach (var item in vendingMachine.items)
            {

                if (item.Name == choice)
                {
                    foundItem = item;
                    break;
                }

            }

            if (foundItem != null)
            {
                if (foundItem.Price > Newuser.Money)
                {
                    Console.WriteLine($"Sorry {Newuser.Name} looks like you're to poor");
                    return;
                }

                Console.WriteLine($"You chose {choice} for {foundItem.Price}");


                Newuser.Money -= foundItem.Price;

                Newuser.inventory.Add(foundItem.Name);
                vendingMachine.items.Remove(foundItem);

                return;
            }

            Console.WriteLine($"Sorry we do not have {choice}");

        }

        public void ShowItems()
        {

            foreach (var item in vendingMachine.items)
            {
                Console.WriteLine($"{item.Name}: {item.Price} kr");

            }
        }

        public void ShowInventory()
        {

            if (Newuser.inventory.Count == 0)
            {
                Console.WriteLine("Inventory is empty");
            }
            foreach (var item in Newuser.inventory)
            {
                Console.WriteLine(item);

            }
        }

        public void ShowWallet()
        {
            Console.WriteLine($"{Newuser.Money}kr");
        }

    }


}


