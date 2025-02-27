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
            LecturaDiscos lecturaDiscos = new LecturaDiscos();
            listaDiscos = lecturaDiscos.Listar();
            dgvDiscos.DataSource = listaDiscos;
            dgvDiscos.Columns["Url"].Visible = false;
            cargarImagen(listaDiscos[0].Url);

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
    }
}
