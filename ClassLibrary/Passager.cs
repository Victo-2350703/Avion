using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    /// <summary>
    /// Représnte un passager
    /// </summary>
    public class Passager: Individu, IEquatable<Passager>, IComparable<Passager>
    {
        private double coordSiegeReserve;

        public Passager(string nom, double coordSiegeReserve): base (nom)
        {
            this.coordSiegeReserve = coordSiegeReserve;
        }






        /// <summary>
        /// Accseseur de coordonnée de siege
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Lance un exception sur 0 ou négatif</exception>
        public double CoordSiegeReserve 
        {
        get => coordSiegeReserve; 
        set
            {
                if(value  <= 0)
                {
                    throw new ArgumentOutOfRangeException("Les coordonée sur siege reserver ne peut être 0 ou négatif.");
                }
                coordSiegeReserve = value;
            }
        }


        /// <summary>
        /// Compare deux passager entre eux
        /// </summary>
        /// <param name="other">Un autre passager</param>
        /// <returns>retourn 0 non-égal retourn 1 si égale</returns>
        public int CompareTo(Passager? other)
        {
            if(other.CoordSiegeReserve != this.CoordSiegeReserve) 
            {
                return 0;
            }
            return 1;
        }

        
        /// <summary>
        /// Vérifer l'égalité entre deux passager
        /// </summary>
        /// <param name="other">un autre passager</param>
        /// <returns>retourn vrai si égale, sinon retourn faux</returns>
        public bool Equals(Passager? other)
        {
            if(other.coordSiegeReserve == this.CoordSiegeReserve) {  return true; }
            else { return false; }
        }
    }


}
