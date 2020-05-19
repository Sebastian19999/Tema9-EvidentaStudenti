using System;
using System.Collections.Generic;

namespace LibrarieModele
{
    public class Student
    {
        //constante

        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        //data membra privata
        int[] note;

        //proprietati auto-implemented
        public int IdStudent { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string NumeComplet { get { return Nume + " " + Prenume; } }

        public ProgramStudiu ProgramSTD { get; set; }

        public List<string> Discipline { get; set; }

        public int AnStudiu { get; set; }

        public string DisciplineAsString
        {
            get
            {
                string sDiscipline = string.Empty;

                foreach (string disciplina in Discipline)
                {
                    if (sDiscipline != string.Empty)
                    {
                        sDiscipline += SEPARATOR_SECUNDAR_FISIER;
                    }
                    sDiscipline += disciplina;
                }

                return sDiscipline;
            }
        }

        public float Media
        {
            get
            {
                float media = 0;
                foreach(var nota in note)
                {
                    media += nota;
                }
                return media / note.Length;
            }
        }

        #region _Constructori_
        //contructor implicit
        public Student()
        {
            Nume = Prenume = string.Empty;
        }

        //constructor1 cu parametri
        public Student(string _nume, string _prenume)
        {
            Nume = _nume;
            Prenume = _prenume;
        }

        //constructor2 cu parametri
        public Student(string _nume, string _prenume, int[] _note)
        {
            Nume = _nume;
            Prenume = _prenume;
            note = new int[_note.Length];
            _note.CopyTo(note, 0);
        }

        //constructor3 cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Student(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ToString()
            IdStudent = Convert.ToInt32(dateFisier[(int)CampuriStudent.ID]);
            Nume = dateFisier[(int)CampuriStudent.NUME];
            Prenume = dateFisier[(int)CampuriStudent.PRENUME];
            ProgramSTD = (ProgramStudiu)Enum.Parse(typeof(ProgramStudiu), dateFisier[(int)CampuriStudent.PROG_STUDIU]);
            Discipline = new List<string>();
            //adauga mai multe elemente in lista de discipline
            Discipline.AddRange(dateFisier[(int)CampuriStudent.DISCIPLINE].Split(SEPARATOR_SECUNDAR_FISIER));
            SetNote(dateFisier[(int)CampuriStudent.NOTE]);
            AnStudiu = Int32.Parse(dateFisier[(int)CampuriStudent.AN_STUDIU]);
        }

        #endregion


        //utilizare metoda statica din clasa statica
        public void SetNote(string sirNote)
        {
            note = Note.ExtrageNoteDinSir(sirNote);
        }
		
		public void SetNote(int[] _note)
        {
            note = new int[_note.Length];
            _note.CopyTo(note, 0);
        }
		public int[] GetNote()
        {
            // returneaza o copie a vectorului, astfel incat utilizatorii acestei librarii 
            // sa nu poata modifica continutul vectorului
            return (int[])note.Clone();
        }
        public string ConversieLaSir()
        {
            string sNote = "Nu exista (Nu ati apelat metoda setNote)";
            if (note != null)
            {
                sNote = string.Join(",", note);
            }
            string s = string.Format("Studentul cu Id: #{0} si numele: \"{1} {2}\", programul de studiu {3}, an studiu {6}, are notele:.... {4} la disciplinele {5}", IdStudent, (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "), ProgramSTD, sNote, DisciplineAsString, AnStudiu);
            return s;
        }

        public string ConversieLaSir_PentruFisier()
        {
            string sNote = string.Empty;
            
            if (note != null)
            {
                sNote = string.Join(SEPARATOR_AFISARE, note);
            }
           
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}",
                SEPARATOR_PRINCIPAL_FISIER, IdStudent.ToString(), (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "), ProgramSTD, DisciplineAsString, sNote, AnStudiu);

            return s;
        }
    }
}
