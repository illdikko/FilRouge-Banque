using System;

namespace Banque1
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne titulaire1 = new Personne();
            titulaire1.Nom = "Ducourtieux";
            titulaire1.Prenom = "Coline";
            titulaire1.DateNaissance = new DateTime(1990, 3, 21);

            Personne titulaire2 = new Personne();
            titulaire2.Nom = "Willis";
            titulaire2.Prenom = "Bruce";
            titulaire2.DateNaissance = new DateTime(1955, 3, 19);

            Compte compte1 = new Compte(); // création d'une instance dont toutes les variables obtiennent une valeur par défaut.
            compte1.Titulaire = titulaire1;
            compte1.Numero = "BE15 6789 0958 3248";
            compte1.LigneDeCredit = 0;

            compte1.Depot(montant: 78946);

            Console.WriteLine($"Le compte {compte1.Numero} appartennant à {titulaire1.Nom} {titulaire1.Prenom}, née le {titulaire1.DateNaissance}, a un solde actuel de {compte1.Solde}. Une autorisation à découvert est possible jusqu'à -{compte1.LigneDeCredit}");

            Console.WriteLine("Veuillez entrer un numéro de compte pour effectuer votre recherche : ");
            string _numero =Console.ReadLine();

            Banque banque1 = new Banque();
            banque1.NomBanque = "ING";

            Banque banque2 = new Banque();
            banque2.NomBanque = "Belfius";





        }
    }
}
