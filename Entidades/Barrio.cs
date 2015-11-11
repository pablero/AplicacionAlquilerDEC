using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlquileresDEC.Entidades
{
    public class Barrio
    {
        public int Id_barrio { set; get; }
        public string Nombre { set; get; }
        public int Calificacion { set; get; }
        public int Id_localidad { set; get; }
    }
}
