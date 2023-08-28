using libOpeUniversidad;
using System;
using System.Windows.Forms;

namespace appPractica1
{
    public partial class frmUniversidad : Form
    {
        public frmUniversidad()
        {
            InitializeComponent();
            llenarCombo();
        }
        #region "Metodos propios"

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
            foreach (Control control in this.Controls) // Limpiar con foreach
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty; 
                }
            }
            //this.txtMsj.Text = string.Empty;
            //this.cmbTipoEst.SelectedIndex = 0;
            //this.txtCarne.Text = string.Empty;
            //this.txtNombre.Text = string.Empty;
            //this.txtPromedio.Text = string.Empty;
            //this.txtNroCred.Text = string.Empty;
            //this.txtCarne.Text = string.Empty;
            //this.txtCarne.Text = string.Empty;
            //this.txtCarne.Text = string.Empty;
            this.gpbRpta.Visible = false;
            this.cmbTipoEst.Focus();
        }
        #endregion
        private void btnTerminar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnProcesar_Click_1(object sender, EventArgs e)
        {
            int carne, tipoE;
            String nombre;
            float pNota;
            try
            {
                Mensaje("");
                //caputura de datos
                tipoE = this.cmbTipoEst.SelectedIndex;
                if (tipoE != 1 && tipoE !=2)
                {
                    Mensaje("Tipo de estudiante no valido");
                    this.cmbTipoEst.Focus();
                    return;
                }
                nombre = this.txtNombre.Text.Trim();
                carne = Convert.ToInt32(this.txtCarne.Text);
                pNota = Convert.ToSingle(this.txtPromedio.Text);
                //crear el objeto
                clsOpeUniversidad oP = new clsOpeUniversidad();
                //enviar info
                oP.tipoEstudiante = tipoE;
                oP.Promedio = pNota;
                //invocar el metodo y tratamiento del error
                if (!oP.hallarPago())
                {
                    Mensaje(oP.Error);
                    oP = null;
                    this.gpbRpta.Visible = false;
                    return;
                }
                //recuperar info
                this.txtNroCred.Text = oP.numCreditos.ToString();
                this.txtVrCred.Text = oP.valorCred.ToString();
                this.txtDscto.Text = oP.Descuento.ToString();
                this.txtVrPagar.Text = oP.valorPago.ToString();
                oP = null;
                this.gpbRpta.Visible = true;
            }
            catch (Exception ex)
            {
                Mensaje(ex.Message);
                this.gpbRpta.Visible = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }



    }
}
