using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrakoplovVjezba
{
    internal class Zrakoplov
    {
        string Naziv;
        double SnagaMotora;
        int DosegLeta;

        public void setNaziv(string Naziv)
        {
            this.Naziv = Naziv;
        }


        public void setSnagaMotora(double SnagaMotora)
        {
            this.SnagaMotora = SnagaMotora;
        }

        public void setDosegLeta(int DosegLeta)
        {
            this.DosegLeta = DosegLeta;
        }

        public string getNaziv()
        {
            return this.Naziv;
        }

        public double getSnagaMotora()
        {
            return this.SnagaMotora;
        }

        public int getDosegLeta()
        {
            return this.DosegLeta;
        }

        public override string ToString()
        {
            string ispis = "Naziv: " + this.getNaziv() + "\n"
                + "Snaga motora: " + this.getSnagaMotora() + " kW\n"
                + "Doseg leta: " + this.getDosegLeta() + " km";
                
            return ispis;
        }

        public Zrakoplov(string Naziv, double SnagaMotora, int DosegLeta) 
        {
            this.Naziv = Naziv;
            this.SnagaMotora = SnagaMotora;
            this.DosegLeta = DosegLeta;
        }

        public Zrakoplov() { }
    }
}
