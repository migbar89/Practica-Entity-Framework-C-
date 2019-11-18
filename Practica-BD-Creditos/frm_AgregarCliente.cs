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
    public partial class frm_AgregarCliente : Form
    {
        creditosEntities1 bd;
        public frm_AgregarCliente()
        {
            InitializeComponent();
        }

        private void frm_AgregarCliente_Load(object sender, EventArgs e)
        {
            bd = new creditosEntities1();
        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      // https://codeshare.io/2WZjwE
        private void btguardar_Click(object sender, EventArgs e)
        {
            //Crear objeto de tipo cliente
            cliente cli = new cliente();

            //Agregar datos al objeto
            cli.nombre = ctnombre.Text;
            cli.apellido = ctapellido.Text;
            cli.correo = ctcorreo.Text;
            cli.direccion = ctdireccion.Text;
            cli.telefono = cttelefono.Text;
            cli.edad = int.Parse(ctedad.Text);
            bd.cliente.Add(cli);
            bd.SaveChanges();
         }
    }
}
