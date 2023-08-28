
namespace appPractica1
{
    partial class frmUniversidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelReglasDeNegocio = new System.Windows.Forms.Label();
            this.labelTipoEstudiante = new System.Windows.Forms.Label();
            this.labelCarné = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPromedio = new System.Windows.Forms.Label();
            this.labelVrAPagar = new System.Windows.Forms.Label();
            this.labelVrDscto = new System.Windows.Forms.Label();
            this.labelVrCrédito = new System.Windows.Forms.Label();
            this.labelNroCréditos = new System.Windows.Forms.Label();
            this.cmbTipoEst = new System.Windows.Forms.ComboBox();
            this.txtCarne = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpbRpta = new System.Windows.Forms.GroupBox();
            this.txtVrPagar = new System.Windows.Forms.TextBox();
            this.txtDscto = new System.Windows.Forms.TextBox();
            this.txtVrCred = new System.Windows.Forms.TextBox();
            this.txtNroCred = new System.Windows.Forms.TextBox();
            this.txtMsj = new System.Windows.Forms.TextBox();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.gpbRpta.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelReglasDeNegocio
            // 
            this.labelReglasDeNegocio.AutoSize = true;
            this.labelReglasDeNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReglasDeNegocio.Location = new System.Drawing.Point(98, 28);
            this.labelReglasDeNegocio.Name = "labelReglasDeNegocio";
            this.labelReglasDeNegocio.Size = new System.Drawing.Size(260, 31);
            this.labelReglasDeNegocio.TabIndex = 0;
            this.labelReglasDeNegocio.Text = "Reglas de Negocio";
            // 
            // labelTipoEstudiante
            // 
            this.labelTipoEstudiante.AutoSize = true;
            this.labelTipoEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoEstudiante.Location = new System.Drawing.Point(11, 106);
            this.labelTipoEstudiante.Name = "labelTipoEstudiante";
            this.labelTipoEstudiante.Size = new System.Drawing.Size(131, 17);
            this.labelTipoEstudiante.TabIndex = 1;
            this.labelTipoEstudiante.Text = "Tipo de Estudiante:";
            // 
            // labelCarné
            // 
            this.labelCarné.AutoSize = true;
            this.labelCarné.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarné.Location = new System.Drawing.Point(92, 135);
            this.labelCarné.Name = "labelCarné";
            this.labelCarné.Size = new System.Drawing.Size(50, 17);
            this.labelCarné.TabIndex = 2;
            this.labelCarné.Text = "Carné:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(80, 165);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(62, 17);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelPromedio
            // 
            this.labelPromedio.AutoSize = true;
            this.labelPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromedio.Location = new System.Drawing.Point(70, 199);
            this.labelPromedio.Name = "labelPromedio";
            this.labelPromedio.Size = new System.Drawing.Size(72, 17);
            this.labelPromedio.TabIndex = 4;
            this.labelPromedio.Text = "Promedio:";
            // 
            // labelVrAPagar
            // 
            this.labelVrAPagar.AutoSize = true;
            this.labelVrAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVrAPagar.Location = new System.Drawing.Point(206, 94);
            this.labelVrAPagar.Name = "labelVrAPagar";
            this.labelVrAPagar.Size = new System.Drawing.Size(80, 17);
            this.labelVrAPagar.TabIndex = 8;
            this.labelVrAPagar.Text = "Vr a Pagar:";
            // 
            // labelVrDscto
            // 
            this.labelVrDscto.AutoSize = true;
            this.labelVrDscto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVrDscto.Location = new System.Drawing.Point(216, 56);
            this.labelVrDscto.Name = "labelVrDscto";
            this.labelVrDscto.Size = new System.Drawing.Size(70, 17);
            this.labelVrDscto.TabIndex = 7;
            this.labelVrDscto.Text = "Vr. Dscto:";
            // 
            // labelVrCrédito
            // 
            this.labelVrCrédito.AutoSize = true;
            this.labelVrCrédito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVrCrédito.Location = new System.Drawing.Point(207, 16);
            this.labelVrCrédito.Name = "labelVrCrédito";
            this.labelVrCrédito.Size = new System.Drawing.Size(79, 17);
            this.labelVrCrédito.TabIndex = 6;
            this.labelVrCrédito.Text = "Vr. Crédito:";
            // 
            // labelNroCréditos
            // 
            this.labelNroCréditos.AutoSize = true;
            this.labelNroCréditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroCréditos.Location = new System.Drawing.Point(6, 19);
            this.labelNroCréditos.Name = "labelNroCréditos";
            this.labelNroCréditos.Size = new System.Drawing.Size(95, 17);
            this.labelNroCréditos.TabIndex = 5;
            this.labelNroCréditos.Text = "Nro. Créditos:";
            // 
            // cmbTipoEst
            // 
            this.cmbTipoEst.FormattingEnabled = true;
            this.cmbTipoEst.Location = new System.Drawing.Point(148, 102);
            this.cmbTipoEst.Name = "cmbTipoEst";
            this.cmbTipoEst.Size = new System.Drawing.Size(263, 21);
            this.cmbTipoEst.TabIndex = 9;
            // 
            // txtCarne
            // 
            this.txtCarne.Location = new System.Drawing.Point(148, 132);
            this.txtCarne.Name = "txtCarne";
            this.txtCarne.Size = new System.Drawing.Size(263, 20);
            this.txtCarne.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(148, 164);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(148, 198);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(263, 20);
            this.txtPromedio.TabIndex = 12;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(250, 243);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(108, 43);
            this.btnProcesar.TabIndex = 14;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(73, 243);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 43);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gpbRpta
            // 
            this.gpbRpta.Controls.Add(this.txtVrPagar);
            this.gpbRpta.Controls.Add(this.txtDscto);
            this.gpbRpta.Controls.Add(this.txtVrCred);
            this.gpbRpta.Controls.Add(this.txtNroCred);
            this.gpbRpta.Controls.Add(this.labelNroCréditos);
            this.gpbRpta.Controls.Add(this.labelVrCrédito);
            this.gpbRpta.Controls.Add(this.labelVrDscto);
            this.gpbRpta.Controls.Add(this.labelVrAPagar);
            this.gpbRpta.Location = new System.Drawing.Point(14, 315);
            this.gpbRpta.Name = "gpbRpta";
            this.gpbRpta.Size = new System.Drawing.Size(397, 125);
            this.gpbRpta.TabIndex = 16;
            this.gpbRpta.TabStop = false;
            this.gpbRpta.Visible = false;
            // 
            // txtVrPagar
            // 
            this.txtVrPagar.Location = new System.Drawing.Point(292, 94);
            this.txtVrPagar.Name = "txtVrPagar";
            this.txtVrPagar.ReadOnly = true;
            this.txtVrPagar.Size = new System.Drawing.Size(71, 20);
            this.txtVrPagar.TabIndex = 20;
            // 
            // txtDscto
            // 
            this.txtDscto.Location = new System.Drawing.Point(292, 56);
            this.txtDscto.Name = "txtDscto";
            this.txtDscto.ReadOnly = true;
            this.txtDscto.Size = new System.Drawing.Size(71, 20);
            this.txtDscto.TabIndex = 19;
            // 
            // txtVrCred
            // 
            this.txtVrCred.Location = new System.Drawing.Point(292, 19);
            this.txtVrCred.Name = "txtVrCred";
            this.txtVrCred.ReadOnly = true;
            this.txtVrCred.Size = new System.Drawing.Size(71, 20);
            this.txtVrCred.TabIndex = 18;
            // 
            // txtNroCred
            // 
            this.txtNroCred.Location = new System.Drawing.Point(107, 19);
            this.txtNroCred.Name = "txtNroCred";
            this.txtNroCred.ReadOnly = true;
            this.txtNroCred.Size = new System.Drawing.Size(71, 20);
            this.txtNroCred.TabIndex = 17;
            // 
            // txtMsj
            // 
            this.txtMsj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsj.Location = new System.Drawing.Point(14, 464);
            this.txtMsj.Multiline = true;
            this.txtMsj.Name = "txtMsj";
            this.txtMsj.ReadOnly = true;
            this.txtMsj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsj.Size = new System.Drawing.Size(263, 43);
            this.txtMsj.TabIndex = 17;
            this.txtMsj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(303, 464);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(108, 43);
            this.btnTerminar.TabIndex = 18;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click_1);
            // 
            // frmUniversidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 525);
            this.ControlBox = false;
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.txtMsj);
            this.Controls.Add(this.gpbRpta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCarne);
            this.Controls.Add(this.cmbTipoEst);
            this.Controls.Add(this.labelPromedio);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCarné);
            this.Controls.Add(this.labelTipoEstudiante);
            this.Controls.Add(this.labelReglasDeNegocio);
            this.Name = "frmUniversidad";
            this.Text = "Práctica # 1 - Reglas de Negocio";
            this.gpbRpta.ResumeLayout(false);
            this.gpbRpta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReglasDeNegocio;
        private System.Windows.Forms.Label labelTipoEstudiante;
        private System.Windows.Forms.Label labelCarné;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPromedio;
        private System.Windows.Forms.Label labelVrAPagar;
        private System.Windows.Forms.Label labelVrDscto;
        private System.Windows.Forms.Label labelVrCrédito;
        private System.Windows.Forms.Label labelNroCréditos;
        private System.Windows.Forms.ComboBox cmbTipoEst;
        private System.Windows.Forms.TextBox txtCarne;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpbRpta;
        private System.Windows.Forms.TextBox txtVrPagar;
        private System.Windows.Forms.TextBox txtDscto;
        private System.Windows.Forms.TextBox txtVrCred;
        private System.Windows.Forms.TextBox txtNroCred;
        private System.Windows.Forms.TextBox txtMsj;
        private System.Windows.Forms.Button btnTerminar;
    }
}

