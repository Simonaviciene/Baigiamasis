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
           // studentai.Add(new Studentas(1, "Martynas", "Martynaitis", new List<String> { }));
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
    }
    
}
