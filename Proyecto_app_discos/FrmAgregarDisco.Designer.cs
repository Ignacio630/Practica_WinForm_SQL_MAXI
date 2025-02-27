namespace Proyecto_app_discos
{
    partial class FrmAgregarDisco
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFachaLanzamiento = new System.Windows.Forms.Label();
            this.lblCantCanciones = new System.Windows.Forms.Label();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblUrlAlbun = new System.Windows.Forms.Label();
            this.cmbEstilo = new System.Windows.Forms.ComboBox();
            this.cmbEdicion = new System.Windows.Forms.ComboBox();
            this.tbxUrlAlbun = new System.Windows.Forms.TextBox();
            this.tbxCantCanciones = new System.Windows.Forms.TextBox();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(37, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblFachaLanzamiento
            // 
            this.lblFachaLanzamiento.AutoSize = true;
            this.lblFachaLanzamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFachaLanzamiento.Location = new System.Drawing.Point(37, 103);
            this.lblFachaLanzamiento.Name = "lblFachaLanzamiento";
            this.lblFachaLanzamiento.Size = new System.Drawing.Size(120, 16);
            this.lblFachaLanzamiento.TabIndex = 1;
            this.lblFachaLanzamiento.Text = "Fecha lanzamiento";
            // 
            // lblCantCanciones
            // 
            this.lblCantCanciones.AutoSize = true;
            this.lblCantCanciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCanciones.Location = new System.Drawing.Point(37, 147);
            this.lblCantCanciones.Name = "lblCantCanciones";
            this.lblCantCanciones.Size = new System.Drawing.Size(147, 16);
            this.lblCantCanciones.TabIndex = 2;
            this.lblCantCanciones.Text = "Cantidad de Canciones";
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdicion.Location = new System.Drawing.Point(37, 291);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(52, 16);
            this.lblEdicion.TabIndex = 3;
            this.lblEdicion.Text = "Edicion";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstilo.Location = new System.Drawing.Point(37, 241);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(40, 16);
            this.lblEstilo.TabIndex = 4;
            this.lblEstilo.Text = "Estilo";
            // 
            // lblUrlAlbun
            // 
            this.lblUrlAlbun.AutoSize = true;
            this.lblUrlAlbun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrlAlbun.Location = new System.Drawing.Point(37, 191);
            this.lblUrlAlbun.Name = "lblUrlAlbun";
            this.lblUrlAlbun.Size = new System.Drawing.Size(89, 16);
            this.lblUrlAlbun.TabIndex = 5;
            this.lblUrlAlbun.Text = "Imagen Albun";
            // 
            // cmbEstilo
            // 
            this.cmbEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstilo.FormattingEnabled = true;
            this.cmbEstilo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbEstilo.Location = new System.Drawing.Point(40, 267);
            this.cmbEstilo.Name = "cmbEstilo";
            this.cmbEstilo.Size = new System.Drawing.Size(200, 21);
            this.cmbEstilo.TabIndex = 6;
            // 
            // cmbEdicion
            // 
            this.cmbEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdicion.FormattingEnabled = true;
            this.cmbEdicion.Location = new System.Drawing.Point(40, 310);
            this.cmbEdicion.Name = "cmbEdicion";
            this.cmbEdicion.Size = new System.Drawing.Size(200, 21);
            this.cmbEdicion.TabIndex = 7;
            // 
            // tbxUrlAlbun
            // 
            this.tbxUrlAlbun.Location = new System.Drawing.Point(40, 218);
            this.tbxUrlAlbun.Name = "tbxUrlAlbun";
            this.tbxUrlAlbun.Size = new System.Drawing.Size(200, 20);
            this.tbxUrlAlbun.TabIndex = 8;
            // 
            // tbxCantCanciones
            // 
            this.tbxCantCanciones.Location = new System.Drawing.Point(40, 168);
            this.tbxCantCanciones.Name = "tbxCantCanciones";
            this.tbxCantCanciones.Size = new System.Drawing.Size(200, 20);
            this.tbxCantCanciones.TabIndex = 9;
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(40, 124);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaLanzamiento.TabIndex = 10;
            this.dtpFechaLanzamiento.Value = new System.DateTime(2025, 2, 27, 0, 0, 0, 0);
      
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(40, 74);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(200, 20);
            this.tbxTitulo.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(40, 372);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(165, 372);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAgregarDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbxTitulo);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.tbxCantCanciones);
            this.Controls.Add(this.tbxUrlAlbun);
            this.Controls.Add(this.cmbEdicion);
            this.Controls.Add(this.cmbEstilo);
            this.Controls.Add(this.lblUrlAlbun);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.lblCantCanciones);
            this.Controls.Add(this.lblFachaLanzamiento);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgregarDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarDisco";
            this.Load += new System.EventHandler(this.FrmAgregarDisco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFachaLanzamiento;
        private System.Windows.Forms.Label lblCantCanciones;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblUrlAlbun;
        private System.Windows.Forms.ComboBox cmbEstilo;
        private System.Windows.Forms.ComboBox cmbEdicion;
        private System.Windows.Forms.TextBox tbxUrlAlbun;
        private System.Windows.Forms.TextBox tbxCantCanciones;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}