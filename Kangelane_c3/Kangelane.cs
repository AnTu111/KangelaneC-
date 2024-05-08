using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Kangelane
    {

        private string _Nimi;
        private string _Asukoht;
        public Kangelane(string Nimi, string Asukoht)
        {
            this.Nimi = Nimi;
            this.Asukoht = Asukoht;
        }

        public string Nimi //свойство 
        {
            get { return _Nimi; } //методы.вызывается при попытке получить значение свойства Nimi.
                                  // возвращает значение приватного поля _Nimi.
            set
            {
                _Nimi = value;
            }
        }
        public string Asukoht 
        { 
            get { return _Asukoht; }

            set 
            { 
                _Asukoht = value; 
            }
        }
        public virtual int Päästa(int Ohustatuid) //переопределяется в производных классах
        {
            return (int)Math.Round(Ohustatuid * 0.95, 0);
        }
        public override string ToString()
        {
            return Nimi + " kaitseb " + Asukoht;
        }
    }
}