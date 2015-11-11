using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlquileresDEC.Entidades
{
    public class Propiedad
    {
        public int Id_propiedad { set; get; }
        public string Direccion { set; get; }
        public int Id_barrio { set; get; }
        public DateTime FechaIng { set; get; }
        public byte[] foto;
        public int NroHabitaciones { set; get; }
        public int Id_estado { set; get; }
        public int Piso { set; get; }
        public char Depto { set; get; }
        public int Id_servicio { set; get; }
        public int Id_requisito { set; get; }
        public double Precio { set; get; }
        public string Descripcion { set; get; }
        public int Id_tipoPropiedad { set; get; }
    }

}
