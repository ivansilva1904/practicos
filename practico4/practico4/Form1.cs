using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BUT_GENERAR_Click(object sender, EventArgs e)
        {
            LBOX_NUMEROS.Items.Clear();
            int indice = CLB_PAR_IMPAR_PRIMO.SelectedIndex;

            if (!string.IsNullOrWhiteSpace(TXT_DESDE.Text) && !string.IsNullOrWhiteSpace(TXT_HASTA.Text))
            {
                switch (indice)
                {
                    case 0:
                        this.BUT_PARES_Click();
                        break;
                    case 1:
                        this.BUT_IMPARES_Click();
                        break;
                    case 2:
                        this.BUT_PRIMOS_Click();
                        break;
                    default:
                        MessageBox.Show("Seleccione una opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Complete los campos", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void CLB_PAR_IMPAR_PRIMO_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CLB_PAR_IMPAR_PRIMO.SelectedIndex;
            int count = CLB_PAR_IMPAR_PRIMO.Items.Count;
            for (int i = 0; i < count; i++)
            {
                if (index != i)
                {
                    CLB_PAR_IMPAR_PRIMO.SetItemChecked(i, false);
                }
            }
        }
        private void TXT_DESDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TXT_HASTA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BUT_PARES_Click()
        {
            LBOX_NUMEROS.Items.Clear();

            if (!string.IsNullOrWhiteSpace(TXT_DESDE.Text) && !string.IsNullOrWhiteSpace(TXT_HASTA.Text))
            {
                int desde = int.Parse(TXT_DESDE.Text);
                int hasta = int.Parse(TXT_HASTA.Text);

                if (desde < hasta)
                {
                    for (int i = desde; i <= hasta; i++)
                    {
                        if (i % 2 == 0)
                        {
                            LBOX_NUMEROS.Items.Add(i);
                        }
                    }
                }
                else
                {
                    for (int i = desde; i >= hasta; i--)
                    {
                        if(i % 2 == 0)
                        {
                            LBOX_NUMEROS.Items.Add(i);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BUT_IMPARES_Click()
        {
            LBOX_NUMEROS.Items.Clear();

            if (!string.IsNullOrWhiteSpace(TXT_DESDE.Text) && !string.IsNullOrWhiteSpace(TXT_HASTA.Text))
            {
                int desde = int.Parse(TXT_DESDE.Text);
                int hasta = int.Parse(TXT_HASTA.Text);

                if (desde < hasta)
                {
                    for (int i = desde; i <= hasta; i++)
                    {
                        if (i % 2 != 0)
                        {
                            LBOX_NUMEROS.Items.Add(i);
                        }
                    }
                }
                else
                {
                    for (int i = desde; i >= hasta; i--)
                    {
                        if(i % 2 != 0)
                        {
                            LBOX_NUMEROS.Items.Add(i);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BUT_PRIMOS_Click()
        {
            LBOX_NUMEROS.Items.Clear();
            int a = 0;

            if (!string.IsNullOrWhiteSpace(TXT_DESDE.Text) && !string.IsNullOrWhiteSpace(TXT_HASTA.Text))
            {
                int desde = int.Parse(TXT_DESDE.Text);
                int hasta = int.Parse(TXT_HASTA.Text);

                if (desde < hasta)
                {
                    for (int i = desde; i <= hasta; i++)
                    {
                        for (int j = i; j >= 1; j--)
                        {
                            if(i % j == 0)
                            {
                                a++;
                            }
                        }
                        if(a == 2)
                        {
                            LBOX_NUMEROS.Items.Add(i);
                        }
                        a = 0;
                    }
                }
                else
                {
                    for (int i = desde; i >= hasta; i--)
                    {
                        for (int j = i; j >= 1; j--)
                        {
                            if (i % j == 0)
                            {
                                a++;
                            }
                        }
                        if (a == 2)
                        {
                            LBOX_NUMEROS.Items.Add(i);
                        }
                        a = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BUT_GRAFICAR_Click(object sender, EventArgs e)
        {
            CH_NUMERITOS.Series["serie_numeros"].Points.Clear();
            int cantidad = 0;
            ListBox LBOX_AUX = LBOX_NUMEROS;
            cantidad = LBOX_AUX.Items.Count;

            for (int i = 0; i < cantidad; i++)
            {
                CH_NUMERITOS.Series["serie_numeros"].Points.AddXY(Convert.ToString(i + 1), LBOX_AUX.Items[i].ToString());
            }
        }
    }
}
