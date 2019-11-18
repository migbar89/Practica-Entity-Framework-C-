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
    public partial class frm_verCreditos : Form
    {
        creditosEntities1 bd;
        public cliente cli;
        List<cuotas> listacuota;
        creditos credito;
        public frm_verCreditos()
        {
            InitializeComponent();
        }

        private void frm_verCreditos_Load(object sender, EventArgs e)
        {
            bd = new creditosEntities1();
            credito = cli.creditos.ToList()[0];
            lbnombre.Text = cli.nombre.Trim() + " " + cli.apellido.Trim();
            lbfechafin.Text ="Inicia="+ credito.fecha_fin.ToString();
            lbfechainicio.Text = "Finaliza=" + credito.fecha_inicio.ToString();
            lbinteres.Text = "Interes=" + credito.interes.ToString();
            lbmonto.Text = "Monto del credito=" + credito.monto.ToString();
            lbmontoapagar.Text = "Monto a Pagar=" + credito.monto_a_pagar.ToString();
            lbplazo.Text = "plazo=" + credito.plazo.ToString();
            lbmontocuota.Text = "Monto Cuota=" + credito.monto_cuota.ToString();
            listacuota = new List<cuotas>();
            cargardatos();
           
        }
        void cargardatos()
        {
            gridcuotas.DataSource = null;
            gridcuotas.Rows.Clear();
            listacuota = (from cuotas in bd.cuotas
                          where cuotas.idcredito==credito.id
                          select cuotas).ToList();
            foreach (cuotas c in listacuota)
            {
                gridcuotas.Rows.Add(c.fecha, c.monto.ToString());

            }
           // gridcuotas.DataSource = listacuota;
            
        }

        private void btagregarcuota_Click(object sender, EventArgs e)
        {
            frm_AgregarCuota agregarcuota = new frm_AgregarCuota();
            agregarcuota.credito = cli.creditos.ToList()[0];
            agregarcuota.ShowDialog();
            cargardatos();
            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fila = gridcuotas.CurrentRow.Index;
            cuotas c = listacuota[fila];
            DialogResult diag = MessageBox.Show("Desea eliminar esta Cuota?",
                "Eliminando Cuota",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (diag == DialogResult.OK)
            {
                bd.cuotas.Remove(c);
                bd.SaveChanges();
                cargardatos();
            }
            
        }
    }
}
