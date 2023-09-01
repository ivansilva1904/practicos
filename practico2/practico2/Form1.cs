using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TXT_DNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TXT_NOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TXT_APELLIDO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BUT_GUARDAR_Click(object sender, EventArgs e)
        {
            string dni = TXT_DNI.Text;
            string nombre = TXT_NOMBRE.Text;
            string apellido = TXT_APELLIDO.Text;

            if(!string.IsNullOrWhiteSpace(dni) && !string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(apellido))
            {
                LAB_MODIFICAR.Text = nombre + " " + apellido;
                DialogResult ask = MessageBox.Show("Seguro que desea insertar un nuevo cliente?",
                    "Confirmar inserción",
                    MessageBoxButtons.YesNo);
                if(ask == DialogResult.Yes)
                {
                    MessageBox.Show("El cliente " + nombre + " " + apellido + " se registro correctamente",
                        "Inserción confirmada");
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos requeridos",
                    "Campos faltantes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BUT_ELIMINAR_Click(object sender, EventArgs e)
        {
            string dni = TXT_DNI.Text;
            string nombre = TXT_NOMBRE.Text;
            string apellido = TXT_APELLIDO.Text;

            if(!string.IsNullOrWhiteSpace(dni) && !string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(apellido))
            {
                DialogResult resp_eliminacion = MessageBox.Show("Esta a punto de eliminar al cliente " + nombre + " " + apellido,
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if(resp_eliminacion == DialogResult.Yes)
                {
                    MessageBox.Show("El cliente " + nombre + " " + apellido + " se elimino correctamente",
                        "Eliminación confirmada");
                    TXT_DNI.Clear();
                    TXT_NOMBRE.Clear();
                    TXT_APELLIDO.Clear();
                    LAB_MODIFICAR.Text = "Modificar";
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar los datos del cliente a eliminar",
                    "Campos faltantes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
