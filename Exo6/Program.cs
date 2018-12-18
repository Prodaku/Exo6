using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre NOM.");
            string Name = Console.ReadLine();
            Console.WriteLine("Entrez votre PRENOM.");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Entrez votre ANNEE DE NAISSANCE.");
            int DOB = int.Parse(Console.ReadLine()); //DateOfBirth

            string LJ = "\n"; //LineJump

            int age = DateTime.Now.Year - DOB;

            Console.WriteLine("Fiche de renseignement " + LJ + LJ + "Nom : " + Name + LJ + "Prénom : " 
                + FirstName + LJ + "Age : " + age + LJ);

            Console.WriteLine("Fiche de renseignement  \n Nom : " + Name + " \n Prénom : "
                + FirstName + " \n Age : " + age + "\n");



        }
    }
}
