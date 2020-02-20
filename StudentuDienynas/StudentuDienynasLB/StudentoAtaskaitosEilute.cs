using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentuDienynasLB
{
    public class StudentoAtaskaitosEilute
    {
        public string PamokosPavadinimas { get; private set; }
        public string Trimestro1Pazymiai { get; private set; }
        public string Trimestro2Pazymiai { get; private set; }
        public string Trimestro3Pazymiai { get; private set; }
        public int Trimestro1Vidurkis { get; private set; }
        public int Trimestro2Vidurkis { get; private set; }
        public int Trimestro3Vidurkis { get; private set; }
        public int Metinis { get; private set; }

        public StudentoAtaskaitosEilute(string pamokosPavadinimas, string trimestro1Pazymiai, string trimestro2Pazymiai, string trimestro3Pazymiai, int trimestro1Vidurkis, int trimestro2Vidurkis, int trimestro3Vidurkis, int metinis)
        {
            PamokosPavadinimas = pamokosPavadinimas;
            Trimestro1Pazymiai = trimestro1Pazymiai;
            Trimestro2Pazymiai = trimestro2Pazymiai;
            Trimestro3Pazymiai = trimestro3Pazymiai;
            Trimestro1Vidurkis = trimestro1Vidurkis;
            Trimestro2Vidurkis = trimestro2Vidurkis;
            Trimestro3Vidurkis = trimestro3Vidurkis;
            Metinis = metinis;
        }


    }
}
