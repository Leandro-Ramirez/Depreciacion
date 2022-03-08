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

namespace Presentaciones
{
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
        }

        #region Boton Salir Click
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}