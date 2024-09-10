using System.Security.Cryptography;

namespace Zadatak1
{
    internal class Program
    {
        private static Prodavnica _prodavnica;
        private static List<Ljubimac> _prodatiLjubimci;
        static void Main(string[] args)
        {
            _prodavnica = new Prodavnica();
            _prodavnica.Ljubimci = new List<Ljubimac>
            {
                new Ljubimac (1, "Maca 1", "macka", 50, 25, 70, _prodavnica),
                new Ljubimac (2, "Maca 2", "macka", 65, 32, 70, _prodavnica),
                new Ljubimac (3, "Maca 3", "macka", 150, 27, 70, _prodavnica),
                new Ljubimac (4, "Pas 1", "macka", 250, 70, 85, _prodavnica),
                new Ljubimac (5, "Pas 2", "macka", 70, 15, 85, _prodavnica),
                new Ljubimac (6, "Pas 3", "macka", 140, 65, 85, _prodavnica)
            };
            _prodatiLjubimci = new List<Ljubimac>();
            var cmd = "";
            do
            {
                try
                {
                    StampajTabelu();
                    Console.Write("Unesite komandu: ");
                    cmd = Console.ReadLine();
                    IzvrsiKomandu(cmd);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Greska: " + ex.Message);
                }

            } while (cmd.ToLower() != "kraj");

            int Power(int number, int power)
            {
                if (!(number != 0 && power >= 0))
                    throw new ArgumentException("Broj mora biti razlicit od nule i stepen pozitivan ili jednak nuli!");
                return (int)Math.Pow(number, power);
            }

        }

        private static void IzvrsiKomandu(string? cmd)
        {
            var cmdParts = cmd.Split(" ");
            var imeKomande = cmdParts[0].ToLower();
            var parametar = cmdParts.Length > 1 ? cmdParts[1] : "";
            switch (imeKomande)
            {
                case "sold":
                    ProdajLjubimca(Convert.ToInt32(parametar));
                    break;
                case "sales":
                    PrikaziSpisakProdaje();
                    break;
                case "kraj":
                    break;
                default:
                    Console.WriteLine("Nepostojeca komanda");
                    break;
            }
        }

        private static void PrikaziSpisakProdaje()
        {
            Console.WriteLine("PRODATI LJUBIMCI");
            foreach (var prodatiLjubimac in _prodatiLjubimci)
            {
                Console.WriteLine($"{prodatiLjubimac.Ime} - {prodatiLjubimac.Vrsta} - {prodatiLjubimac.Cena}");
            }
            Console.WriteLine("---------------------");
            var svega = _prodatiLjubimci.Sum(lj => lj.Cena);
            Console.WriteLine($"SVEGA: {svega}");
        }

        private static void ProdajLjubimca(int id)
        {
            var zaProdaju = _prodavnica.Ljubimci.Find(lj => lj.Id == id);

            if (zaProdaju == null) return;

            _prodatiLjubimci.Add(zaProdaju);
            _prodavnica.Ljubimci.Remove(zaProdaju);
        }

        private static void StampajTabelu()
        {
            Console.WriteLine("Ljubimci");
            Console.WriteLine("--------");
            foreach (var ljubimac in _prodavnica.Ljubimci.Where(lj => lj.NivoSrece < 30 || lj.NivoHrane < 30))
            {
                Console.WriteLine(ljubimac.ToString());
            }
            Console.WriteLine("--------");
            foreach (var ljubimac in _prodavnica.Ljubimci.Where(lj => lj.NivoSrece >= 30 && lj.NivoHrane >= 30))
            {
                Console.WriteLine(ljubimac.ToString());
            }
            Console.WriteLine("--------");
        }
    }
}
