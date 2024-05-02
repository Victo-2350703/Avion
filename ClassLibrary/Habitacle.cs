using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary

{
    /// <summary>
    /// Représente un habitacle
    /// </summary>
    public class Habitacle: IEquatable<Habitacle>, IComparable<Habitacle>
    {
<<<<<<< HEAD
=======
        private Rangee[] rangee;

        /// <summary>
        /// construit un habitacle
        /// </summary>
        /// <param name="rangee"></param>

        public Habitacle(Rangee[] rangee)
        {
            Rangee = rangee;
        }


        /// <summary>
        /// Compare un habitacle
        /// </summary>
        /// <param name="other">un autre habitacle</param>
        /// <returns>retourn 1 sir la rangee est la même sinon retourn 0</returns>
        public int CompareTo(Habitacle? other)
        {
            if (this.rangee == other.rangee)
            {
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// Vérifier l'égalité d'un habitacle
        /// </summary>
        /// <param name="other">un autre habitacle</param>
        /// <returns>vrai si la rangée est la même sinon faux</returns>
        public bool Equals(Habitacle? other)
        {
            if(this.rangee == other.rangee)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Accseseur de rangée
        /// </summary>
        public Rangee[] Rangee 
        {
            get => rangee;
            private set
            {
                if(rangee is null) 
                {
                    throw new ArgumentNullException("Une rangée ne peut être nulle");
                }
                rangee = value;
            }
        }
>>>>>>> daed78fe9bb43d30d7d8f8e16f2f2b428ccb3417

    }


}
