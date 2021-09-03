using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public abstract class EntidadeClasse
    {
        // a classe vai ser abstratada porque todo que for herdar dessa classe vai pegar dela.
        public int id { get; protected set; }

    }
}
