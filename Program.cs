// See https://aka.ms/new-console-template for more information
using Project;

var VendingMachine = new VendingMachine();

VendingMachine.items.Add(new Item("snickers", 10));
VendingMachine.items.Add(new Item("twister", 15));
VendingMachine.items.Add(new Item("japp", 5));
VendingMachine.items.Add(new Item("fanta", 15));
VendingMachine.items.Add(new Item("nocco", 25));
VendingMachine.items.Add(new Item("cola", 15));
VendingMachine.items.Add(new Item("powerade", 45));


var user = new User("Robin", 30);

var play = new Play()
{
    vendingMachine = VendingMachine,
    Newuser = user
};


play.PlayGame();









