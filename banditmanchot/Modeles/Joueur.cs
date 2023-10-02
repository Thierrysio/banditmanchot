using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace banditmanchot.Modeles
{
    internal class Joueur
    {
        #region Attributs

        public static List<Joueur> CollClasse = new List<Joueur>();
        private string _nom;
        private int _solde;
        #endregion

        #region Constructeurs

        public Joueur(string nom, int solde)
        {
            Joueur.CollClasse.Add(this);
            _nom = nom;
            _solde = solde;
        }

        #endregion

        #region Getters/Setters
       
            public string GetNom() { return _nom; }
            public void SetNom(string value) { _nom = value; }
        
            public int GetSolde() { return _solde; }
            public void SetSolde(int value) { _solde = value; }
    #endregion

    #region Methodes
    public void Miser(int montant)
        {
            if (montant > _solde)
                throw new Exception("Solde insuffisant.");

            _solde -= montant;
        }

        public void RecevoirGain(int gain)
        {
            _solde += gain;
        }
        #endregion
    }
}
