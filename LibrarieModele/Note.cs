using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
public static class Note
{
    public const int NOTA_MINIMA = 1;
    public const int NOTA_MAXIMA = 10;
    public const bool NOTA_VALIDA = true;

        public static bool ValideazaNota(int nota)
    {
        if (nota >= NOTA_MINIMA && nota <= NOTA_MAXIMA)
            return NOTA_VALIDA;
        return !NOTA_VALIDA;
    }

        public static int[] ExtrageNoteDinSir(string sirNote)
        {
            string[] vectorNoteDupaSplit = sirNote.Split(' ');
            int[] note = new int[vectorNoteDupaSplit.Length];

            int nrNote = 0;
            foreach (var nota in vectorNoteDupaSplit)
            {
                bool rezultatConversie = Int32.TryParse(nota, out note[nrNote]);
                if (rezultatConversie == NOTA_VALIDA && ValideazaNota(note[nrNote]) == NOTA_VALIDA)
                {
                    nrNote++;
                }
            }

            Array.Resize(ref note, nrNote);
            return note;
        }
}
}
