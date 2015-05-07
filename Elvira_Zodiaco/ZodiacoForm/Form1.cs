using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZodiacoForm.ZodiacoServiceReference;

namespace ZodiacoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ZodiacoServiceReference.ZodiacoWebServiceSoapClient zod = new ZodiacoWebServiceSoapClient();

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime f = new DateTime(dtmFecha.Value.Year, dtmFecha.Value.Month, dtmFecha.Value.Day);
            lblZodiaco.Text = zod.Fecha(f);
        }

        private void dtmFecha_ValueChanged(object sender, EventArgs e)
        {
            lblZodiaco.Text = "";
            lblZodiaco.Visible = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
