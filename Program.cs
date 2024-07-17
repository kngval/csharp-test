

using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {


        Animal animal = new Animal();
        Pig pig = new Pig();
        Duck duck = new Duck();

        animal.Talk();
        pig.Talk();
        duck.Talk();



        //initializing an array with the 'new' keyword
        string[] fraudulentOrderIDs = new string[4];
        fraudulentOrderIDs[0] = "Hello";
        fraudulentOrderIDs[1] = "World";
        fraudulentOrderIDs[2] = "Of";
        fraudulentOrderIDs[3] = "Technology\n\n";

        foreach (string str in fraudulentOrderIDs)
        {
            Console.WriteLine(str);
        }

        string[] names = { "John", "David", "Bryan", "Scott\n\n" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        //adding an array of integers
        int[] nums = { 1, 80, 20, 9, 55 };
        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;

        }
        Console.WriteLine(sum);


        //iterate through the orderIds array and return every order that starts with "B"
        string[] orderIds = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
        foreach (string order in orderIds)
        {
            if (order.StartsWith("B"))
            {
                Console.WriteLine($"{order} : Order starts with B!\n\n");
            }
        }
        Book book1 = new Book("The Silent Patient", "Alex Michaelides", 250, "Horror");

        Book book2 = new Book("The Last Time I lied", "Riley Sager", 650, "Mystery");

        Console.WriteLine(book1.Genre);
        Console.WriteLine(book2.Genre);

    }


}