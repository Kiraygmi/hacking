// Given the age of a person as an input from the user, output their age group
//Age groups you need to handle: child 0 to 11, teenager 11 to 18, young adult 18 to 30, adult 31 to 60, senior 60+


string age;
age = Console.ReadLine();

if (int.TryParse(age, out int age_int))
{

    if (age_int >= 0 && age_int <= 11)
    {
        Console.WriteLine("child");
    }
    else if (age_int > 11 && age_int <= 18)
    {
        Console.WriteLine("teenager");
    }
    else if (age_int > 18 && age_int <= 30)
    {
        Console.WriteLine("young adult");
    }
    else if (age_int > 31 && age_int <= 60)
    {
        Console.WriteLine("adult");
    }
    else if (age_int > 60)
    {
        Console.WriteLine("senior");
    }

}
else if (age == "meow")
    Console.WriteLine("cat");
