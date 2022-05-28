// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int i;
Console.WriteLine("Enter the number to find prime factors:-");
int Number=Convert.ToInt32(Console.ReadLine());
for(i = 1; i <= Number; i++)
{
    if(Number%i==0)
    {
        Console.WriteLine("{0} is prime factor of {1}", i, Number);
    }

}
Console.ReadLine();