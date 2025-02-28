using Modelos;
using NegocioDiscografica;
using SQLQuerys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_app_discos
{
    public partial class FrmEliminarDisco : Form
    {
        public FrmEliminarDisco()
        {
            InitializeComponent();
        }

        private void FrmEliminarDisco_Load(object sender, EventArgs e)
        {
            Discografica discografica = new Discografica();
            cbxDiscos.DataSource = discografica.listarDiscosSimple();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DB accesoDb = new DB();
            Discografica listaDiscos = new Discografica();

            try
            {
                Discos aux = new Discos();
                accesoDb.conectarDB();
                aux = (Discos)cbxDiscos.SelectedItem;
                while (aux != null)
                {
                    accesoDb.setConsultaDB($"delete from DISCOS where Titulo = '{aux.Titulo}'");
                    accesoDb.ejecutarConsultaDB();

                    MessageBox.Show($"El disco {aux.Titulo}");
                    this.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
