using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// un membre d'equipage
    /// </summary>
    public class Equipage : Individu, IComparable<Equipage>, IEquatable<Equipage>
    {
        private string poste;

        /// <summary>
        /// genere un employe
        /// </summary>
        /// <param name="nom">nom du pilote</param>
        /// <param name="poste">poste dans l'equipage</param>
        public Equipage(string nom, string poste) : base(nom)
        {
            this.Poste = poste;
        }

        /// <summary>
        /// interface de comparaison
        /// </summary>
        /// <param name="other">autre employe</param>
        /// <returns>la comparaison</returns>
        public int CompareTo(Equipage? other)
        {
            if (other == null)
                return 1;
            return Poste.CompareTo(other.Poste);
        }

        /// <summary>
        /// interface d'egualiter
        /// </summary>
        /// <param name="other">autre employe</param>
        /// <returns> retourne vrai ou faux</returns>
        public bool Equals(Equipage? other)
        {
            if (other == null) return false;
            if (Nom.Equals(other.Nom))
            {
                if (Poste.Equals(other.Poste)) return true;
                else return false;
            }
            else return false;
        }

        /// <summary>
        /// accesseur sur experience
        /// </summary>
        public string Poste
        {
            get => poste;
            private set
            {
                poste = value;

                if (value != null) throw new ArgumentNullException(nameof(poste));
                if (this.Poste.Length == 0) throw new ArgumentException("le poste ne doit pas etre vide");
            }
        }
    }
}