using System;

namespace Clases.Entidades
{
    public class Persona
    {
        public string nombre { get => this.nombre; 
            set
            {
                if (value.Length > 50)
                    throw new ArgumentOutOfRangeException("El nombre no puede contener más de 50 caracteres");
                else
                    nombre = value;
            }                
        }
        string apellido { get => apellido;
            set
            {
                if (value.Length > 50)
                    throw new ArgumentOutOfRangeException("El apellido no puede contener más de 50 caracteres");
                else
                    apellido = value;
            }        
        }
        double dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("El dni no puede ser menor a 0");
            }    
        }
        DateTime nacimiento {
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
        string genero { get => genero;
            set
            {
                if (value.Length > 50)
                    throw new ArgumentOutOfRangeException("El género no puede tener más de 50 caracteres");
                else
                {
                    this.genero = value;
                }
            }        
                
        }
    }
}
