using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilRouge_Banque
{
    public class Personne
    {

        //#region Champs - Variables membres
        //private string _nom;
        //private string _prenom;
        //private DateTime _dateNaissance;
        //#endregion

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
        #endregion

    }
}
