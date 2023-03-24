using Project;
namespace Project
{
    public class User
    {

        public Bank amount;
        public List<string> inventory;

        public string Name { get; }
        public int Money { get; set; }



        public User(string name, int amount)
        {
            Name = name;
            Money = amount;

            inventory = new List<string>();
        }


    }

}


