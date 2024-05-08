using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Kangelased
{
    class SuperKangelane : Kangelane
    {
        private static readonly Random rand = new Random();
        private double Osavus = Math.Round((rand.NextDouble() * 4) + 1);
        public double _Osavus
        {
            get { return Osavus; }
            set { Osavus = value; }
        }

        public SuperKangelane(string Nimi, string Asukoht) : base(Nimi, Asukoht) //пердает классу Kangelane
        {
        }
        public override int Päästa(int ohustatuid)
        {
            return (int)Math.Round((95 + _Osavus) / 100 * ohustatuid, 0);
        }

        public override string ToString()
        {
            return base.ToString() + " ja ta on selles " + _Osavus + " protsenti parem kui lihtsalt kangelased";
        }
    }
}