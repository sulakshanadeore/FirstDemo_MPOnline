internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");//println
        Console.WriteLine("Welcome");
        Console.Write("Hello again");   
        Console.WriteLine("  This will print on hello again line");
        Console.Write("This is new line ");
        Console.WriteLine(100);
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(DateTime.Now);
        Console.WriteLine('A');
        Console.WriteLine(4.14f);
        Console.WriteLine(float.MinValue);
        Console.WriteLine(float.MaxValue);
        decimal avgprice = 4554364564;
        Console.WriteLine(avgprice);//decimal
        Console.WriteLine("Decimal data type min value=" +decimal.MinValue);//Printing using Concatenation
        Console.WriteLine($"Decimal datatype max value ={decimal.MaxValue}");//Printing using interpolation
        double price = 334434.23423;//
        Console.WriteLine(price);



    }
}