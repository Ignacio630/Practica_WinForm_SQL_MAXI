using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using NegocioDiscografica;

namespace Proyecto_app_discos
{
    public partial class FrmAppDiscos : Form
    {
        private List<Discos> listaDiscos = new List<Discos>();
        public FrmAppDiscos()
        {
            InitializeComponent();

        }

        private void FrmAppDiscos_Load(object sender, EventArgs e)
        {
            cargar_datos();
        }
        private void cargar_datos()
        {
            Discografica discografica = new Discografica();
            listaDiscos = discografica.listarDiscos();
            dgvDiscos.DataSource = listaDiscos;
            dgvDiscos.Refresh();
            dgvDiscos.Columns["Url"].Visible = false;
        }
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Discos selectDisc = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                cargarImagen(selectDisc.Url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string url)
        {
            try
            {
                pbxTapaDisco.Load(url);

            }
            catch (Exception ex)
            { 
                pbxTapaDisco.Load("https://static-00.iconduck.com/assets.00/image-not-found-02-icon-2048x2048-ij4lngoq.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarDisco agregarDisco = new FrmAgregarDisco();
            agregarDisco.FormClosed += new FormClosedEventHandler(this.AgregarDisco_FormClosed);
            agregarDisco.ShowDialog();
        }
        private void AgregarDisco_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargar_datos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarDisco eliminarDisco = new FrmEliminarDisco();
            eliminarDisco.FormClosed += new FormClosedEventHandler(this.EliminarForm_FormClosed);
            eliminarDisco.ShowDialog();
        }
        private void EliminarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargar_datos();
        }
    }
}
