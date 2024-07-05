Random random = new Random();
int daysUntilExpiration = random.Next(12);


// Your code goes here


if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within the day");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your Subscription expires in {daysUntilExpiration} days. Renew now and save 10%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else
{
    Console.WriteLine("boop");
}
Console.WriteLine(daysUntilExpiration);