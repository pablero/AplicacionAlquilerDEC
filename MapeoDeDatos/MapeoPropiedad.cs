using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AlquileresDEC.Entidades;

namespace AlquileresDEC.Datos
{
    public class MapeoPropiedad
    {
        private readonly Conexion conexion;
        public MapeoPropiedad()
        {
            conexion = new Conexion();
        }
        
        //Cargar Listas
        public List<TipoPropiedad> cargar_lista_TiposPropiedad()
        {
            try
            {
                conexion.origen.Open();
                var ltp = new List<TipoPropiedad>();
                conexion.cmd = new SqlCommand("SELECT * from TipoPropiedad order by nombre", conexion.origen);
                conexion.dr1 = conexion.cmd.ExecuteReader();
                if (conexion.dr1.HasRows)
                {
                    while (conexion.dr1.Read())
                    {
                        var tp = new TipoPropiedad();
                        if (conexion.dr1["id_tipoPropiedad"] != DBNull.Value)
                        {
                            tp.Id_tipoPropiedad = Convert.ToInt32(conexion.dr1["id_tipoPropiedad"]);
                        }
                        if (conexion.dr1["nombre"] != DBNull.Value)
                        {
                            tp.Nombre = conexion.dr1["nombre"].ToString();
                        }

                        ltp.Add(tp);
                    }
                }
                conexion.origen.Close();
                return ltp;
            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                    conexion.origen.Close();                
                return null;
            }
        }

        public List<Localidad> cargar_lista_Localidades()
        {
            try
            {
                conexion.origen.Open();
                var lloc = new List<Localidad>();
                conexion.cmd = new SqlCommand("SELECT * from Localidad order by nombre", conexion.origen);
                conexion.dr1 = conexion.cmd.ExecuteReader();
                if (conexion.dr1.HasRows)
                {
                    while (conexion.dr1.Read())
                    {
                        var l = new Localidad();
                        if (conexion.dr1["id_localidad"] != DBNull.Value)
                        {
                            l.Id_localidad = Convert.ToInt32(conexion.dr1["id_localidad"]);
                        }
                        if (conexion.dr1["nombre"] != DBNull.Value)
                        {
                            l.Nombre = conexion.dr1["nombre"].ToString();
                        }

                        lloc.Add(l);
                    }
                }
                conexion.origen.Close();
                return lloc;
            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                    conexion.origen.Close();
                return null;
            }
        }
        public List<Barrio> cargar_lista_barrioXLocalidad(int id_localidad)
        {
            try
            {
                conexion.origen.Open();
                var listBarrio = new List<Barrio>();
                conexion.cmd =
                    new SqlCommand("SELECT * from barrio where id_localidad= " + id_localidad + " order by nombre",
                        conexion.origen);
                conexion.dr1 = conexion.cmd.ExecuteReader();
                if (conexion.dr1.HasRows)
                {
                    while (conexion.dr1.Read())
                    {
                        var b = new Barrio();
                        if (conexion.dr1["id_barrio"] != DBNull.Value)
                        {
                            b.Id_barrio = Convert.ToInt32(conexion.dr1["id_barrio"]);
                        }
                        if (conexion.dr1["nombre"] != DBNull.Value)
                        {
                            b.Nombre = conexion.dr1["nombre"].ToString();
                        }


                        listBarrio.Add(b);
                    }
                }
                conexion.origen.Close();
                return listBarrio;
            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                    conexion.origen.Close();                
                return null;
            }
        }
        public List<Estado> cargar_lista_Estado()
        {
            try
            {
                conexion.origen.Open();
                var les = new List<Estado>();
                conexion.cmd = new SqlCommand("SELECT * from Estado", conexion.origen);
                conexion.dr1 = conexion.cmd.ExecuteReader();
                if (conexion.dr1.HasRows)
                {
                    while (conexion.dr1.Read())
                    {
                        var es = new Estado();
                        if (conexion.dr1["id_estado"] != DBNull.Value)
                        {
                            es.Id_estado = Convert.ToInt32(conexion.dr1["id_estado"]);
                        }
                        if (conexion.dr1["nombre"] != DBNull.Value)
                        {
                            es.Nombre = conexion.dr1["nombre"].ToString();
                        }

                        les.Add(es);
                    }
                }
                conexion.origen.Close();
                return les;
            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                    conexion.origen.Close();
                return null;
            }
        }
        public List<Requisito> cargar_lista_Requisitos()
        {
            try
            {
                conexion.origen.Open();
                var lreq = new List<Requisito>();
                conexion.cmd = new SqlCommand("SELECT * from Requisito", conexion.origen);
                conexion.dr1 = conexion.cmd.ExecuteReader();
                if (conexion.dr1.HasRows)
                {
                    while (conexion.dr1.Read())
                    {
                        var req = new Requisito();
                        if (conexion.dr1["id_requisito"] != DBNull.Value)
                        {
                            req.Id_requisito = Convert.ToInt32(conexion.dr1["id_requisito"]);
                        }
                        if (conexion.dr1["nombre"] != DBNull.Value)
                        {
                            req.Nombre = conexion.dr1["nombre"].ToString();
                        }

                        lreq.Add(req);
                    }
                }
                conexion.origen.Close();
                return lreq;
            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                    conexion.origen.Close();
                return null;
            }
        }
        public List<Servicio> cargar_lista_Servicios()
        {
            try
            {
                conexion.origen.Open();
                var lss = new List<Servicio>();
                conexion.cmd = new SqlCommand("SELECT * from Servicio", conexion.origen);
                conexion.dr1 = conexion.cmd.ExecuteReader();
                if (conexion.dr1.HasRows)
                {
                    while (conexion.dr1.Read())
                    {
                        var ss = new Servicio();
                        if (conexion.dr1["id_servicio"] != DBNull.Value)
                        {
                            ss.Id_servicio = Convert.ToInt32(conexion.dr1["id_servicio"]);
                        }
                        if (conexion.dr1["nombre"] != DBNull.Value)
                        {
                            ss.Nombre = conexion.dr1["nombre"].ToString();
                        }

                        lss.Add(ss);
                    }
                }
                conexion.origen.Close();
                return lss;
            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                    conexion.origen.Close();
                return null;
            }
        }

        public DataSet consultarPropiedades()
        {
            conexion.origen.Open();
            conexion.ds = new DataSet();
        
            conexion.str_sql = @"SELECT TipoPropiedad.nombre AS Tipo, Localidad.nombre As Localidad, Barrio.nombre AS Barrio, Propiedad.direccion AS Dirección, Propiedad.piso AS Piso, Propiedad.nro_habitaciones AS Habitaciones, Propiedad.fecha_inauguracion AS Antiguedad, Estado.nombre AS Estado, Servicio.nombre AS Servicio, Requisito.nombre AS Requisito, Propiedad.precio AS Precio  
            FROM Propiedad, TipoPropiedad, Barrio, Estado, Localidad, Requisito, Servicio
            WHERE Propiedad.id_tipoPropiedad = TipoPropiedad.id_tipoPropiedad AND Propiedad.id_barrio = Barrio.id_barrio AND Barrio.id_localidad = Localidad.id_localidad AND Propiedad.id_estado = Estado.id_estado AND Propiedad.id_requisito = Requisito.id_requisito AND Propiedad.id_Servicio = Servicio.id_servicio";
            
            conexion.da = new SqlDataAdapter(conexion.str_sql, conexion.origen);
            conexion.da.Fill(conexion.ds, "Propiedades");

            conexion.origen.Close();
            return conexion.ds; 
        }
        
    }
}
