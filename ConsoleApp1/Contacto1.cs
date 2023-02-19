﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Contacto1 : persona
    {
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set
            {
                telefono = value.Replace(" ", "").Replace("-", "");
            }
        }

        public Contacto1() : base()
        {
            telefono = string.Empty;
        }
        public Contacto1(string nombre, DateTime? fechaNacimiento, string telefono) : base(nombre, fechaNacimiento)
        {
            this.telefono = telefono;
        }

        public override string ToString()
        {
            return base.ToString() + " " + telefono;
        }
    }
}