namespace Assignment_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HouseLinkedList houseList = new HouseLinkedList();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add House");
                Console.WriteLine("2. Search House");
                Console.WriteLine("3. Display All Houses");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter house number: ");
                        int houseNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter brief address: ");
                        string address = Console.ReadLine();
                        Console.Write("Enter house type (e.g., Ranch, Colonial): ");
                        string houseType = Console.ReadLine();
                        houseList.AddHouse(houseNumber, address, houseType);
                        Console.WriteLine("House added successfully!");
                        break;

                    case "2":
                        Console.Write("Enter house number to search: ");
                        int searchNumber = int.Parse(Console.ReadLine());
                        HouseNode house = houseList.SearchHouse(searchNumber);
                        if (house != null)
                        {
                            Console.WriteLine($"House Found: Number: {house.HouseNumber}, Address: {house.Address}, Type: {house.HouseType}");
                        }
                        else
                        {
                            Console.WriteLine("House not found.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nList of Houses:");
                        houseList.DisplayHouses();
                        break;

                    case "4":
                        Console.WriteLine("Exiting the program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
  
