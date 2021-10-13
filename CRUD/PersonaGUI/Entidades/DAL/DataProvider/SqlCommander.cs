using System;
using System.Data;
using System.Data.SqlClient;
using Entidades.Clases;
using System.Linq;

namespace Entidades.DAL.DataProvider
{
    public class SqlCommander : DataBaseConnection
    {
        SqlCommand command;
        DataTable table;
        SqlDataReader reader;
        public SqlCommander() : base()
        {
            base.OpenConnection();
            this.command = new SqlCommand();
            this.command.Connection = base.sqlConnection;
            this.table = new DataTable();
            command.CommandType = CommandType.Text;
        }
        public DataTable ReadAllFields(string table)
        {
            command.CommandText = "SELECT * FROM " + table;
            reader = command.ExecuteReader();
            this.table.Load(reader,LoadOption.OverwriteChanges);
            return this.table;
        }
        public Boolean DeleteRow(string table, double id)
        {
            if (!this.CheckIfIdIsNotCreated(id, table))
            {
                try
                {
                    this.command.CommandText = "DELETE FROM " + table + " WHERE DNI = @dni";
                    this.command.Parameters.Clear();
                    this.command.Parameters.Add(new SqlParameter("dni", id));
                    this.reader.Close();
                    this.command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    throw new Exception("Error al borrar persona de la base de datos");
                }
            }
            else
            {
                throw new DataException("El DNI no existe en la base de datos");
            }

        }
        public override void CloseConnection()
        {
            base.sqlConnection.Close();
        }

        public void CreateOrModify(Persona p, string table, bool isCreation)
        {
            if (isCreation)
            {
                if (this.CheckIfIdIsNotCreated(p.Dni, table))
                {
                    try
                    {
                        this.command.CommandText = "INSERT INTO " + table + " (dni, nombre, apellido, nacimiento, genero) "
                        + "VALUES ( @id, @name , @surname , @birth , @gender )";
                        this.command.Parameters.Clear();
                        this.command.Parameters.Add(new SqlParameter("id", p.Dni));
                        this.command.Parameters.Add(new SqlParameter("name", p.Nombre));
                        this.command.Parameters.Add(new SqlParameter("surname", p.Apellido));
                        this.command.Parameters.Add(new SqlParameter("birth", p.Nacimiento));
                        this.command.Parameters.Add(new SqlParameter("gender", p.Genero));
                        this.reader.Close();
                        this.command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al crear persona");
                    }
                }
                else
                {
                    throw new DataException("ID ingresado ya existente");
                }
            }
            else
            {
                try
                {
                    this.command.CommandText = "UPDATE " + table + " SET nombre= @name , apellido = @surname , nacimiento = @birth , genero = @gender"
                    + " WHERE dni = @id ";
                    this.command.Parameters.Clear();
                    this.command.Parameters.Add(new SqlParameter("id", p.Dni));
                    this.command.Parameters.Add(new SqlParameter("name", p.Nombre));
                    this.command.Parameters.Add(new SqlParameter("surname", p.Apellido));
                    this.command.Parameters.Add(new SqlParameter("birth", p.Nacimiento));
                    this.command.Parameters.Add(new SqlParameter("gender", p.Genero));
                    this.command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw new Exception("Error al crear persona");
                }
            }
        }
        public bool CheckIfIdIsNotCreated(double id, string table)
        {
            
            this.command.CommandText = "SELECT * FROM " + table + " WHERE dni = @id";
            this.command.Parameters.Clear();
            this.command.Parameters.Add(new SqlParameter("id", id));
            reader = command.ExecuteReader();
            return !reader.Read();
        }

        public string TakeOut(string column , double id, string table)
        {
            //this.command.Dispose();
            //this.command = new SqlCommand();
            //this.command.CommandType = CommandType.Text;
            this.command.CommandText = "SELECT " + column + " FROM " + table + " WHERE dni = @id;";
            this.command.Parameters.Clear();
            this.command.Parameters.Add(new SqlParameter("id", id));
            //this.command.Connection = this.sqlConnection;
            this.reader = this.command.ExecuteReader();
            this.table.Clear();
            try
            {
                this.table.Load(reader,LoadOption.OverwriteChanges);
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            string text = string.Empty;
            foreach (var item in this.table.Rows[0].ItemArray)
            {
                text += item.ToString();
            }
            
            return text;
        }
    }
}


