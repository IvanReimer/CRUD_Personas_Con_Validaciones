using System.Data.SqlClient;
using System;
using System.Data;

namespace Entidades.DAL.DataProvider
{
    public abstract class DataBaseConnection
    {
        protected SqlConnection sqlConnection;
        protected DataBaseConnection()
        {
            sqlConnection = new SqlConnection("Data source= localhost ; Database = Comunidad ; Trusted_Connection=True");
        }
        protected void OpenConnection()
        {
            if (this.sqlConnection != null)
            {
                try
                {
                    sqlConnection.Open();
                }
                catch(InvalidOperationException)
                {
                    this.CloseConnection();
                }
                catch(SqlException)
                {
                    this.CloseConnection();
                }
                catch(Exception)
                {
                    this.CloseConnection();
                }
            }
        }
        public abstract void CloseConnection();


    }
}
