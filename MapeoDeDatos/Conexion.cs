using System.Data;
using System.Data.SqlClient;

namespace AlquileresDEC.Datos
{
    public class Conexion
    {
        public SqlCommand cmd;
        public SqlCommand cmd2;
        public SqlCommand cmd3;
        public SqlCommand cmd4;
        public SqlCommand cmd5;
        //public string ConexionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=KrismaDb;Data Source=ADMIN-PC\\SQLEXPRESS";
        public string ConexionString =
            "workstation id=BDAlqDEC.mssql.somee.com;packet size=4096;user id=pablero_SQLLogin_1;pwd=n8rqrt69fh;data source=BDAlqDEC.mssql.somee.com;persist security info=False;initial catalog=BDAlqDEC;Connect Timeout=60";

        public SqlDataAdapter da;
        public SqlDataReader dr1;
        public SqlDataReader dr2;
        public SqlDataReader dr3;
        public DataRow drow;
        public DataSet ds;
        public DataTable dt;
        public SqlConnection origen;
        public string str_sql;
        public string str_sql2;
        public string str_sql3;
        public string str_sql4;
        public string str_sql5;
        //public SqlCommand cmd2;


        public Conexion()
        {
            origen =
                new SqlConnection(
                    "workstation id=BDAlqDEC.mssql.somee.com;packet size=4096;user id=pablero_SQLLogin_1;pwd=n8rqrt69fh;data source=BDAlqDEC.mssql.somee.com;persist security info=False;initial catalog=BDAlqDEC;Connect Timeout=60");
            //this.origen = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=KrismaDb;Data Source=ADMIN-PC\\SQLEXPRESS");
            ds = null;
            dt = null;
            str_sql = "";
            str_sql2 = "";
            str_sql3 = "";
            str_sql4 = "";
            str_sql5 = "";

            da = null;
            dr1 = null;
            dr2 = null;
            dr3 = null;

            cmd = null;
            cmd2 = null;
            cmd3 = null;
            cmd4 = null;
            drow = null;

            //this.cmd2 = null;
        }
    }
}