Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
{
    discountPercentage += 10;
    Console.WriteLine(@$"Your subscription expires in {daysUntilExpiration} days.
Renew now and save {discountPercentage}%!");
}
if (daysUntilExpiration <= 10 && daysUntilExpiration > 5)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
if (daysUntilExpiration == 1)
{
    discountPercentage += 20;
    Console.WriteLine(@$"Your subscription expires in {daysUntilExpiration} days.
Renew now and save {discountPercentage}%!");
}
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else
{
    
}
