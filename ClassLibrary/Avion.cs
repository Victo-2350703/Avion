using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Avion:Habitacle,IComparable<Avion>,IEquatable<Avion>
    {
        private string model;

        public Avion(string model, Rangee[] rangee):base(rangee)
        {
            this.Model = model; 
        }


        public int CompareTo(Avion? other)
        {
            if (other == null) return 1;
            return Model.CompareTo(other.Model);
        }


        public bool Equals(Avion? other)
        {
            if (other == null) return false;
            return Model.Equals(other.Model);
        }

        public string Model 
        { 
            get => model;
            private set 
            { 
                model = value ?? throw new ArgumentNullException(nameof(model));
            } 
        }
    }
}
