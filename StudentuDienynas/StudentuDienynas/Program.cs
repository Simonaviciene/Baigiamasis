using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentuDienynasLB;

namespace StudentuDienynas
{
    class Program
    {
        private const int VEIKSMAS_STUDENTU_PAMOKU_VALDYMAS = 1;
        private const int PRIDETI_PAZYMI = 1;
        private const int ISEITI_IS_PROGRAMOS = 0;
        private const int ISTRINTI_PAZYMI = 2;
        private const int PRIDETI_NAUJA_PAMOKA = 3;
        private const int ATASKAITOS_SUVESTINE = 2;
        private const int STUDENTU_VALDYMAS = 3;
        private const int PRIDETI_NAUJA_STUDENTA = 1;
        private const int STUDENTO_SUVESTINE = 2;


        static void Main(string[] args)
        {

            StudentuRepozitorija studentuRepozitorija = new StudentuRepozitorija();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Pasirinkite veiksma:");
                Console.WriteLine("[1] - Studentu pamoku valdymas");
                Console.WriteLine("[2] - Parodyti visu studentu suvestine");
                Console.WriteLine("[3] = Studentu Valdymas");
                Console.WriteLine("[0] = Iseiti");

                int veiksmas = Convert.ToInt32(Console.ReadLine());
                if (veiksmas == ISEITI_IS_PROGRAMOS)
                {
                    Environment.Exit(0);
                }
                else if (veiksmas == VEIKSMAS_STUDENTU_PAMOKU_VALDYMAS)
                {
                    Console.WriteLine("Pasirinkite veiksma:");
                    Console.WriteLine("[1] - Prideti pazymi");
                    Console.WriteLine("[2] - Istrinti pazymi");
                    Console.WriteLine("[3] = Prideti pamoka");

                    int pamokosVeiksmas = Convert.ToInt32(Console.ReadLine());

                    ParodytiStudentuSarasa(studentuRepozitorija.Retrieve());
                    Console.WriteLine("Pasirinkite studento Id:");
                    int studentoId = Convert.ToInt32(Console.ReadLine());
                    Studentas studentas = studentuRepozitorija.Retrieve(studentoId);
                    Console.WriteLine("Iveskite pamokos pavadinima:");
                    ParodytiStudentoPamokuSarasa(studentas);
                    string pamokosPavadinimas = Console.ReadLine();

                    if (pamokosVeiksmas == PRIDETI_PAZYMI)
                    {
                        Console.WriteLine("Iveskite trimestro Nr(1-3):");
                        int trimestroNr = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Iveskite pazymi(1-10):");
                        int pazymys = Convert.ToInt32(Console.ReadLine());
                        studentas.PridetiPazymi(pamokosPavadinimas, trimestroNr, pazymys);

                        Console.WriteLine("Pazymys pridetas {0}", pazymys);
                    }
                    else if(pamokosVeiksmas == ISTRINTI_PAZYMI)
                    {
                        Pamoka pamoka = studentas.GrazintiPamokaPagalPavadinima(pamokosPavadinimas);
                        Console.WriteLine("Iveskite trimestro Nr(1-3):");
                        int trimestroNr = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Iveskite pazymio eiles Nr:");
                        int pazymioEilesNr = Convert.ToInt32(Console.ReadLine());
                        pamoka.IstrintiPazymi(trimestroNr, pazymioEilesNr);

                        Console.WriteLine("Itrinta");

                    }
                    else if (pamokosVeiksmas == PRIDETI_NAUJA_PAMOKA)
                    {
                        studentas.PridetiNaujaPamoka(pamokosPavadinimas);
                        Console.WriteLine("Pamoka {0} prideta: ", pamokosPavadinimas);
                    }
                   
                    else
                    {
                        Console.WriteLine("Ivestas nezinomas skaicius {0}", pamokosVeiksmas);
                    }
                        


                }
                else if (veiksmas == ATASKAITOS_SUVESTINE)
                {
                    Console.WriteLine("Ataskaitos suvestine: ");

                    AtaskaituGeneratorius ataskaituGeneratorius = new AtaskaituGeneratorius(studentuRepozitorija);
                    List<SuvestinesAtaskaitosEilute> suvestinesAtaskaitosEilutes = ataskaituGeneratorius.StudentuSuvestine();
                    foreach (var eilute in suvestinesAtaskaitosEilutes)
                    {
                        Console.WriteLine("Studento Id: {0}", eilute.Id);
                        Console.WriteLine("Studento vardas pavarde: {0} {1}", eilute.Vardas, eilute.Pavarde);
                        Console.WriteLine("Pamokos pavadinimas: {0}", eilute.Pamoka);
                        Console.WriteLine("Trimestru suvestine: {0}, {1}, {2}", eilute.Trimestas1, eilute.Trimestas2, eilute.Trimestas3);
                        Console.WriteLine("Metinis: {0}\n", eilute.Metinis);
                        Console.WriteLine("***----------------------------------------------***");
                    }

                    
                }
                else if( veiksmas == STUDENTU_VALDYMAS)
                {
                    Console.WriteLine("Pasirinkite veiksma: ");
                    Console.WriteLine("[1] - prideti studenta");
                    Console.WriteLine("[2] - studento suvestine");

                    int studentuSarasoValdymoVeiksmas = Convert.ToInt32(Console.ReadLine());
                    if(studentuSarasoValdymoVeiksmas == PRIDETI_NAUJA_STUDENTA)
                    {
                        Console.WriteLine("Iveskite naujo studento Id:");
                        int naujoStudentoId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Iveskite naujo studento varda:");
                        string naujoStudentoVardas = Console.ReadLine();
                        Console.WriteLine("Iveskite naujo studento Pavarde:");
                        string naujoStudentoPavarde = Console.ReadLine();
                        studentuRepozitorija.PridetiNaujaStudenta(naujoStudentoId, naujoStudentoVardas, naujoStudentoPavarde);
                        Console.WriteLine("Naujas studentu sarasas:");
                        ParodytiStudentuSarasa(studentuRepozitorija.Retrieve());
                    }
                    
                    else if(studentuSarasoValdymoVeiksmas == STUDENTO_SUVESTINE)
                    {
                        ParodytiStudentuSarasa(studentuRepozitorija.Retrieve());
                        Console.WriteLine("Pasirinkite studento Id:");
                        int studentoId = Convert.ToInt32(Console.ReadLine());
                        AtaskaituGeneratorius ataskaituGeneratorius = new AtaskaituGeneratorius(studentuRepozitorija);
                        List<StudentoAtaskaitosEilute> studentoAtaskaitosEilutes = ataskaituGeneratorius.StudentoSuvestine(studentoId);

                        Console.Clear();
                        foreach (var eilute in studentoAtaskaitosEilutes)
                        {
                            Console.WriteLine("Pamokos pavadinimas: {0}", eilute.PamokosPavadinimas);
                            Console.WriteLine("Pirmo trimestro pazymiai: {0}, Vidurkis: {1}", eilute.Trimestro1Pazymiai, eilute.Trimestro1Vidurkis);
                            Console.WriteLine("Antro trimestro pazymiai: {0}, Vidurkis: {1}", eilute.Trimestro2Pazymiai, eilute.Trimestro2Vidurkis);
                            Console.WriteLine("Trecio trimestro pazymiai: {0}, Vidurkis: {1}", eilute.Trimestro3Pazymiai, eilute.Trimestro3Vidurkis);
                            Console.WriteLine("Metinis vidurkis: {0}", eilute.Metinis);

                            Console.WriteLine("***----------------------------------------------***");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ivestas nezinomas skaicius {0}", studentuSarasoValdymoVeiksmas);
                    }



                }

                else
                {
                    Console.WriteLine("Ivestas nezinomas skaicius {0}", veiksmas);
                }
                Console.WriteLine("Spauskite ENTER norint testi");
                Console.ReadLine();
            }

        }
        private static void ParodytiStudentuSarasa(List<Studentas> studentai)
        {
            List<Studentas> surusiuotiStudentai = studentai.OrderBy(stud => stud.StudentoId).ToList();
            foreach (var studentas in surusiuotiStudentai)
            {
                Console.WriteLine("{0}, {1}, {2}", studentas.StudentoId, studentas.Vardas, studentas.Pavarde);
            }
        }
        private static void ParodytiStudentoPamokuSarasa(Studentas studentas)
        {
            List<Pamoka> surusiuotosPamokos = studentas.Pamokos().OrderBy(pam => pam.Pavadinimas).ToList();
            foreach (var pamoka in surusiuotosPamokos)
            {
                Console.WriteLine("{0}, {1}", pamoka.ID, pamoka.Pavadinimas);

            }
        }
        
    }

}