using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banditmanchot.Modeles
{
    internal class Rouleau
    {
        #region Attributs

        public static List<Rouleau> CollClasse = new List<Rouleau>();
        private static readonly Random rnd = new Random();
        private readonly List<string> symboles = new List<string> { "🍎", "🍒", "🍇", "🍋", "🍉", "🔔", "⭐", "7️⃣" };

        #endregion

        #region Constructeurs

        public Rouleau()
        {
            Rouleau.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        #endregion

        #region Methodes
        public string Tourner()
        {
            return symboles[rnd.Next(symboles.Count)];
        }
        #endregion
    }
}
