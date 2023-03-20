
Shinigamipower Rem = new Shinigamipower();


Rem.deathnote("Lind L. Tailor");
Rem.deathnote("Takuo Shibuimaru", "hit by truck");
Rem.deathnote("Naomi Misora", "suicide");
Rem.deathnote("Naoki Koro Kitayama");


class Shinigamipower
{
    public Shinigamipower()
    {

    }

    public void deathnote(string name, string cause)
    {
        Console.WriteLine(name + " death caused by " + cause);
    }
    public void deathnote(string name)
    {
        Console.WriteLine(name + " death caused by heart attack");
    }
}
