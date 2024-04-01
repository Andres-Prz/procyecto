using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace gruposInvestigacion
{
    internal class OPersona
    {

        public int idPersona {  get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string genero { get; set;}

        public OPersona() { }

        public OPersona(int idPersona, string nombre, int edad, string genero)
        {
            this.idPersona = idPersona;
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
        }
    }
}