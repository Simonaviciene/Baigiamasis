using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentuDienynasLB
{
    public class AtaskaituGeneratorius
    {
        private StudentuRepozitorija studentuRepozitorija;

        public AtaskaituGeneratorius(StudentuRepozitorija studentuRepozitorija)
        {
            this.studentuRepozitorija = studentuRepozitorija;
        }
        public List<SuvestinesAtaskaitosEilute> StudentuSuvestine()
        {
            List<SuvestinesAtaskaitosEilute> ataskaita = new List<SuvestinesAtaskaitosEilute>();
            List<Studentas> studentai = studentuRepozitorija.Retrieve();
            foreach (var studentas in studentai)
            {
                int studentoId = studentas.StudentoId;
                string vardas = studentas.Vardas;
                string pavarde = studentas.Pavarde;

                List<Pamoka> pamokos = studentas.Pamokos();
                foreach (var pamoka in pamokos)
                {
                    string pamokosPavadinimas = pamoka.Pavadinimas;
                    int pirmoTrimestroVidurkis = pamoka.PirmoTrimestroVidurkis();
                    int antroTrimestroVidurkis = pamoka.AntroTrimestroVidurkis();
                    int trecioTrimestroVidurkis = pamoka.TrecioTrimestroVidurkis();
                    int metinis = pamoka.MetinisVidurkis();

                    SuvestinesAtaskaitosEilute ataskaitosEilute = new SuvestinesAtaskaitosEilute(
                        studentoId, 
                        vardas, 
                        pavarde, 
                        pamokosPavadinimas, 
                        pirmoTrimestroVidurkis, 
                        antroTrimestroVidurkis, 
                        trecioTrimestroVidurkis, 
                        metinis);

                    ataskaita.Add(ataskaitosEilute);
                }
            }
            return ataskaita;
        }
        public List<StudentoAtaskaitosEilute> StudentoSuvestine(int studentoId)
        {
            List<StudentoAtaskaitosEilute> studentoAtaskaita = new List<StudentoAtaskaitosEilute>();
            Studentas studentas = studentuRepozitorija.Retrieve(studentoId);
           

            List<Pamoka> pamokos = studentas.Pamokos();
            foreach (var pamoka in pamokos)
            {
                string pamokosPavadinimas = pamoka.Pavadinimas;
                string pirmoTrimestroPazymiai = string.Join(",", pamoka.pazymiai1Trimestras.Select(n => n.ToString()).ToArray());
                string antroTrimestroPazymiai = string.Join(",", pamoka.pazymiai2Trimestras.Select(n => n.ToString()).ToArray());
                string trecioTrimestroPazymiai = string.Join(",", pamoka.pazymiai3Trimestras.Select(n => n.ToString()).ToArray());
                int pirmoTrimestroVidurkis = pamoka.PirmoTrimestroVidurkis();
                int antroTrimestroVidurkis = pamoka.AntroTrimestroVidurkis();
                int trecioTrimestroVidurkis = pamoka.TrecioTrimestroVidurkis();
                int metinis = pamoka.MetinisVidurkis();

            }
                return null;
        }
    }
}
