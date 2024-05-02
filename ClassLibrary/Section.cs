using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Section
    {
        private Siege[] _siege = new Siege[3];
        private int numSection;

        public Section(Siege[] siege, int numSection)
        {
            Sieges = siege;
            NumSection = numSection;
        }


        public Siege[] Sieges
        { 
            get => _siege;
            private set 
            { 
                _siege = value; 
                if (value != null)  throw new ArgumentNullException(nameof(value));
            }
        }

        public int NumSection 
        { 
            get => numSection;
            private set 
            { 
                numSection = value;
                if (value == null) throw new ArgumentNullException(nameof(value));
                if (numSection == 0) throw new ArgumentException("le numerode section ne doit pas etre vide");
            }
        }
    }
}
