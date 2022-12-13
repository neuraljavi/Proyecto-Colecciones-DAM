using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoja10.Logica
{
    internal class Validar
    {
        public static bool noSonNull(List<String> validar)
        {
            bool correcto = true;
            foreach (String s in validar)
            {
                if (s.Length == 0)
                {
                    correcto = false;
                }
            }
            return correcto;
        }
    }
}
