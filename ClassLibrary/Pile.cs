using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Pile<T> where T:IComparable<T>
    {
        private T[] lesValeurs;
        private int index;

        public Pile(int taille)
        {
            if (taille < 0) throw new ArgumentOutOfRangeException("buée");
            index = -1;
            lesValeurs = new T[taille];
        }

        public void Ajouter(T valeur) 
        {
            if (plein)
                throw new InvalidOperationException("pile pleine");

            lesValeurs[++index] = valeur;
        }

        public T Retirer() 
        {
            if (vide) throw new InvalidOperationException("pile vide");
            return lesValeurs[index--];
        }

        public bool plein
        {
            get { return index == lesValeurs.Length - 1; }
        }

        public bool vide 
        { 
            get 
            { 
                return index == -1; 
            } 
        }
    }
}
