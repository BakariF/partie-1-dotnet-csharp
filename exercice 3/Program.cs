using System;

namespace exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int firstNumber;
            firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber;
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("je rajoute 33 au premier nombre");
            Console.WriteLine(firstNumber + 33);
            Console.WriteLine("j'incrémente le second nombre");
            secondNumber++;
            Console.WriteLine(secondNumber);
            Console.WriteLine("je divise les deux nombres");
            Console.WriteLine(firstNumber / secondNumber);
         }
    }
}
