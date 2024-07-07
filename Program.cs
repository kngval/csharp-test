

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


    }

}