using LibrarieModele;
using System.Collections.Generic;

namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddStudent(Student s);
        List<Student> GetStudenti();
        Student GetStudentByIndex(int index);
        
        Student GetStudent(string nume, string prenume);

        bool UpdateStudent(Student s);
    }
}
