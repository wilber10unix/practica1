using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs ev)
        {
            Estudiante e = new Estudiante();
            e.nombre = ctNombre.Text;
            e.edad = int.Parse(ctEdad.Text);
            e.sexo = Char.Parse(ctSexo.Text);
            MessageBox.Show(e.nombre + " " + e.edad.ToString() + " " + e.sexo.ToString());
        }
    }
}
