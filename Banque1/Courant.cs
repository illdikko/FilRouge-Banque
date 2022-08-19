using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRouge_Banque
{
    public class Courant
    {
        //Les propriétés publiques

        private double _lignecredit;
        private double _solde;
        public string Numero { get; set; }
        public double Solde { get; private set; } //Ajout d'une condition possible : Mon solde doit toujours être supérieur à ma limite solde+ligne de crédit.
        public double LigneDeCredit
        {
            get { return _lignecredit; } //permet d'afficher le montant de la ligne de crdit (découvert)
            set
            {
                if (value < 0) _lignecredit = 0; //Une autorisation à découvert est forcément = ou supérieure à zéro!
                else _lignecredit = value;
            }

        }
        public Personne Titulaire;


        //        Les méthodes publiques :



        public void Retrait(double Montant)
        {
            if (Montant > 0 && Montant <= _solde + _lignecredit) _solde = _solde - Montant;

        }

        public void Depot(double Montant)
        {
            if (Montant > 0) _solde = _solde + Montant;

        }
    }


}
