using System;

namespace exercice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            //j'écris nom
            Console.WriteLine("Entrez votre nom ET votre prénom ici, en même temps, s'il vous plaît bordel");
            name = Console.ReadLine();
            Console.WriteLine("bonjour " + name + ", nous sommes le 15 Janvier 2021, comment allez-vous ?");
        }
    }
}