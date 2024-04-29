using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// de beaux sieges
    /// </summary>
    public class Siege:IComparable<Siege>,IEquatable<Siege>
    {
        private int numSiege;

        /// <summary>
        /// creer de beaux sieges
        /// </summary>
        /// <param name="numSiege">numero de siege</param>
        public Siege(int numSiege)
        {
            this.NumSiege = numSiege;
        }

        /// <summary>
        /// interface de comparaison
        /// </summary>
        /// <param name="other">autre siege</param>
        /// <returns>1 si null</returns>
        public int CompareTo(Siege? other)
        {
            if (other == null) return 1;
            return NumSiege.CompareTo(other.NumSiege);
        }

        /// <summary>
        /// interface d'egualite
        /// </summary>
        /// <param name="other">autre siege</param>
        /// <returns>true ou false</returns>
        public bool Equals(Siege? other)
        {
            if (other == null) return false;
            if (NumSiege.Equals(other.NumSiege)) return true;
            else return false;
        }

        /// <summary>
        /// l'accesseur sur le numero de sieges
        /// </summary>
        public int NumSiege 
        { 
            get => numSiege;
            private set 
            { 
                numSiege = value;
                if (numSiege > 0) throw new ArgumentException("le numero de sieges ne doit etre negatif");
            }
        }

    }
}
