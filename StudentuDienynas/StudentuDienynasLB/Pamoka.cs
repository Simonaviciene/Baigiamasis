using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentuDienynasLB
{
    public class Pamoka
    {
        public int ID { get; private set; }
        public string Pavadinimas { get; private set; }
        private List<int> pazymiai1Trimestras;
        private List<int> pazymiai2Trimestras;
        private List<int> pazymiai3Trimestras;

        public Pamoka(int iD, string pavadinimas)
        {
            ID = iD;
            Pavadinimas = pavadinimas;
            this.pazymiai1Trimestras = new List<int>();
            this.pazymiai2Trimestras = new List<int>();
            this.pazymiai3Trimestras = new List<int>();
        }
        public int PirmoTrimestroVidurkis()
        {
            if (pazymiai1Trimestras.Count == 0) 
            {
                return 0;
            }
            int suma = pazymiai1Trimestras.Sum();
            int vidurkis = suma / pazymiai1Trimestras.Count;

            return vidurkis;

        }
        public int AntroTrimestroVidurkis()
        {
            if (pazymiai2Trimestras.Count == 0)
            {
                return 0;
            }
            int suma = pazymiai2Trimestras.Sum();
            int vidurkis = suma / pazymiai2Trimestras.Count;

            return vidurkis;
        }
        public int TrecioTrimestroVidurkis()
        {
            if (pazymiai3Trimestras.Count == 0)
            {
                return 0;
            }
            int suma = pazymiai3Trimestras.Sum();
            int vidurkis = suma / pazymiai3Trimestras.Count;

            return vidurkis;
        }
        public int MetinisVidurkis()
        {
            int metinisVidurkis = (PirmoTrimestroVidurkis() + AntroTrimestroVidurkis() + TrecioTrimestroVidurkis()) / 3;
            return metinisVidurkis;
        }

        public void PridetiPirmoTrimestroPazymi(int pazymys)
        {
            if (pazymys <= 0 || pazymys > 10)
            {
                return;
            }
            pazymiai1Trimestras.Add(pazymys);
        }
        public void PridetiAntrotrimestroPazymi(int pazymys)
        {
            if (pazymys <= 0 || pazymys > 10)
            {
                return;
            }
            pazymiai2Trimestras.Add(pazymys);
        }
        public void PridetiTrecioTrimestroPazymi(int pazymys)
        {
            if (pazymys <= 0 || pazymys > 10)
            {
                return;
            }
            pazymiai3Trimestras.Add(pazymys);
        }
        
        
        public void IstrintiPazymi(int trimestroNr, int pazymioEilesNr)
        {
            if (trimestroNr == 1)
            {
                pazymiai1Trimestras.RemoveAt(pazymioEilesNr);
            }
            else if (trimestroNr == 2)
            {
                pazymiai2Trimestras.RemoveAt(pazymioEilesNr);
            }
            else if (trimestroNr == 3)
            {
                pazymiai3Trimestras.RemoveAt(pazymioEilesNr);
            }
            else
            {
                throw new System.ArgumentException(string.Format("Tokio pazymio eiles numerio {0} nera", pazymioEilesNr));
            }

        }
        public List<int> GrazintiTrimestroPazymius(int trimestroNr)
        {
            if(trimestroNr == 1)
            {
                return pazymiai1Trimestras;
            }
            if (trimestroNr == 2)
            {
                return pazymiai2Trimestras;
            }
            if (trimestroNr == 3)
            {
                return pazymiai3Trimestras;
            }
            else
            {
                throw new System.ArgumentException(string.Format("Nebuna tokio trimestro {0}", trimestroNr));
            }
        }
    }
}
