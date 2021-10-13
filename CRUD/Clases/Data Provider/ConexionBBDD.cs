using System.Data.SqlClient;

namespace Clases.BBDD
{
    public class ConexionBBDD
    {
        private static SqlConnection sqlConection;

        private ConexionBBDD(string conexionABaseDeDatos)
        {
            sqlConection = new SqlConnection(conexionABaseDeDatos);
        }
        public SqlConnection Conexion
        {
            get
            {
                if (sqlConection == null)
                    sqlConection = new SqlConnection("Data source= localhost ; Database = Comunidad ; Trusted_Connection=True");
                return sqlConection;
            }
        }

    }
}
