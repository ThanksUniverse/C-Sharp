namespace Public
{
    class Program
    {
        public static void Main()
        {
            Player pedro = new("Pedro", 20, "Brazil", 100.37);
            Player pedro2 = new("Pedro", 20, "Brazil", 100.37);
            Player pedro3 = new("Pedro", 20, "Brazil", 100.37);
            var friends = new List<string> { "Pedro", "Pedro2", "Myko", "Pedro3", "Tay", "Pedro4", "Joe", "Pedro5", "Andy", "Bi", "BiggestName" };
            Console.WriteLine("Say how many people you want in the party.");
            string? inviteFriends = Console.ReadLine();
            int invited;
            while (!int.TryParse(inviteFriends, out invited) || (invited >= friends.Count || invited <= 0))
            {
                Console.WriteLine("Say how many people you want in the party.");
                inviteFriends = Console.ReadLine();
            }
            var partyFriends = GetPartyFriends(friends, invited);

            string friendList = "";

            foreach (var name in partyFriends)
                friendList = friendList + name + ", ";


            friendList = friendList.Remove(friendList.Length - 2);
            Console.WriteLine(friendList);
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            if (list == null)
                throw new ArgumentNullException("List", "The database seems to be offline or you doesnt have internet connection, try again later.");

            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count cannot be greater than partyFriends size.");

            var partyFriends = new List<string>();

            while (partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(list);
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend);
            }
            return partyFriends;
        }

        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }
    }
}

