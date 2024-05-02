using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    /// <summary>
    /// Réprésente une rangée
    /// </summary>
    public class Rangee: IEquatable<Rangee>, IComparable<Rangee>
    {
        private Section[] section;
        private int numerorange;


        /// <summary>
        /// Construit une rangée
        /// </summary>
        /// <param name="section">les deux section dans la rangé</param>
        /// <param name="numerorange">le numéro de la rangé qui n'est pas 0 ou négative</param>
        public Rangee(Section[] section, int numerorange)
        {
            this.Section = section[2];
            this.Numerorange = numerorange;
        }

        /// <summary>
        /// Compare une rangé avec un autre
        /// </summary>
        /// <param name="other">un autre rangée</param>
        /// <returns>1 si le numéro et la section sont égale sinon retourn 0</returns>
        /// <exception cref="NotImplementedException"></exception>
        public int CompareTo(Rangee? other)
        {
            if (other.numerorange == this.numerorange && other.section == this.section)
            {
                return 1;
            }
            return 0;
        }


        /// <summary>
        /// Vérifie l'égalité de la rangée
        /// </summary>
        /// <param name="other">un autre rangé</param>
        /// <returns>Retourne vrai si le numéro de rangé est égaux sinon retourn faux</returns>
        public bool Equals(Rangee? other)
        {
            if (other.numerorange == this.numerorange)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Accesseur du numéro de rangé
        /// </summary>
        public int Numerorange 
        {
           get => numerorange; 
           private set 
            {
                if(value == 0)
                {
                    throw new ArgumentException("Il n'y a pas de rangee 0 sur un avion.");
                }
                numerorange = value;
            }
        }
        /// <summary>
        /// Acceseur de la section
        /// </summary>
        internal Section Section 
        { 
         get => section[2];
            set 
            {
                if(value is null)
                {
                    throw new ArgumentNullException("La section ne peut être nulle.");
                }
                section[2] = value;
            }
        }



    }



}
