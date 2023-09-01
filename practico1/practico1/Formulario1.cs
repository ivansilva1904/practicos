using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practico1
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void B_GUARDAR_Click(object sender, EventArgs e)
        {
            string nombre = T_NOMBRE.Text;
            string apellido = T_APELLIDO.Text;

            T_MULTILINEA.Text = nombre + " " + apellido;
        }

        private void B_ELIMINAR_Click(object sender, EventArgs e)
        {
            T_MULTILINEA.Clear();
        }

        private void B_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formulario1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                this.Close();
            }
        }
    }
}
