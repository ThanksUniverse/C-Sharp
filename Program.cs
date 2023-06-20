namespace Public
{
    class Program
    {
        public static void Main()
        {
            var myDictionary = new Dictionary<int, string>();
            //List<string> myList = new();
            myDictionary.Add(1, "Something");
            myDictionary.Add(2, "Something");
            myDictionary.Add(3, "Something");

            foreach (var item in myDictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(myDictionary[2]);
        }
    }
}

