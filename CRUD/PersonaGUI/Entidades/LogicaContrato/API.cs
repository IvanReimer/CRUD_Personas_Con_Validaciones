using Entidades.DAL.DataProvider;
using System;
using Entidades.Clases;
using System.Data;
using System.Globalization;

namespace Entidades.LogicaContrato
{
    public class API
    {
        Persona persona;
        SqlCommander command;
        public API(Persona p)
        {
            this.persona = p;
        }
        public API()
        {
            this.persona = new Persona();
            this.command = new SqlCommander();
        }
        public DataTable Show()
        {
            return this.command.ReadAllFields("Persona");
        }
        public Boolean Delete(double id)
        {
            return command.DeleteRow("Persona", id);
        }
        public void CloseDataBase()
        {
            this.command.CloseConnection();
        }

        public void CreateOrModify(string id, string name, string surname, string birth, string gender, bool isCreation)
        {
            double idAux;
            DateTime dateTimeAux;
            if (double.TryParse(id, out idAux))
                this.persona.Dni = idAux;
            else
                throw new ArithmeticException("El DNI debe tener números");                      
            persona.Nombre = name;
            persona.Apellido = surname;
            persona.Genero = gender;
            if (DateTime.TryParseExact(birth,"dd/MM/yyyy",null,DateTimeStyles.None ,out dateTimeAux))
                persona.Nacimiento = dateTimeAux;
            else
                throw new ArithmeticException("Error en el parseo de fecha");
            command.CreateOrModify(persona, "Persona", isCreation);
        }

        public bool IdIsCreated(double id)
        {
            return !this.command.CheckIfIdIsNotCreated(id, "Persona");
        }
        public string TakeOut(string column , double id)
        {
            return this.command.TakeOut(column, id, "Persona");
        }
    }
}
