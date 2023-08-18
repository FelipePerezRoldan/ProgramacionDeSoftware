using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPractica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Metodos Propios
        private void Mensaje (String texto)
        {
            this.txtMsj.Text = texto;
        }  
        private void llenarCombo()
        {
            this.cmbTipoEst.Items.Add("Seleccione un tipo de estudiante"); //Index=0
            this.cmbTipoEst.Items.Add("Pregrado");//Index=1
            this.cmbTipoEst.Items.Add("Postgrado");//Index=2
            this.cmbTipoEst.SelectedIndex = 0;
        }
        private void limpiar()
        {
            this.txtMsj.Text = string.Empty;
            this.cmbTipoEst.SelectedIndex = 0;
            this.txtCarne.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtPromedio.Text = string.Empty;
            this.txtnroCred.Text = string.Empty;
            this.txtCarne.Text = string.Empty;
            this.txtCarne.Text = string.Empty;
            this.txtCarne.Text = string.Empty;
            this.groupBox1.Visible = false;
            this.cmbTipoEst.Focus();
        }
        #endregion

        private void btnTerminar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int carne, tipoE;
            String nombre;
            float pNota;
            try
            {
                Mensaje("");
                //caputura de datos
                tipoE = this.cmbTipoEst.SelectedIndex;
                if (tipoE <= 0)
                {
                    Mensaje("Tipo de estudiante no valido");
                    this.cmbTipoEst.Focus();
                    return;
                }
                nombre = this.txtNombre.Text.Trim();
                carne = Convert.ToInt16(this.txtCarne.Text);
                pNota = Convert.ToSingle(this.txtPromedio.Text);
                //crear el objeto
                clsOpeUniversidad oP = new clsOpeUniversidad();
                //enviar info
                oP.tipoestudiante = tipoE;
                //invocar el metodo y tratamiento del error
                if (!oP.hallarPago())
                {
                    Mensaje(oP.Error);
                    oP = null;
                    return;
                }
                //recuperar info
                this.txtnroCred.Text = oP.numCreditos.ToString();
                this.txtVrCred.Text = oP.valorCredito.ToString();
                this.txtDscto.Text = oP.Descuento.ToString();
                this.VrPagar.Text = oP.valorPago.ToString();
                oP = null;
                this.gpbRpta.Visible = true;
            }
            catch (Exception ex)
            {

                Mensaje(ex.Message);
            }
        }
    }
}
