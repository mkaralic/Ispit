using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Ljubimac
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Vrsta { get; set; }
        public decimal Cena { get; set; }
        public int NivoSrece { get; set; }
        public int NivoHrane { get; set; }
        public Prodavnica Prodavnica { get; set; }
        public Ljubimac() { 
        }

        public Ljubimac(int id, string ime, string vrsta, decimal cena, int nivoSrece, int nivoHrane, Prodavnica prodavnica)
        {
            Id = id;
            Ime = ime;
            Vrsta = vrsta;
            Cena = cena;
            NivoSrece = nivoSrece;
            NivoHrane = nivoHrane;
            Prodavnica = prodavnica;
        }
        public override string ToString()
        {
            return $"{Id} - {Ime} - {Vrsta} - {Cena} - {NivoSrece} - {NivoHrane}";
        }

        ~Ljubimac()
        {

        }
    }
}
