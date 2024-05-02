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
    public class Siege : IComparable<Siege>, IEquatable<Siege>
    {
        private int coordSiegeReserve;
        private string classe;

        /// <summary>
        /// creer de beaux sieges
        /// </summary>
        /// <param name="coordSiegeReserve">les coordonne de siege reserver</param>
        public Siege(int coordSiegeReserve, string classe)
        {
            this.CoordSiegeReserve = coordSiegeReserve;
            this.Classe = classe;
        }

        /// <summary>
        /// interface de comparaison
        /// </summary>
        /// <param name="other">autre siege</param>
        /// <returns>1 si null</returns>
        public int CompareTo(Siege? other)
        {
            if (other == null) return 1;
            return CoordSiegeReserve.CompareTo(other.CoordSiegeReserve);
        }

        /// <summary>
        /// interface d'egualite
        /// </summary>
        /// <param name="other">autre siege</param>
        /// <returns>true ou false</returns>
        public bool Equals(Siege? other)
        {
            if (other == null) return false;
            if (CoordSiegeReserve.Equals(other.CoordSiegeReserve)) return true;
            else return false;
        }

        /// <summary>
        /// l'accesseur sur les coordonner de siege
        /// </summary>
        public int CoordSiegeReserve
        {
            get => coordSiegeReserve;
            private set
            {
                coordSiegeReserve = value;
                if (coordSiegeReserve > 0) throw new ArgumentException("les coordonne de siege ne doit pas etre negatif");
            }
        }

        public string Classe
        {
            get => classe;
            private set
            {
                classe = value;
                if (value != null) throw new ArgumentNullException(nameof(classe));
                if (this.Classe.Length == 0) throw new ArgumentException("la classe ne doit pas etre vide");
            }
        }
    }
}