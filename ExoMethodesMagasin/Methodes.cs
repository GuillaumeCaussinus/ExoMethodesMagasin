using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoMethodesMagasin
{
    internal class Methodes
    {
        static Dictionary<string, int> panier = new Dictionary<string, int>();
        static Dictionary<string, int> stock = new Dictionary<string, int>();
        static bool continuer = true;
        const int prixCoca = 1;
        const int prixSandwich = 5;
        const int prixPorte = 200;
        static void Main(string[] args)
        {
            panier.Add("Coca ", 0);
            panier.Add("Sandwich", 0);
            panier.Add("Porte", 0);
            stock.Add("Coca", 4);
            stock.Add("Sandwich", 2);
            stock.Add("Porte", 3);

        }
        static void Affichage()
        {
            int counter = 1;
            foreach (KeyValuePair<string, int> item in stock)



            {
                Console.WriteLine($"{counter} : {item.Key} - {item.Value}");
                counter++;
            }
            Console.WriteLine("4 : arrêter les achats / calculer le total ");
            Console.WriteLine("Veuillez faire un choix");
            int ChoixUtilisateur = int.Parse(Console.ReadLine());
            Acheter(ChoixUtilisateur);
        }


        static void Acheter(int ChoixUtilisateur)
        {
            switch (ChoixUtilisateur)
            {
                case 1:
                    panier["Coca Cola"] += 1;
                    stock["Coca Cola"] -= 1;
                    break;
                case 2:
                    panier["Sandwich"] += 1;
                    stock["Sandwich"] -= 1;
                    break;
                case 3:
                    panier["Porte"] += 1;
                    stock["Porte"] -= 1;
                    break;
                case 4:
                    Addition();
                    continuer = false;
                    break;

            }

            static void Addition()
            {
                int total = 0;
                foreach (KeyValuePair<string, int> item in panier)
                {
                    if (item.Key == "Coca cola") total = total + (prixCoca * item.Value);
                    if (item.Key == "Sandwich") total = total + (prixSandwich * item.Value);
                    if (item.Key == "Porte") total = total + (prixPorte * item.Value);

                }
                Console.WriteLine($" Vous devez payer {total} euros, merci pour vos achats , à bientôt");
            }
        }
    }


}