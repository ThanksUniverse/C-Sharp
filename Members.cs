using System.Net.Http.Headers;
using Microsoft.VisualBasic;

namespace Public
{
    class Player
    {
        private static List<int> playerIds = new();
        private string name = "Player";
        private int age = 18;
        private string country = "World";
        private double balance = 10084.84;
        private int playerId = 0;

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Country { get { return country; } set { country = value; } }
        public double Balance { get { return balance; } set { balance = value; } }
        public int PlayerId { get { return playerId; } set { playerId = value; } }

        public Player()
        {
            PlayerId = GeneratePlayerId();
            Console.WriteLine("Sample player was created");
        }

        private static int GeneratePlayerId()
        {
            int newPlayerId;
            if (playerIds.Count <= 0)
            {
                playerIds.Add(1);
                newPlayerId = 1;
            }
            else
            {
                int lastValue = playerIds[playerIds.Count - 1]; // Subtract 1 here
                playerIds.Add(lastValue + 1);
                newPlayerId = lastValue + 1;
            }
            return newPlayerId;
        }

        public Player(string name, int age, string country, double balance)
        {
            Name = name;
            Age = age;
            Country = country;
            Balance = balance;
            PlayerId = GeneratePlayerId();
            Console.WriteLine("Player {0} was created.\nAge: {1}\nCountry: {2}\nBalance: {3}\nIdentifier: {4}", Name, Age, Country, Balance, playerId);
        }

        public void Information()
        {
            Console.WriteLine("Player {0} was created.\nAge: {1}\nCountry: {2}\nBalance: {3}\nIdentifier: {4}", Name, Age, Country, Balance, playerId);
        }

        ~Player()
        {
            playerIds.Remove(this.playerId);
            Console.WriteLine("Player {0} was deleted.", playerId);
        }
    }
}