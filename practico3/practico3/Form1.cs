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

        private void T_DNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void T_NOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void T_APELLIDO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void B_GUARDAR_Click(object sender, EventArgs e)
        {
            string dni = T_DNI.Text;
            string nombre = T_NOMBRE.Text;
            string apellido = T_APELLIDO.Text;

            if(!string.IsNullOrWhiteSpace(dni) && !string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(apellido))
            {
                L_ELIMINAR.Text = nombre + " " + apellido;
                DialogResult ask = MessageBox.Show("Seguro que desea insertar un nuevo cliente?",
                    "Confirmar inserción",
                    MessageBoxButtons.YesNo);
                if (ask == DialogResult.Yes)
                {
                    MessageBox.Show("El cliente " + nombre + " " + apellido + " se registro correctamente", "Inserción confirmada");
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

        private void B_ELIMINAR_Click(object sender, EventArgs e)
        {
            if(L_ELIMINAR.Text == "Modificar")
            {
                MessageBox.Show("Ingrese un usuario para eliminar",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                string nombre = T_NOMBRE.Text;
                string apellido = T_APELLIDO.Text;

                DialogResult resp_eliminacion = MessageBox.Show("Esta a punto de eliminar al cliente " + nombre + " " + apellido,
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if(resp_eliminacion == DialogResult.Yes)
                {
                    MessageBox.Show("El cliente " + nombre + " " + apellido + " se elimino correctamente",
                        "Eliminación confirmada");
                    T_DNI.Clear();
                    T_NOMBRE.Clear();
                    T_APELLIDO.Clear();
                    T_TELEFONO.Clear();
                    L_ELIMINAR.Text = "Modificar";
                }
            }
        }

        private void RB_HOMBRE_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton estadoBoton = RB_HOMBRE;
            PictureBox fotoUsuario = PB_H_M;

            if(estadoBoton.Checked == true)
            {
                fotoUsuario.Image = practico2.Properties.Resources.hombre;
                fotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                fotoUsuario.Image = practico2.Properties.Resources.mujer;
                fotoUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void B_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void T_TELEFONO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
