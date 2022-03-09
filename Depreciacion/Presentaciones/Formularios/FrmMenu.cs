#region Usos
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Presentaciones.Formularios
{
    public partial class FrmMenu : Form
    {
        #region Inicializar Componente FrmMenu
        public FrmMenu()
        {
            InitializeComponent();
        }
        #endregion

        #region Boton Siguiente Click
        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDatos Datos = new FrmDatos();
            Datos.Show();
        }
        #endregion
    }
}
