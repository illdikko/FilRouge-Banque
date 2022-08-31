using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banque1
{
    class Banque
    {
        #region Variables membres - Champs

        private Dictionary<string, Compte> _comptes = new Dictionary<string, Compte>(); // Ne pas oublier de créer la 1ere instance des dictionnaires /!\
        #endregion

        #region Propriétés & indexeur
        public string NomBanque { get; set; }

        //Indexeur
        public Compte this[string _numero]
        {
            get
            {
                Compte c;
                _comptes.TryGetValue(_numero, out c);
                return c;
            }

        }
        #endregion

        #region Constructeur - Destructeur

        #endregion


        #region Méthodes & opérateurs

        public void Ajouter(Compte value)
        {
            if (value != null && !_comptes.ContainsKey(value.Numero))
            {
                _comptes.Add(value.Numero, value);
            }
        }

        public void Supprimer(string value)
        {
            if (value != null && _comptes.ContainsKey(value))
            {
                _comptes.Remove(value);
            }
        }

        public double AvoirsDesComptes(Personne titulaire)
        {
            double somme = 0;
            foreach (KeyValuePair<string, Compte> kvp in _comptes)
            {
                Compte compte = kvp.Value;
                if (titulaire == compte.Titulaire)
                {
                    somme += compte;
                }
            }
            return somme;
        }
        #endregion

    }
}
