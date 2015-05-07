using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CurpForm.CurpReferencia;

namespace CurpForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        ServicioCurpSoapClient c = new ServicioCurpSoapClient();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAPaterno.Text != string.Empty && txtAMaterno.Text != string.Empty && txtNombre.Text != string.Empty && txtAno.Text != string.Empty && txtDia.Text != string.Empty && txtMes.Text != string.Empty)
            {
                try
                {
                    MessageBox.Show(c.Generar(txtNombre.Text, txtAPaterno.Text, txtAMaterno.Text, txtDia.Text, txtMes.Text, txtAno.Text, cmbSexo.SelectedItem.ToString()));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Debes introducir los campos correctamente /n {o}", ex.Message);
                }



            }
            else
            {
                MessageBox.Show("Debes introducir los campos correctamente");
            }

        }
    }
}
