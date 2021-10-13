using System;

namespace Entidades.Clases
{
    public class Persona
    {
        private double dni;
        private string nombre;
        private string apellido;
        private DateTime nacimiento;
        private string genero;

        public string Nombre { get => this.nombre; 
            set
            {
                if (value.Length > 50 || value == string.Empty)
                    throw new ArgumentOutOfRangeException("El nombre no puede ser vacío ni contener más de 50 caracteres");
                else
                    this.nombre = value;
            }                
        }
        public string Apellido { get => apellido;
            set
            {
                if (value.Length > 50 || value == string.Empty)
                    throw new ArgumentOutOfRangeException("El apellido no puede ser vacío contener más de 50 caracteres");
                else
                    this.apellido = value;
            }        
        }
        public double Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("El dni no puede ser menor a 0");
                else
                    this.dni = value;
            }    
        }
        public DateTime Nacimiento {
            get
            {
                return this.nacimiento;
            } 
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Edad inválida");
                else
                {
                    this.nacimiento = value;
                }
            }
            }
        public string Genero { get => genero;
            set
            {
                if (value.Length > 20)
                    throw new ArgumentOutOfRangeException("El género no puede tener más de 20 caracteres");
                else
                {
                    this.genero = value;
                }
            }        
                
        }
    }
}
