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

    public partial class frm_Creditos : Form
    {
        public cliente cli;
        creditosEntities1 bd;
        public frm_Creditos()
        {
            InitializeComponent();
        }

        private void frm_Creditos_Load(object sender, EventArgs e)
        {
            bd = new creditosEntities1();
            lbnombre.Text = "Registrando Credito al Cliente " + cli.nombre+" "+cli.apellido;
        }
     //   https://codeshare.io/2WZjwE
        private void btguardar_Click(object sender, EventArgs e)
        {
            creditos cre = new creditos();
            cre.fecha_fin = ctfechafin.Value;
            cre.fecha_inicio = ctfechainicio.Value;
            cre.interes = int.Parse(ctinteres.Text);
            cre.monto = double.Parse(ctmonto.Text);
            cre.monto_a_pagar = double.Parse(ctmontoapagar.Text);
            cre.plazo = int.Parse(ctplazo.Text);
            cre.monto_cuota =double.Parse (lbmontocuota.Text);
            cre.idcliente = cli.id;
            bd.creditos.Add(cre);
            bd.SaveChanges();
            MessageBox.Show("Credito Guardado Correctamente", "Guardando Credito");
            this.Close();

        }

        private void ctplazo_TextChanged(object sender, EventArgs e)
        {
            if (ctplazo.Text.Trim().Length == 0)
                return;
            int plazo = int.Parse(ctplazo.Text);
            DateTime fechainicio = ctfechainicio.Value;
            ctfechafin.Value = fechainicio.AddMonths(plazo);
        }

        private void ctinteres_TextChanged(object sender, EventArgs e)
        {
            if (ctmonto.Text.Trim().Length == 0 || ctinteres.Text.Trim().Length == 0)
                return;
            float monto = float.Parse(ctmonto.Text.Trim());
            int interes = int.Parse(ctinteres.Text.Trim());

            ctmontoapagar.Text =( monto + (monto * (interes / (float)100))).ToString();
        }

        private void ctmontoapagar_TextChanged(object sender, EventArgs e)
        {
            if (ctmontoapagar.Text.Trim().Length == 0)
                return;
            float montopagar = float.Parse(ctmontoapagar.Text.Trim());
            int plazo = int.Parse(ctplazo.Text);
            lbmontocuota.Text = (montopagar / plazo).ToString();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
