using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    class Estudiante
    {
        private string Nombre;
        private int Edad;
        private char Sexo;

        public Estudiante()
        {
            MessageBox.Show("Constructor de Estudiante");
        }

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }

        }

        public int edad
        {
            get { return Edad; }
            set { Edad = value; }
        }

        public Char sexo
        {
            get { return Sexo; }
            set { Sexo = value; }
        }
    }
}
