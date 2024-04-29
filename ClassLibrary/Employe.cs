using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// un pilote
    /// </summary>
    public class Employe:Individu,IComparable<Employe>,IEquatable<Employe>
    {
        private int poste;

        /// <summary>
        /// genere un pilote
        /// </summary>
        /// <param name="nom">nom du pilote</param>
        /// <param name="poste">poste dans l'equipage</param>
        public Employe(string nom, int poste ) : base (nom)
        {
            this.Poste = poste;
        }
        
        /// <summary>
        /// interface de comparaison
        /// </summary>
        /// <param name="other">autre employe</param>
        /// <returns>la comparaison</returns>
        public int CompareTo(Employe? other)
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
        public bool Equals(Employe? other)
        {
            if (other == null) return false;
            if (Nom.Equals(other.Nom))
            { 
                if(Poste.Equals(other.Poste)) return true;
                else return false;
            }
            else return false;
        } 
        
        /// <summary>
        /// acceasseur sur experience
        /// </summary>
        public int Poste
        { 
            get => poste;
            private set { poste = value; if(value < 0) throw new ArgumentException("l'experiance ne doit pas etre negatif");}
        }
    }
}
