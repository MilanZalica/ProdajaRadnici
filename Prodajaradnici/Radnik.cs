using System;
using System.Collections.Generic;
using System.Text;

namespace Prodajaradnici
{
    public abstract class Radnik
    {
        private string ime;
        private double procenat;
        protected Radnik(string i,double p)
        {
            ime = i;procenat = p;
        }
        public abstract double Prihod { get; }
        public double Plata
        { get { return Prihod * procenat / 100; } }
        public override string ToString()
        {
            return ime + "/" + Plata;
        }
    }
}
