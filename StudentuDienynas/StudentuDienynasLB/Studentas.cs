using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentuDienynasLB
{
    public class Studentas
    {
        public int StudentoId { get; private set; }
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        private List<Pamoka> pamokuSarasas;

        public Studentas(int studentoId, string vardas, string pavarde)
        {
            StudentoId = studentoId;
            Vardas = vardas;
            Pavarde = pavarde;
            pamokuSarasas = new List<Pamoka>();
        }
        public void PridetiNaujaPamoka(string pamokosPavadinimas)
        {
           
            Pamoka pamoka = new Pamoka(pamokuSarasas.Count + 1, pamokosPavadinimas);
            pamokuSarasas.Add(pamoka);  
        }
        public List<Pamoka> Pamokos()
        {
            return pamokuSarasas;
        }
        public void PridetiPazymi(string pamokosPavadinimas, int trimestras, int pazymys)
        {
            foreach (var pamoka in pamokuSarasas)
            {
                if(pamoka.Pavadinimas == pamokosPavadinimas)
                {
                    if(trimestras == 1)
                    {
                        pamoka.PridetiPirmoTrimestroPazymi(pazymys);
                    }
                    else if(trimestras == 2)
                    {
                        pamoka.PridetiAntrotrimestroPazymi(pazymys);
                    }
                    else if(trimestras == 3)
                    {
                        pamoka.PridetiTrecioTrimestroPazymi(pazymys);
                    }
                    else
                    {
                        throw new System.ArgumentException(string.Format("Tokio trimestro {0} nera", trimestras));
                    }
                }
            }
        }
        public Pamoka GrazintiPamokaPagalPavadinima(string pamokosPavadinimas)
        {
            foreach (var pamoka in pamokuSarasas)
            {
                if (pamoka.Pavadinimas == pamokosPavadinimas)
                {
                    return pamoka;
                }
                    
            }
            return null;
        }
    }
    
}
