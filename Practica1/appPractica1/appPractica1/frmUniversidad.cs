using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libOpeUniversidad;

namespace appPractica1
{
    public partial class frmUniversidad : Form
    {
        public frmUniversidad()
        {
            InitializeComponent();
        }
        #region "Metodos propios"
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Mensaje(String texto)
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
            this.txtNroCred.Text = string.Empty;
            this.txtCarne.Text = string.Empty;
            this.txtCarne.Text = string.Empty;
            this.txtCarne.Text = string.Empty;
            this.cmbTipoEst.Visible = false;
            this.cmbTipoEst.Focus();
        }
        #endregion

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
                oP.tipoEstudiante = tipoE;
                //invocar el metodo y tratamiento del error
                if (!oP.hallarPago())
                {
                    Mensaje(oP.Error);
                    oP = null;
                    return;
                }
                //recuperar info
                this.txtNroCred.Text = oP.numCreditos().ToString();
                this.txtVrCred.Text = oP.valorCredito().ToString();
                this.txtDscto.Text = oP.Descuento().ToString();
                this.txtVrPagar.Text = oP.valorPago().ToString();
                oP = null;
                this.gpbRpta.Visible = true;
            }
            catch (Exception ex)
            {

                Mensaje(ex.Message);
            }
        }

        private void cmbTipoEst_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarCombo();
        }

        private void btnTerminar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
