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
            int k, saisie;

            Console.Write("Saisir le nombre de température à saisir :");
            k= int.Parse(Console.ReadLine());

            // Déclaration du tableau
            int[] temp = new int[k];


            // Saisie des températures + fonction de calcul du nombre de température positive ou négative
            int TempPosi = 0, TempNega = 0;
            for (int i = 0; i < k; i++)
            {
                //Vérification si la saisie est un entier ou non
                bool correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.Write("Saisir une température :");
                        temp[i] = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                    }
                }

                

                //Fonction du calcul du nombre de température positive ou négative

                //Si la valeur saisie est supérieur à 0 (donc positive)
                if (temp[i] >= 0)
                {
                    TempPosi++;
                    Console.WriteLine("Température positive enregistrée");
                }

                //Si la valeur saisie est supérieur à 0 (donc négative)

                if (temp[i] < 0)
                {
                    TempNega++;
                    Console.WriteLine("Température négative enregistrée");
                }
            }
            
            Console.WriteLine("Nombre de température positive(s) :" + TempPosi);
            Console.WriteLine("Nombre de température négative(s) :" + TempNega);
            Console.WriteLine("Appuyer sur Entrée pour passer à la recherche !");
            Console.ReadLine();




            //Recherche de la température
            //La variable saisie sert à avoir la température à saisir pour pouvoir la comparer 
            Console.Write("Saisir une température à chercher :");
            saisie = int.Parse(Console.ReadLine());
            //Nouveau
            Console.WriteLine("Recherche de la valeur ", saisie);
            //La variable tempé va permettre de renvoyer 1 si la température est trouvé ou 0 si elle n'est pas trouvé
            bool tempé;

                tempé = false;
                //parcours du tableau
                for (int i=0 ; i < k; i++) {
                    //comparaison
                    if (temp[i] == saisie)
                    {
                        tempé = true;
                    //La variable a va servir à obtenir la position du vecteur
                    int a;
                    //Obtention de la position du vecteur ( on rajoute +1 pour avoir une position précise
                    a = i + 1;
                    //Affichage de la position du vecteur
                    Console.WriteLine("Position n°" + a);
                    }

                }

            if (tempé == true)
            {
                Console.WriteLine("La température saisie existe !");
            }else
            {
                Console.WriteLine("La température n'existe pas !");
            }
            Console.ReadLine();
            

        }

    }
}
