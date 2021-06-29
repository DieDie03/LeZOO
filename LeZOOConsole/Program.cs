using System;
using LeZOO;
namespace LeZOOConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            StructAdresse adresse =  new StructAdresse();
            adresse.Rue = "rue de Vienne";
            adresse.Numero = "1";
            adresse.CP = 4510;
            adresse.Localite = "Ciney";
            adresse.Pays = "Russie";

            Zoo Constantin = new Zoo("Chez Constantin", adresse);

            Console.WriteLine(Constantin.Name);
            Aquarium Aquarium = new Aquarium("Zon Shark",86,3,3,10,1);
            EnclosClassique Enclos = new EnclosClassique("Zone Shark", 86, 2, 2, 1,1,2,2,5);
            Constantin.ajouter(Enclos);
            //Constantin.ajouter(Aquarium);
            //Constantin.Enclos.TryGetValue("Zon Shark", out Enclos value);
            //Console.WriteLine($"nom : { value.Nom}  Superficie: {value.Superficie} et temp : {value.Temperature}");
            //Console.WriteLine($"Et car c'est un Aquarium : {((Aquarium)value).Profondeur}+++++ {((Aquarium)value).Salinite}++++++{((Aquarium)value).Volume.Volume} ");
            Console.WriteLine(Constantin.Enclos.TryGetValue("Zone Shrk", out Enclos value));
            Console.WriteLine(((EnclosClassique)value).Environnement);
        }
    }
}
