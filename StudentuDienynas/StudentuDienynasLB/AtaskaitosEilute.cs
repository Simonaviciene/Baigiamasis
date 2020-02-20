using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentuDienynasLB
{
    public class SuvestinesAtaskaitosEilute
    {
        public int Id { get; private set; }
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public string Pamoka { get; private set; }
        public int Trimestas1 { get; private set; }
        public int Trimestas2 { get; private set; }
        public int Trimestas3 { get; private set; }
        public int Metinis { get; private set; }

        public SuvestinesAtaskaitosEilute(int id, string vardas, string pavarde, string pamoka, int trimestas1, int trimestas2, int trimestas3, int metinis)
        {
            Id = id;
            Vardas = vardas;
            Pavarde = pavarde;
            Pamoka = pamoka;
            Trimestas1 = trimestas1;
            Trimestas2 = trimestas2;
            Trimestas3 = trimestas3;
            Metinis = metinis;
        }



    }
}
