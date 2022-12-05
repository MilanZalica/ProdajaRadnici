using System;
using System.Collections.Generic;
using System.Text;

namespace Prodajaradnici
{
    public class Prodavac : Radnik
    {
        private double prihod;
        public Prodavac(string ime, double procenat) : base(ime, procenat) { }
        public void Prodao(double vrednost)
        {
            prihod += vrednost;
        }
        public override double Prihod
        {
            get { return prihod; }
        }
    }
}
