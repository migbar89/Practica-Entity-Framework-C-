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
    public partial class frm_verclientes : Form
    {
        creditosEntities1 bd;
        List<cliente> listacliente;
        public frm_verclientes()
        {
            InitializeComponent();
        }

        private void frm_verclientes_Load(object sender, EventArgs e)
        {
            bd = new creditosEntities1();
           cargardatos();

           
        }
        void cargardatos()
        {
           
            dataGridView1.DataSource = null;
            listacliente = (from cliente in bd.cliente
                            select cliente).ToList();
            dataGridView1.DataSource = listacliente;

        }
        void cargardatos(String busqueda)
        {
            
            //LinQ
            dataGridView1.DataSource = null;
            listacliente = (from cliente in bd.cliente
                            where cliente.apellido.Contains(busqueda) 
                            || cliente.nombre.Contains(busqueda)
                            select cliente).ToList();
            dataGridView1.DataSource = listacliente;

        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            frm_AgregarCliente add = new frm_AgregarCliente();
            add.ShowDialog();
            cargardatos();
        }

        private void btcredito_Click(object sender, EventArgs e)
        {
            int fila = dataGridView1.CurrentRow.Index;
            //MessageBox.Show(listacliente[fila].nombre);
            
            frm_Creditos cre = new frm_Creditos();
            cre.cli = listacliente[fila];

            cre.ShowDialog();
            cargardatos();
        }

        private void verCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_verCreditos cre = new frm_verCreditos();
            int fila = dataGridView1.CurrentRow.Index;
            //MessageBox.Show(listacliente[fila].nombre);
            cre.cli = listacliente[fila];
            if (listacliente[fila].creditos.ToList().Count == 0)
            {
                MessageBox.Show("Este cliente no tiene creditos", "No hay creditos",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            cre.ShowDialog();
        }

        private void ctbusqueda_TextChanged(object sender, EventArgs e)
        {
            if (ctbusqueda.Text.Trim().Length == 0)
            {
                cargardatos();
            }
            else
            {
                cargardatos(ctbusqueda.Text);
            }
        }
    }
}
