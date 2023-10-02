using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banditmanchot.Modeles
{
    public class SlotMachine
    {
        #region Attributs

        public static List<SlotMachine> CollClasse = new List<SlotMachine>();
        private List<Rouleau> rouleaux = new List<Rouleau>();

        

        #endregion

        #region Constructeurs

        public SlotMachine()
        {
            SlotMachine.CollClasse.Add(this);
            rouleaux.Add(new Rouleau());
            rouleaux.Add(new Rouleau());
            rouleaux.Add(new Rouleau());
        }

        #endregion

        #region Getters/Setters

        #endregion

        #region Methodes
        public List<string> Jouer()
        {
            List<string> results = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                results.Add(rouleaux[i].Tourner());
            }
            return results;
        }
        public int CalculerGain(List<string> results)
        {
            if (results[0] == results[1] && results[1] == results[2])
                return 50; // gain pour 3 numéros identiques
            else if (results[0] == results[1] || results[1] == results[2] || results[0] == results[2])
                return 20; // gain pour 2 numéros identiques
            return 0; // aucun gain
        }

        #endregion
    }
}
