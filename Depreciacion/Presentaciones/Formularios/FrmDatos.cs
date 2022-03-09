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
        #region Inicializar Componente FrmDatos
        public FrmDatos()
        {
            InitializeComponent();
        }
        #endregion

        #region Boton Salir Click
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        #endregion

        #region Boton Salir Calculo Click
        private void BtnSalirR_Click(object sender, EventArgs e)
        {
            Salir();
        }
        #endregion

        #region Metodo Salir
        public void Salir()
        {
            this.Close();
        }
        #endregion
    }
}