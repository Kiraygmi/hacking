
//Write a program that asks the user for a value in miles as input, and then prints that value converted to kilometers


double mile;
Console.WriteLine("Miles to Kilometers converter");
Console.WriteLine("Miles=");



mile = Convert.ToDouble(Console.ReadLine());


double kilometer;
kilometer = mile * 1.60934;
Console.WriteLine("Kilometers= " + kilometer);

double kilometer2;
Console.WriteLine("Kilometers to miles converter");
Console.WriteLine("Kilometers=");


kilometer2 = Convert.ToDouble(Console.ReadLine());

double mile2;
mile2 = kilometer2 / 1.60934;
Console.WriteLine("Miles= " + mile2);