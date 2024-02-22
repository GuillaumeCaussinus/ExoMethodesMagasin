using System.Numerics;

namespace ExoMethodesMagasin
{
    internal class Program
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
 




/* int prixCoca = 4, prixSandwish = 2, prixPorte = 200;
int stockCoca = 4, stockSandwish = 2, stockPorte = 3;
int choix;

int panier = 0;
bool continuerAchat = true;
while (continuerAchat)
{

    Console.WriteLine("Menu :");
    Console.WriteLine("1. Coca | prix : 1 euro");
    Console.WriteLine("2. Sandwish | prix : 5 euro");
    Console.WriteLine("3. porte | prix : 200 euro");
    Console.WriteLine("4. quitter");
    Console.WriteLine("faites votre choix");
    choix = int.Parse(Console.ReadLine());
    if (choix == 1)
    {
        panier = panier + prixCoca;
        stockCoca--;
        Console.WriteLine($"voici votre coca, il coute {prixCoca} et il en reste {stockCoca} dans le distributeur");
    }

    if (choix == 2)
    {
        panier = panier + prixSandwish;
        stockSandwish--;
        Console.WriteLine($"voici votre sandwish, il coute {prixSandwish} et il reste {stockSandwish} dans le distributeur");
    }

    if (choix == 3)
    {
        panier = panier + prixPorte;
        stockPorte--;
        Console.WriteLine($"voici votre porte, elle coute {prixPorte} et il reste {stockPorte} dans le distributeur");
    }

    if (choix == 4)
    {
        Console.WriteLine($"vous devez payer {panier} euro");
        continuerAchat = false;
    }
}  */



