using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque1
{
    class Courant : Compte
    {
        #region Variables membres
       

        private double _lignecredit;

        #endregion

        #region Propriétés
        

        public double LigneDeCredit
        {
            get { return _lignecredit; } //permet d'afficher le montant de la ligne de cérdit (découvert)
            set
            {
                if (value >= 0 && value >= -Solde) _lignecredit = value; //Une autorisation à découvert est forcément = ou supérieure à zéro!
            }

        }

        #endregion

        #region Methodes et Opérateurs
        
        public override void Retrait(double montant)
        {
            base.Retrait(montant, LigneDeCredit);

        }

        protected override double CalculInteret()
        {
            if (Solde >= 0) return Solde * 0.03;
            else return Solde * 0.0975;
        }

        #endregion
    }


}
