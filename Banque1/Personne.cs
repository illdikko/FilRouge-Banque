using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque1
{
    public class Personne
    {

        #region Champs - Variables membres
        private string _nom;
        private string _prenom;
        private DateTime _dateNaissance;
        #endregion

        #region Propriétés
        //public string Nom
        //{
        //    get { return _nom; }
        //    set
        //    {
        //        if (!string.IsNullOrWhiteSpace(value)) _nom = value.Trim(); // permet de vérifier que la veleur entrée n'est pas nulle. value.Trim() permet de retirer tous les espaces vides avant et après l'entrée. 

        //    }

        public string Nom { get; set; } // une autopropritété est plus adaptée s'il n'y a pas de conditions à la propriété. (cf Courant.LigneDeCrédit).
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        #endregion

        #region Constructeur & Destructeur
        #endregion

        #region Méthodes et opérateurs

        public static bool operator ==(Personne left, Personne right)
        {
            if (left is null && right is null) return true;
            if (left is null || right is null) return false;
            if (left.Nom.ToUpper() == right.Nom.ToUpper() && left.Prenom.ToLower() == right.Prenom.ToLower() && left.DateNaissance == right.DateNaissance) return true;
            return false;
        }

        public static bool operator !=(Personne left, Personne right)
        {
            return !(left == right);
        }

        #endregion

    }
}
