//Write a program that asks the user for an input value and then also asks if the value is a miles or kilometer value.
//If the value is in miles, convert it to kilometers and print it, and vice versa for kilometers.

double number;
string type;

Console.WriteLine("Length converter");
Console.WriteLine("Please input a number value:");

number = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What kind of value is this? (kilometers/miles)");

type= Console.ReadLine();
type = type.ToLower();

if(type=="kilometers" || "kilometers".StartsWith(type) || type=="km" || type=="kms")
{
    double mile;

    mile = number / 1.60934;
    Console.WriteLine("Miles= " + mile);
}
else if(type=="miles" || "miles".StartsWith(type))
{
    double km;

    km = number * 1.60934;
    Console.WriteLine("Kilometers= " + km);
}
else
{
    Console.WriteLine("Sorry, my mom didn't tell me how to convert that, please use kilometers or miles");
}