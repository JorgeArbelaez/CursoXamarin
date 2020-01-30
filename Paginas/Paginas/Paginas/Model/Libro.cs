using System;
using System.Collections.Generic;
using System.Text;

namespace Paginas.Model
{
    class Libro
    {
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public override string ToString()
        {
            return $"{Nombre}, {Autor}, {Editorial}";
        }
    }
}
