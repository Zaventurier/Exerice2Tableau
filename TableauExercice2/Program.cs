using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableauExercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //k étant la variable du nbr de cases du tableau.
            int k, sauv, saisie;

            Console.Write("Saisir le nombre de température à saisir :");
            k= int.Parse(Console.ReadLine());

            // Déclaration du tableau
            int[] temp = new int[k];


            // Saisie des températures
            for (int i = 0; i < k; i++)
            {
                Console.Write("Saisir une température :");
                temp[i] = int.Parse(Console.ReadLine());
                
            }
            //Recherche de la température
            //La variable saisie sert à avoir la température à saisir pour pouvoir la comparer 
            Console.Write("Saisir une température à chercher :");
            saisie = int.Parse(Console.ReadLine());
            //La variable tempé va permettre de renvoyer 1 si la température est trouvé ou 0 si elle n'est pas trouvé
            bool tempé;
            do
            {
                tempé = false;
                //parcours du tableau
                for (int p=0 ; p < k; p++) {
                    //comparaison
                    if (temp[k] == saisie)//UNE ERREUR EST DETECTE ICI
                    {
                        tempé = true;
                    }
                    else
                    {
                        tempé = false;
                    }
                }
            } while (tempé = true);

            if (tempé == true)
            {
                Console.WriteLine("La température saisie existe !");
            }else
            {
                Console.WriteLine("La température n'existe pas !");
            }
            
                
            








        }

    }
}
