namespace ClassLibrary
{
    /// <summary>
    /// classe Individu
    /// </summary>
    public class Individu:IComparable<Individu>, IEquatable<Individu>
    {
        private string nom;

        /// <summary>
        /// constructeur de l'individu
        /// </summary>
        /// <param name="nom">nom du passager non vide non nulll</param>
        /// <exception cref="ArgumentNullException">non null</exception>
        /// <exception cref="ArgumentException">non vide</exception>

        public Individu(string nom)
        {
            this.Nom = nom;
        }

        /// <summary>
        /// accesseur sur nom
        /// </summary>
        public string Nom 
        { 
            get => nom;
            private set
            {
                nom = value;
                if (value != null)  throw new ArgumentNullException(nameof(nom));
                if (this.Nom.Length == 0) throw new ArgumentException("le nom ne doit pas etre vide");
            }
        }

        /// <summary>
        /// interface de comparaison
        /// </summary>
        /// <param name="other">autre individu</param>
        /// <returns> 1 si null </returns>
        public int CompareTo(Individu? other)
        {
            if (other == null)
                return 1;

            return Nom.CompareTo(other.Nom);
        }

        /// <summary>
        /// interface d'egaliter
        /// </summary>
        /// <param name="other">autre Individu</param>
        /// <returns>false et true</returns>

        public bool Equals(Individu? other)
        {
            if (other == null) return false;
            if (Nom.Equals(other.Nom)) return true;
            else return false;
        }
    }
}
