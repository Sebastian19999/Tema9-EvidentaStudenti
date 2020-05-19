using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfataUtilizator
{
    [Flags]
    public enum CodEroare
    {
        CORECT = 0,
        NUME_INCORECT = 1,
        PRENUME_INCORECT = 2,
        NOTE_INCORECTE = 4,
        NO_PROGRAM_STUDIU = 8,
        DISCIPLINE_NOTE = 16
    }
}
