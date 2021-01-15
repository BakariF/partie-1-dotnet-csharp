using System;

namespace exercice6
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("nom");
            string lastName = Console.ReadLine();
            Console.WriteLine("Veuillez écrire votre prénom sur ce magnifique input");
            string firstName = Console.ReadLine();
            Console.WriteLine("How old are you ?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fiche de renseignement");
            Console.WriteLine("Nom : " + lastName);
            Console.WriteLine("Prénom : " + firstName);
            Console.WriteLine("Année de naissance : " + age + "ans");

        }
    }
}
