using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NegocioDiscografica;
using Modelos;

namespace Proyecto_app_discos
{
    public partial class FrmAgregarDisco : Form
    {
        public FrmAgregarDisco()
        {
            InitializeComponent();
        }

        private void FrmAgregarDisco_Load(object sender, EventArgs e)
        {
            Discografica discografica = new Discografica();
            cmbEdicion.DataSource = discografica.listaEdiciones();
            cmbEstilo.DataSource = discografica.listaEstilos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Discos nuevoDisco = new Discos();
            Discografica discografica = new Discografica();
            try
            {
                nuevoDisco.Titulo = tbxTitulo.Text;
                nuevoDisco.Url = tbxUrlAlbun.Text;
                nuevoDisco.Canciones = int.Parse(tbxCantCanciones.Text);
                nuevoDisco.FechaLanzamiento = dtpFechaLanzamiento.Value;
                nuevoDisco.Estilo = (Estilos) cmbEstilo.SelectedItem;
                nuevoDisco.Edicion = (Edicion) cmbEdicion.SelectedItem;
                MessageBox.Show($"{nuevoDisco.Titulo}',{nuevoDisco.FechaLanzamiento},{nuevoDisco.Canciones},'{nuevoDisco.Url}',{nuevoDisco.Estilo.Id}, {nuevoDisco.Edicion.Id}");


                discografica.agregarDisco(nuevoDisco);
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
