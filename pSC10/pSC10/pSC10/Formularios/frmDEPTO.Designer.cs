
namespace pSC10
{
    partial class frmDEPTO
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDEPTO = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFabrica = new System.Windows.Forms.TextBox();
            this.btnDEPTO = new System.Windows.Forms.Button();
            this.btnFabrica = new System.Windows.Forms.Button();
            this.lblFabrica = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = " Maestro Departamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(160, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = " Codigo Departamento ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(160, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = " Nombre Departamento ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(160, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = " Codigo De Fabrica ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDEPTO
            // 
            this.txtDEPTO.Location = new System.Drawing.Point(424, 160);
            this.txtDEPTO.Multiline = true;
            this.txtDEPTO.Name = "txtDEPTO";
            this.txtDEPTO.Size = new System.Drawing.Size(112, 25);
            this.txtDEPTO.TabIndex = 8;
            this.txtDEPTO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDEPTO_KeyDown);
            this.txtDEPTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDEPTO_KeyPress);
            this.txtDEPTO.Leave += new System.EventHandler(this.txtDEPTO_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(424, 192);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(544, 25);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtFabrica
            // 
            this.txtFabrica.Location = new System.Drawing.Point(424, 224);
            this.txtFabrica.Multiline = true;
            this.txtFabrica.Name = "txtFabrica";
            this.txtFabrica.Size = new System.Drawing.Size(112, 25);
            this.txtFabrica.TabIndex = 10;
            this.txtFabrica.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFabrica_KeyDown);
            this.txtFabrica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFabrica_KeyPress);
            this.txtFabrica.Leave += new System.EventHandler(this.txtFabrica_Leave);
            // 
            // btnDEPTO
            // 
            this.btnDEPTO.Location = new System.Drawing.Point(536, 160);
            this.btnDEPTO.Name = "btnDEPTO";
            this.btnDEPTO.Size = new System.Drawing.Size(48, 26);
            this.btnDEPTO.TabIndex = 11;
            this.btnDEPTO.Text = "...";
            this.btnDEPTO.UseVisualStyleBackColor = true;
            this.btnDEPTO.Click += new System.EventHandler(this.btnDEPTO_Click);
            // 
            // btnFabrica
            // 
            this.btnFabrica.Location = new System.Drawing.Point(536, 224);
            this.btnFabrica.Name = "btnFabrica";
            this.btnFabrica.Size = new System.Drawing.Size(48, 26);
            this.btnFabrica.TabIndex = 12;
            this.btnFabrica.Text = "...";
            this.btnFabrica.UseVisualStyleBackColor = true;
            this.btnFabrica.Click += new System.EventHandler(this.btnFabrica_Click);
            // 
            // lblFabrica
            // 
            this.lblFabrica.BackColor = System.Drawing.Color.White;
            this.lblFabrica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFabrica.Location = new System.Drawing.Point(592, 224);
            this.lblFabrica.Name = "lblFabrica";
            this.lblFabrica.Size = new System.Drawing.Size(376, 24);
            this.lblFabrica.TabIndex = 13;
            this.lblFabrica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::pSC10.Properties.Resources.exit;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSalir.Location = new System.Drawing.Point(976, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 88);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::pSC10.Properties.Resources.editdelete;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBorrar.Location = new System.Drawing.Point(848, 8);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(120, 88);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::pSC10.Properties.Resources.filenew;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLimpiar.Location = new System.Drawing.Point(720, 8);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 88);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::pSC10.Properties.Resources.filesave;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnGuardar.Location = new System.Drawing.Point(592, 8);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 88);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmDEPTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 353);
            this.Controls.Add(this.lblFabrica);
            this.Controls.Add(this.btnFabrica);
            this.Controls.Add(this.btnDEPTO);
            this.Controls.Add(this.txtFabrica);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDEPTO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Name = "frmDEPTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDEPTO";
            this.Load += new System.EventHandler(this.frmDEPTO_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDEPTO_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDEPTO;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFabrica;
        private System.Windows.Forms.Button btnDEPTO;
        private System.Windows.Forms.Button btnFabrica;
        private System.Windows.Forms.Label lblFabrica;
    }
}