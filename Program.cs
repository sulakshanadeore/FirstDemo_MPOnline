internal class Program
{
    private static void Main(string[] args)
    {
        //int,float,double,long,decimal,datetime,bool,char,string
        //namespace----> System is the father/base of all namespaces in the Library.
        //Logically related classes will be under one namespace.
        //System--Multiple classes---Each class multiple methods,events,properties etc.
        //One method among it is writeline
        Console.WriteLine();//cw is shortcut/code snippet for console.writeline
        //Writeline is method in the console class which can print in 18 different ways the values. So this is overloaded method.
        //Console.WriteLine("Enter a number");
        //int no1=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(no1);

        //int no2=0;
        //Console.WriteLine(no2);

        string no3 = null;
        //int no4=int.Parse(no3);//Format exeption---use parse if you want to parse the string to number format, but the value in the string is a number
        int no4 = Convert.ToInt32(no3);// If the string can be null value and u want default value of the integer then use convert
        Console.WriteLine(no4);

        string n1 = null;
        float f1=Convert.ToSingle(n1);
        Console.WriteLine(f1);


        Console.WriteLine("Enter a value");
        string s1=Console.ReadLine();
        int value1=Convert.ToInt32(s1);
        Console.WriteLine(value1);

        //Console.WriteLine("Hello, World!");//println
        //Console.WriteLine("Welcome");
        //Console.Write("Hello again");   
        //Console.WriteLine("  This will print on hello again line");
        //Console.Write("This is new line ");
        //Console.WriteLine(100);
        //Console.WriteLine(int.MinValue);
        //Console.WriteLine(int.MaxValue);
        //Console.WriteLine(DateTime.Now);
        //Console.WriteLine('A');
        //Console.WriteLine(4.14f);
        //Console.WriteLine(float.MinValue);
        //Console.WriteLine(float.MaxValue);
        
        //decimal avgprice = 4554364564;
        //Console.WriteLine(avgprice);//decimal
        //Console.WriteLine("Decimal data type min value=" +decimal.MinValue);//Printing using Concatenation
        //Console.WriteLine($"Decimal datatype max value ={decimal.MaxValue}");//Printing using interpolation
        //double price = 334434.23423;//
        //Console.WriteLine(price);



    }
}