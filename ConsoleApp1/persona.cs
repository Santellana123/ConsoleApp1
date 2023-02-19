using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class persona
    {
        protected String nombre;
        protected DateTime? fechaNacimiento;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public DateTime? FechaNacimiento2
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public int Edad
        {
            get
            {
                int edad;
                edad = (DateTime.Now.Year - fechaNacimiento.Value.Year);
                return edad;
            }

        }
        public persona()
        {
            nombre = String.Empty;
            fechaNacimiento = null;
        }
        public persona(String nombre, DateTime? fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string ToString()
        {
            return nombre.ToUpper() + " " + Edad;
        }
    }
}
