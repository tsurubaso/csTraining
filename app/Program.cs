// See https://aka.ms/new-console-template for more information


using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string paragraph ="Hello Sylvain";
        Console.WriteLine("bonjour "+paragraph);

        int number=2;
        float price =3.99f;
        Console.WriteLine(number*price);
        int a=1;
        int b=2;
        int c=a+b;
System.Console.WriteLine( c  );

float vat=19f;
float pA=3.99f;
float pB=11.99f;
float pC=6.76f;
float summed= pA+pB+pC;
float totalTax= (summed/100)*vat;

System.Console.WriteLine(   "total Price is: "+summed);


System.Console.WriteLine(   "Please enter a number!:");
string userInput =Console.ReadLine();
try
{
    int userInputAsInt =int.Parse(userInput);
}
catch (System.ArgumentNullException)
{
System.Console.WriteLine(   "Faut écrire René");
}
catch (System.FormatException)
{
    System.Console.WriteLine(   "this is not the good format!");}
    
catch (System.OverflowException)
{
System.Console.WriteLine(   "trop long mon gars!");

}
finally
{
    System.Console.WriteLine(   "t'as quelque chose a dire???");
}


}










    }



