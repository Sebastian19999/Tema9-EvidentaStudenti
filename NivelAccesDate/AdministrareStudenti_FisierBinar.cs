using LibrarieModele;
using System;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //clasa AdministrareStudenti_FisierBinar implementeaza interfata IStocareData
    public class AdministrareStudenti_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareStudenti_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddStudent(Student s)
        {
            throw new Exception("Optiunea AddStudent nu este implementata");
        }

        public List<Student> GetStudenti()
        {
            throw new Exception("Optiunea GetStudenti nu este implementata");
        }
        public Student GetStudentByIndex(int index)
        {
            throw new Exception("Optiunea GetStudentByIndex nu este implementata");
        }

        public Student GetStudent(string nume, string prenume)
        {
            throw new Exception("Optiunea GetStudent nu este implementata");
        }

        public bool UpdateStudent(Student s)
        {
            throw new Exception("Optiunea UpdateStudent nu este implementata");
        }
    }
}
