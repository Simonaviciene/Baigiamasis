using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentuDienynasLB
{
    public class StudentuRepozitorija
    {
        private List<Studentas> studentai;
        public StudentuRepozitorija()
        {
            studentai = new List<Studentas>();
            studentai.Add(new Studentas(1, "Martynas", "Martynaitis"));
            studentai[0].PridetiNaujaPamoka("Matieka");
            studentai[0].PridetiPazymi("Matieka", 1, 5);
            studentai[0].PridetiPazymi("Matieka", 2, 10);
            studentai[0].PridetiPazymi("Matieka", 3, 8);

            studentai[0].PridetiNaujaPamoka("Lietuviu");
            studentai[0].PridetiPazymi("Lietuviu", 1, 6);
            studentai[0].PridetiPazymi("Lietuviu", 2, 9);
            studentai[0].PridetiPazymi("Lietuviu", 3, 8);

            studentai.Add(new Studentas(2, "Sigitas", "Sigitinas"));
            studentai[1].PridetiNaujaPamoka("Psichologija");
            studentai[1].PridetiPazymi("Psichologija", 1, 4);
            studentai[1].PridetiPazymi("Psichologija", 2, 3);
            studentai[1].PridetiPazymi("Psichologija", 3, 5);

            studentai[1].PridetiNaujaPamoka("Lietuviu");
            studentai[1].PridetiPazymi("Lietuviu", 1, 9);
            studentai[1].PridetiPazymi("Lietuviu", 2, 9);
            studentai[1].PridetiPazymi("Lietuviu", 3, 7);

            studentai.Add(new Studentas(3, "Saulius", "Saulenas"));
            studentai[2].PridetiNaujaPamoka("Biologija");
            studentai[2].PridetiPazymi("Biologija", 1, 10);
            studentai[2].PridetiPazymi("Biologija", 2, 9);
            studentai[2].PridetiPazymi("Biologija", 3, 8);

            studentai[2].PridetiNaujaPamoka("Fizika");
            studentai[2].PridetiPazymi("Fizika", 1, 9);
            studentai[2].PridetiPazymi("Fizika", 2, 5);
            studentai[2].PridetiPazymi("Fizika", 3, 7);


            studentai.Add(new Studentas(4, "Zeofas", "Zeofilinas"));
            studentai[3].PridetiNaujaPamoka("Istorija");
            studentai[3].PridetiPazymi("Istorija", 1, 6);
            studentai[3].PridetiPazymi("Istorija", 2, 3);
            studentai[3].PridetiPazymi("Istorija", 3, 5);

            studentai[3].PridetiNaujaPamoka("Chemija");
            studentai[3].PridetiPazymi("Chemija", 1, 2);
            studentai[3].PridetiPazymi("Chemija", 2, 9);
            studentai[3].PridetiPazymi("Chemija", 3, 7);

            studentai.Add(new Studentas(5, "Kintauras", "Kintanavicius"));
            studentai[4].PridetiNaujaPamoka("Filosofija");
            studentai[4].PridetiPazymi("Filosofija", 1, 8);
            studentai[4].PridetiPazymi("Filosofija", 2, 3);
            studentai[4].PridetiPazymi("Filosofija", 3, 5);

            studentai[4].PridetiNaujaPamoka("Astrologija");
            studentai[4].PridetiPazymi("Astrologija", 1, 9);
            studentai[4].PridetiPazymi("Astrologija", 2, 9);
            studentai[4].PridetiPazymi("Astrologija", 3, 10);

            studentai.Add(new Studentas(6, "Elvyra", "Elvyrava"));
            studentai[5].PridetiNaujaPamoka("Geometrija");
            studentai[5].PridetiPazymi("Geometrija", 1, 8);
            studentai[5].PridetiPazymi("Geometrija", 2, 3);
            studentai[5].PridetiPazymi("Geometrija", 3, 4);

            studentai[5].PridetiNaujaPamoka("Braizyba");
            studentai[5].PridetiPazymi("Braizyba", 1, 9);
            studentai[5].PridetiPazymi("Braizyba", 2, 8);
            studentai[5].PridetiPazymi("Braizyba", 3, 10);

            studentai.Add(new Studentas(7, "Pijus", "Pijunaitis"));
            studentai[6].PridetiNaujaPamoka("Mechanika");
            studentai[6].PridetiPazymi("Mechanika", 1, 8);
            studentai[6].PridetiPazymi("Mechanika", 2, 3);
            studentai[6].PridetiPazymi("Mechanika", 3, 5);

            studentai[6].PridetiNaujaPamoka("Astrologija");
            studentai[6].PridetiPazymi("Astrologija", 1, 9);
            studentai[6].PridetiPazymi("Astrologija", 2, 9);
            studentai[6].PridetiPazymi("Astrologija", 3, 10);

        }
        public List<Studentas> Retrieve()
        {
            return studentai;
        }
        public Studentas Retrieve (int id)
        {
            foreach (var studentas in studentai)
            {
                if (studentas.StudentoId == id)
                    return studentas;
            }
            return null;
        }
        public void PridetiNaujaStudenta(int id, string vardas, string pavarde)
        {
            Studentas studentas = Retrieve(id);
            if (studentas == null)
            {
                studentai.Add(new Studentas(id, vardas, pavarde));
            }
            
        }
    }
    
}
