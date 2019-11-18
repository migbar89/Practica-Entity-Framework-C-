using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_BD_Creditos
{
    public partial class frm_AgregarCuota : Form
    {
        creditosEntities1 bd;
        public creditos credito;
        public frm_AgregarCuota()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            cuotas c = new cuotas();
            c.fecha = ctfecha.Value;
            c.monto = float.Parse(ctmonto.Text);
            c.idcredito = credito.id;
            bd.cuotas.Add(c);
            bd.SaveChanges();
            this.Close();
        }

        private void frm_AgregarCuota_Load(object sender, EventArgs e)
        {
            bd = new creditosEntities1();
            ctmonto.Focus();

        }
    }
}
