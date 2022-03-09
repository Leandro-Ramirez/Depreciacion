#region Usos
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Dominios.Activo
{
    internal class Activos
    {
        #region Variables
        string Tipo;
        string Nombre;
        string Descripcion;
        double Valor;
        int VidaU;
        #endregion

        #region Get & Set
        public string Tipos { get => Tipo; set => Tipo = value; }
        public string Nombres { get => Nombre; set => Nombre = value; }
        public string Descripciones { get => Descripcion; set => Descripcion = value; }
        public double Valores { get => Valor; set => Valor = value; }
        public int VidaUs { get => VidaU; set => VidaU = value; }
        #endregion

        #region Especificando Datos de los Activos 
        public Activos()
        {
            Tipos = "";
            Nombres = "";
            Descripciones = "";
            Valores = 0.00;
            VidaUs = 0;
        }
        #endregion

        #region Determinar los Datos de los Activos
        public Activos(string Tipo, string Nombre, string Descripcion, double Valor, int VidaU)
        {
            Tipos = Tipo;
            Nombres = Nombre;
            Descripciones = Descripcion;
            Valores = Valor;
            VidaUs = VidaU;
        }
        #endregion
    }
}