using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefDobbelstenen
{
    class Dobbelsteen
    {
        private int _aantalZijden;
        private int _waarde;
        private Random _willGetal;

        public int AantalZijden { get => _aantalZijden; set => _aantalZijden = value; }
        public Random WillGetal { get => _willGetal; set => _willGetal = value; }
        public int Waarde { get => _waarde; set => _waarde = value; }

        public Dobbelsteen(int aantalZijden, Random r)
        {
            this.AantalZijden = aantalZijden;
            this.WillGetal = r;
        }

        public Dobbelsteen(Random r) : this (6, r) { }

        public void Roll()
        {
            this.Waarde = WillGetal.Next(1, AantalZijden);
        }
    }
}
