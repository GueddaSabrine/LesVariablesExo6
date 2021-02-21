using System;

namespace LesVariablesExo6
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Via la console, demande à l’utilisateur de renseigner son nom, son prénom et son année de naissance.
            Une fois tous les éléments renseignés, faire en sorte d’afficher à l’aide d’une seule commande:
            Fiches de renseignement
            *Nom :
            *Prénom :
            *Age :*/

            Console.WriteLine("Entrez votre nom : ");
            string snom = Console.ReadLine();

            Console.WriteLine("Entrez votre prénom : ");
            string sprenom = Console.ReadLine();

            Console.WriteLine("Entrez votre année de naissance : ");
            string  DateBirth = Console.ReadLine();

            int currentYear = DateTime.Now.Year;
            int age = currentYear - Convert.ToInt32(DateBirth);
            //int age = 2021 - Convert.ToInt32(DateBirth);

            Console.WriteLine($"Fiche de renseignement \n Nom {snom} \n Prénom {sprenom} \n Age {age}");
        }
    }
}
