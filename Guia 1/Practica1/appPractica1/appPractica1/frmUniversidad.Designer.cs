
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
            this.textCarne = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textPromedio = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gpbRpta = new System.Windows.Forms.GroupBox();
            this.txtNroCred = new System.Windows.Forms.TextBox();
            this.textVrCred = new System.Windows.Forms.TextBox();
            this.textDscto = new System.Windows.Forms.TextBox();
            this.textVrPagar = new System.Windows.Forms.TextBox();
            this.textMsj = new System.Windows.Forms.TextBox();
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
            // textCarne
            // 
            this.textCarne.Location = new System.Drawing.Point(148, 132);
            this.textCarne.Name = "textCarne";
            this.textCarne.Size = new System.Drawing.Size(263, 20);
            this.textCarne.TabIndex = 10;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(148, 164);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(263, 20);
            this.textNombre.TabIndex = 11;
            // 
            // textPromedio
            // 
            this.textPromedio.Location = new System.Drawing.Point(148, 198);
            this.textPromedio.Name = "textPromedio";
            this.textPromedio.Size = new System.Drawing.Size(263, 20);
            this.textPromedio.TabIndex = 12;
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
            // 
            // gpbRpta
            // 
            this.gpbRpta.Controls.Add(this.textVrPagar);
            this.gpbRpta.Controls.Add(this.textDscto);
            this.gpbRpta.Controls.Add(this.textVrCred);
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
            // 
            // txtNroCred
            // 
            this.txtNroCred.Location = new System.Drawing.Point(107, 19);
            this.txtNroCred.Name = "txtNroCred";
            this.txtNroCred.ReadOnly = true;
            this.txtNroCred.Size = new System.Drawing.Size(71, 20);
            this.txtNroCred.TabIndex = 17;
            // 
            // textVrCred
            // 
            this.textVrCred.Location = new System.Drawing.Point(292, 19);
            this.textVrCred.Name = "textVrCred";
            this.textVrCred.ReadOnly = true;
            this.textVrCred.Size = new System.Drawing.Size(71, 20);
            this.textVrCred.TabIndex = 18;
            // 
            // textDscto
            // 
            this.textDscto.Location = new System.Drawing.Point(292, 56);
            this.textDscto.Name = "textDscto";
            this.textDscto.ReadOnly = true;
            this.textDscto.Size = new System.Drawing.Size(71, 20);
            this.textDscto.TabIndex = 19;
            // 
            // textVrPagar
            // 
            this.textVrPagar.Location = new System.Drawing.Point(292, 94);
            this.textVrPagar.Name = "textVrPagar";
            this.textVrPagar.ReadOnly = true;
            this.textVrPagar.Size = new System.Drawing.Size(71, 20);
            this.textVrPagar.TabIndex = 20;
            // 
            // textMsj
            // 
            this.textMsj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMsj.Location = new System.Drawing.Point(14, 464);
            this.textMsj.Multiline = true;
            this.textMsj.Name = "textMsj";
            this.textMsj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMsj.Size = new System.Drawing.Size(263, 20);
            this.textMsj.TabIndex = 17;
            this.textMsj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // 
            // frmUniversidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 525);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.textMsj);
            this.Controls.Add(this.gpbRpta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.textPromedio);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textCarne);
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
        private System.Windows.Forms.TextBox textCarne;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textPromedio;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gpbRpta;
        private System.Windows.Forms.TextBox textVrPagar;
        private System.Windows.Forms.TextBox textDscto;
        private System.Windows.Forms.TextBox textVrCred;
        private System.Windows.Forms.TextBox txtNroCred;
        private System.Windows.Forms.TextBox textMsj;
        private System.Windows.Forms.Button btnTerminar;
    }
}

