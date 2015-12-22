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
        //Verificar que no exista ya la propiedad cargada.
        public string ExistePropiedad(Propiedad p)
        {
            try
            {
                conexion.origen.Open();
                conexion.ds = new DataSet();
                var direccion = p.Direccion;
                var piso = p.Piso;
                var depto = p.Depto;
                conexion.str_sql="select * from Propiedad where direccion='"+direccion+"' and piso="+piso+" and depto='"+depto+"'";
                conexion.da = new SqlDataAdapter(conexion.str_sql, conexion.origen);
                conexion.da.Fill(conexion.ds, "Propiedades");
                var test = conexion.ds.Tables[0].Rows[0][0].ToString();
                return "Existe Propiedad";
                //return "No Existe Propiedad";
            }       

            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                    conexion.origen.Close();
                return "No Existe Propiedad";
            }
        }
        //Registrar una Nueva Propiedad
        public string RegistrarPropiedad(Propiedad p)
        {
            conexion.origen.Open();
            try
            {
                conexion.str_sql = "insert into Propiedad (direccion,id_barrio,fecha_inauguracion,foto,nro_habitaciones,id_estado,piso,depto,id_servicio,id_requisito,precio,descripcion,id_tipoPropiedad) values (@direccion,@id_barrio,@fecha_inauguracion,@foto,@nro_habitaciones,@id_estado,@piso,@depto,@id_servicio,@id_requisito,@precio,@descripcion,@id_tipoPropiedad)";
                conexion.cmd = new SqlCommand(conexion.str_sql, conexion.origen);
                //Parámetros
                conexion.cmd.Parameters.Add("@direccion",p.Direccion);
                conexion.cmd.Parameters.Add("@id_barrio", p.Id_barrio);
                conexion.cmd.Parameters.Add("@fecha_inauguracion", p.FechaIng);                
                if (p.foto != null)
                {
                    //conexion.cmd.Parameters.Add("@foto", p.foto); 
                    conexion.cmd.Parameters.Add(new SqlParameter("@foto", SqlDbType.Image) { Value = p.foto });
                }

                else
                { 
                    //conexion.cmd.Parameters.Add("@foto", DBNull.Value); 
                    conexion.cmd.Parameters.Add(new SqlParameter("@foto", SqlDbType.Image) { Value = DBNull.Value });
                }
                conexion.cmd.Parameters.Add("@nro_habitaciones", p.NroHabitaciones);
                conexion.cmd.Parameters.Add("@id_estado", p.Id_estado);
                if (p.Piso != 0)
                    conexion.cmd.Parameters.Add("@piso", p.Piso);                    
                else
                    conexion.cmd.Parameters.Add("@piso", DBNull.Value);
                if (p.Depto != 'ñ')
                    conexion.cmd.Parameters.Add("@depto", p.Depto);
                else
                    conexion.cmd.Parameters.Add("@depto", DBNull.Value);

                conexion.cmd.Parameters.Add("@id_servicio", p.Id_servicio);
                conexion.cmd.Parameters.Add("@id_requisito", p.Id_requisito);
                conexion.cmd.Parameters.Add("@precio", p.Precio);
                if(p.Descripcion !="")
                    conexion.cmd.Parameters.Add("@descripcion", p.Descripcion);
                else
                    conexion.cmd.Parameters.Add("@descripcion",DBNull.Value);
                conexion.cmd.Parameters.Add("@id_tipoPropiedad", p.Id_tipoPropiedad);

                conexion.cmd.ExecuteNonQuery();
                conexion.origen.Close();
                return "Guardado";
            }
            catch(Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                    conexion.origen.Close();
                return "Error al Guardar";
            }
        }

        
        public dtoPropiedad2 ConsultarPropiedadSinFiltros()
        {
            dtoPropiedad2 propiedad = new dtoPropiedad2();
            try
            {
                conexion.origen.Open();
                //conexion.ds = new DataSet();
                conexion.str_sql =
                    @"select p.id_propiedad,tp.nombre as TipoPropiedad,p.direccion as Dirección, b.nombre as Barrio, l.nombre as Localidad, p.nro_habitaciones as NroHab,p.piso as Piso,p.depto as Depto,
                         p.precio as Precio, e.nombre as Estado, s.nombre as Servicios, r.nombre as Requisitos,cast(datediff(dd,p.fecha_inauguracion,GETDATE()) / 365.25 as int)as AñosAntigüedad, b.calificacion as CriterioBarrio, e.calificacion as CriterioEstado, s.calificacion as CriterioServicio, r.calificacion as CriterioRequisito from Propiedad p, Barrio b, Localidad l,TipoPropiedad tp, Estado e, Servicio s, Requisito r
                         where p.id_tipoPropiedad=tp.id_tipoPropiedad and p.id_barrio=b.id_barrio and b.id_localidad=l.id_localidad and p.id_estado=e.id_estado and p.id_servicio=s.id_servicio and p.id_requisito=r.id_requisito";
                conexion.cmd = new SqlCommand(conexion.str_sql, conexion.origen);
                conexion.da = new SqlDataAdapter(conexion.cmd);
                //conexion.da = new SqlDataAdapter(conexion.str_sql, conexion.origen);
                conexion.da.Fill(propiedad, "Propiedad");
                conexion.origen.Close();
                return propiedad;
            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                    conexion.origen.Close();
                return null;
            }
        }
        //Prueba con filtro
        public dtoPropiedad2 ConsultarPropiedadConFiltros(int? id_tipoP, int? id_barrio, int? nroHab, double? pDesde, double? pHasta)
        {
            dtoPropiedad2 propiedad = new dtoPropiedad2();
            try
            {
                conexion.origen.Open();
                //conexion.ds = new DataSet();
                conexion.str_sql =
                    @"select p.id_propiedad,tp.nombre as TipoPropiedad,p.direccion as Dirección, b.nombre as Barrio, l.nombre as Localidad, p.nro_habitaciones as NroHab,p.piso as Piso,p.depto as Depto,
                         p.precio as Precio, e.nombre as Estado, s.nombre as Servicios, r.nombre as Requisitos,cast(datediff(dd,p.fecha_inauguracion,GETDATE()) / 365.25 as int)as AñosAntigüedad, b.calificacion as CriterioBarrio, e.calificacion as CriterioEstado, s.calificacion as CriterioServicio, r.calificacion as CriterioRequisito from Propiedad p, Barrio b, Localidad l,TipoPropiedad tp, Estado e, Servicio s, Requisito r
                         where p.id_tipoPropiedad=tp.id_tipoPropiedad and p.id_barrio=b.id_barrio and b.id_localidad=l.id_localidad and p.id_estado=e.id_estado and p.id_servicio=s.id_servicio and p.id_requisito=r.id_requisito";
                if (id_tipoP.HasValue)
                    conexion.str_sql += " and p.id_tipoPropiedad= " + id_tipoP;
                if (id_barrio.HasValue)
                    conexion.str_sql += " and p.id_barrio= " + id_barrio;
                if (nroHab.HasValue)
                    conexion.str_sql += " and p.nro_habitaciones= " + nroHab;
                if (pDesde.HasValue)
                    conexion.str_sql += " and p.precio > '" + pDesde + "'";
                if (pHasta.HasValue)
                    conexion.str_sql += " and p.precio < '" + pHasta + "'";

                conexion.cmd = new SqlCommand(conexion.str_sql, conexion.origen);
                conexion.da = new SqlDataAdapter(conexion.cmd);
                //conexion.da = new SqlDataAdapter(conexion.str_sql, conexion.origen);
                conexion.da.Fill(propiedad, "PropiedadFiltro");
                conexion.origen.Close();
                return propiedad;

            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                    conexion.origen.Close();
                return null;
            }
        }
        //Para buscar registros de propiedades que ya estan en la grilla de alternativas elegidas para que no las traiga
        private void BuscarPorClavePrimariaDataTable(int[] vec)
        {
            //object[] key = (int)vec[];

        }

        

        //*****Inicio de consultas de ConsultarPropiedad*****

        
        public DataSet consultarPropiedades()
        {
            conexion.origen.Open();
            conexion.ds = new DataSet();

            conexion.str_sql = @"SELECT Propiedad.id_propiedad, TipoPropiedad.nombre AS TipoPropiedad, Localidad.nombre As Localidad, Barrio.nombre AS Barrio, Propiedad.direccion AS Dirección, Propiedad.piso AS Piso, Propiedad.depto as Departamento, Propiedad.nro_habitaciones AS Habitaciones, cast(datediff(dd,Propiedad.fecha_inauguracion,GETDATE()) / 365.25 as int)as AñosAntigüedad, Estado.nombre AS Estado, Servicio.nombre AS Servicios, Requisito.nombre AS Requisitos, Propiedad.precio AS Precio  
            FROM Propiedad, TipoPropiedad, Barrio, Estado, Localidad, Requisito, Servicio
            WHERE Propiedad.id_tipoPropiedad = TipoPropiedad.id_tipoPropiedad AND Propiedad.id_barrio = Barrio.id_barrio AND Barrio.id_localidad = Localidad.id_localidad AND Propiedad.id_estado = Estado.id_estado AND Propiedad.id_requisito = Requisito.id_requisito AND Propiedad.id_Servicio = Servicio.id_servicio";

            conexion.da = new SqlDataAdapter(conexion.str_sql, conexion.origen);
            conexion.da.Fill(conexion.ds, "Propiedades");

            conexion.origen.Close();
            return conexion.ds;
        }


        //Consultar Propiedades con Filtro
        public DataSet ConsultarPropiedadConFiltrosOrdenados(int? id_tipoP, int? id_barrio, int? nroHab, double? pDesde, double? pHasta)
        {
            try
            {
                conexion.origen.Open();
                conexion.ds = new DataSet();

                conexion.str_sql =
                    @"select p.id_propiedad,tp.nombre as TipoPropiedad, l.nombre as Localidad, b.nombre as Barrio, p.direccion as Dirección, p.piso as Piso, p.depto as Departamento, p.nro_habitaciones as Habitaciones,
                         cast(datediff(dd,p.fecha_inauguracion,GETDATE()) / 365.25 as int)as AñosAntigüedad, e.nombre as Estado, s.nombre as Servicios, r.nombre as Requisitos, p.precio as Precio from Propiedad p, Barrio b, Localidad l,TipoPropiedad tp, Estado e, Servicio s, Requisito r
                         where p.id_tipoPropiedad=tp.id_tipoPropiedad and p.id_barrio=b.id_barrio and b.id_localidad=l.id_localidad and p.id_estado=e.id_estado and p.id_servicio=s.id_servicio and p.id_requisito=r.id_requisito";
                if (id_tipoP.HasValue)
                    conexion.str_sql += " and p.id_tipoPropiedad= " + id_tipoP;
                if (id_barrio.HasValue)
                    conexion.str_sql += " and p.id_barrio= " + id_barrio;
                if (nroHab.HasValue)
                    conexion.str_sql += " and p.nro_habitaciones= " + nroHab;
                if (pDesde.HasValue)
                    conexion.str_sql += " and p.precio > '" + pDesde + "'";
                if (pHasta.HasValue)
                    conexion.str_sql += " and p.precio < '" + pHasta + "'";

                conexion.da = new SqlDataAdapter(conexion.str_sql, conexion.origen);
                conexion.da.Fill(conexion.ds, "PropiedadFiltro");
                conexion.origen.Close();
                return conexion.ds;

            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                    conexion.origen.Close();
                return null;
            }
        }
        
        public void eliminarPropiedad(int id)
        {
            conexion.origen.Open();
            conexion.ds = new DataSet();

            conexion.str_sql = @"DELETE FROM Propiedad WHERE id_propiedad=" + id;
            conexion.da = new SqlDataAdapter(conexion.str_sql, conexion.origen);
            conexion.da.Fill(conexion.ds, "Propiedades");

            conexion.origen.Close();
        }
        //*****Fin de consultas de ConsultarPropiedad*****

        //Inicio de consultas de ModificarPropiedad
        public DataSet consultarPropiedadesModificar(int id)
        {
            conexion.origen.Open();
            conexion.ds = new DataSet();

            conexion.str_sql = @"SELECT Propiedad.id_propiedad, TipoPropiedad.nombre AS Tipo, Localidad.nombre As Localidad, Barrio.nombre AS Barrio, Propiedad.direccion AS Dirección, Propiedad.piso AS Piso, Propiedad.nro_habitaciones AS Habitaciones, Propiedad.fecha_inauguracion AS Antiguedad, Estado.nombre AS Estado, Servicio.nombre AS Servicio, Requisito.nombre AS Requisito, Propiedad.precio AS Precio, Propiedad.depto, Propiedad.descripcion, Propiedad.foto
            FROM Propiedad, TipoPropiedad, Barrio, Estado, Localidad, Requisito, Servicio
            WHERE Propiedad.id_tipoPropiedad = TipoPropiedad.id_tipoPropiedad AND Propiedad.id_barrio = Barrio.id_barrio AND Barrio.id_localidad = Localidad.id_localidad AND Propiedad.id_estado = Estado.id_estado AND Propiedad.id_requisito = Requisito.id_requisito AND Propiedad.id_Servicio = Servicio.id_servicio AND id_propiedad = " + id;

            conexion.da = new SqlDataAdapter(conexion.str_sql, conexion.origen);
            conexion.da.Fill(conexion.ds, "Propiedades");

            conexion.origen.Close();
            return conexion.ds;
        }


        //Modificar Propiedad según el id pasado por parámetro
        public string ModificarPropiedad(int id, Propiedad p)
        {
            conexion.origen.Open();
            try
            {
                conexion.str_sql = "UPDATE Propiedad SET direccion=@direccion,id_barrio=@id_barrio,fecha_inauguracion=@fecha_inauguracion,foto=@foto,nro_habitaciones=@nro_habitaciones,id_estado=@id_estado,piso=@piso,depto=@depto,id_servicio=@id_servicio,id_requisito=@id_requisito,precio=@precio,descripcion=@descripcion,id_tipoPropiedad=@id_tipoPropiedad WHERE id_propiedad = "+id;
                conexion.cmd = new SqlCommand(conexion.str_sql, conexion.origen);
                //Parámetros
                conexion.cmd.Parameters.Add("@direccion", p.Direccion);
                conexion.cmd.Parameters.Add("@id_barrio", p.Id_barrio);
                conexion.cmd.Parameters.Add("@fecha_inauguracion", p.FechaIng);
                if (p.foto != null)
                {
                    //conexion.cmd.Parameters.Add("@foto", p.foto); 
                    conexion.cmd.Parameters.Add(new SqlParameter("@foto", SqlDbType.Image) { Value = p.foto });
                }

                else
                {
                    //conexion.cmd.Parameters.Add("@foto", DBNull.Value); 
                    conexion.cmd.Parameters.Add(new SqlParameter("@foto", SqlDbType.Image) { Value = DBNull.Value });
                }
                conexion.cmd.Parameters.Add("@nro_habitaciones", p.NroHabitaciones);
                conexion.cmd.Parameters.Add("@id_estado", p.Id_estado);
                if (p.Piso != 0)
                    conexion.cmd.Parameters.Add("@piso", p.Piso);
                else
                    conexion.cmd.Parameters.Add("@piso", DBNull.Value);
                if (p.Depto != 'ñ')
                    conexion.cmd.Parameters.Add("@depto", p.Depto);
                else
                    conexion.cmd.Parameters.Add("@depto", DBNull.Value);

                conexion.cmd.Parameters.Add("@id_servicio", p.Id_servicio);
                conexion.cmd.Parameters.Add("@id_requisito", p.Id_requisito);
                conexion.cmd.Parameters.Add("@precio", p.Precio);
                if (p.Descripcion != "")
                    conexion.cmd.Parameters.Add("@descripcion", p.Descripcion);
                else
                    conexion.cmd.Parameters.Add("@descripcion", DBNull.Value);
                conexion.cmd.Parameters.Add("@id_tipoPropiedad", p.Id_tipoPropiedad);

                conexion.cmd.ExecuteNonQuery();
                conexion.origen.Close();
                return "Modificado";
            }
            catch (Exception)
            {
                if (conexion.origen.State == ConnectionState.Open)
                    conexion.origen.Close();
                return "Error al Guardar";
            }
        }

    }
}
