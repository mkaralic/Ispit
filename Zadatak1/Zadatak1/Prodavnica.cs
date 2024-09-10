using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Prodavnica
    {
        public List<Ljubimac> Ljubimci { get; set; }
        public Prodavnica()
        {
            Ljubimci = new List<Ljubimac>();
        }
        public Prodavnica(List<Ljubimac> ljubimci) { 
            Ljubimci = ljubimci;
        }
    }
}
