using Animaux;

internal class Program
{
    private static void Main(string[] args)
    {
        Chien Chien1 = new Chien("Nom1", "Race1", 1, false);
        Chien Chien2 = new Chien("Nom2", "Race2", 2, false);
        Chien Chien3 = new Chien("Nom3", "Race3", 3, false);

        /*string nom;
        string race;
        uint age;
        bool vaccin;*/

        Console.WriteLine(Chien1.RecupereCaracteristiques());
        Console.WriteLine(Chien2.RecupereCaracteristiques());
        Console.WriteLine(Chien3.RecupereCaracteristiques());
        Console.ReadLine();

        Chien1.Age = Chien1.Age + 1;
        Chien2.Age = Chien2.Age + 1;
        Chien3.Age = Chien3.Age + 1;

        Chien1.Vaccin = Chien1.Vaccin;
        Chien2.Vaccin = Chien2.Vaccin;
        Chien3.Vaccin = Chien3.Vaccin;

        Chien[] mesChiens = new Chien[3];

        mesChiens[0] = Chien1;
        mesChiens[1] = Chien2;
        mesChiens[2] = Chien3;

        Console.WriteLine(mesChiens);
        Console.ReadLine();
    }
}