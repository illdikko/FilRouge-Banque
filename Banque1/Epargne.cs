using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque1
{
    class Epargne : Compte
    {

        #region Variables membres - Champs
        private DateTime _dernierRetrait;
        #endregion



        #region Propriété + indexeurs

        public DateTime DernierRetrait
        { get; set; }

        #endregion


        //méthodes publiques

        #region Methodes + Opérateurs
        public override void Retrait(double montant)
        {
            double oldSolde = Solde;
            base.Retrait(montant);

            if (oldSolde > Solde) { DernierRetrait = DateTime.Now; }
        }

        protected override double CalculInteret()
        {
            return Solde*0.045;
        }
        #endregion
    }
}
