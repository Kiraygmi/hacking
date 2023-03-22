// Scrie o functie care primeste ca si argument varsta unei persoane
// si returneaza daca acea persoana este majora sau nu
// verificati varsta unei persoane introdusa de la tastatura folosing functia scrisa
int age;
age = Int32.Parse(Console.ReadLine());


if (asdfg(age)/* == true */)
{
    Console.WriteLine("This person can drink, only in Europe tho.");
}
else
{
    Console.WriteLine("You look a bit young, give me your ID.");
}



bool asdfg(int age)
{
    if (age >= 18)
    {
        return true;
    }
    else
    {
        return false;
    }

}


