
namespace pSC10
{
    partial class frmMVTOCTE
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCol01 = new System.Windows.Forms.Label();
            this.lblCol02 = new System.Windows.Forms.Label();
            this.lblCol03 = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1016, 8);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(168, 64);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1192, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(176, 64);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(840, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(168, 64);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(824, 64);
            this.label1.TabIndex = 8;
            this.label1.Text = " Movimientos de Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(216, 96);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(144, 25);
            this.txtCliente.TabIndex = 5;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(16, 224);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1344, 432);
            this.dgv.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = " Codigo de Cliente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCol01
            // 
            this.lblCol01.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCol01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCol01.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCol01.Location = new System.Drawing.Point(744, 664);
            this.lblCol01.Name = "lblCol01";
            this.lblCol01.Size = new System.Drawing.Size(192, 32);
            this.lblCol01.TabIndex = 14;
            this.lblCol01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCol02
            // 
            this.lblCol02.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCol02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCol02.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCol02.Location = new System.Drawing.Point(944, 664);
            this.lblCol02.Name = "lblCol02";
            this.lblCol02.Size = new System.Drawing.Size(192, 32);
            this.lblCol02.TabIndex = 15;
            this.lblCol02.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCol03
            // 
            this.lblCol03.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCol03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCol03.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCol03.Location = new System.Drawing.Point(1144, 664);
            this.lblCol03.Name = "lblCol03";
            this.lblCol03.Size = new System.Drawing.Size(192, 32);
            this.lblCol03.TabIndex = 16;
            this.lblCol03.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblNombreCliente.Location = new System.Drawing.Point(16, 128);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(416, 25);
            this.lblNombreCliente.TabIndex = 17;
            this.lblNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(360, 95);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(40, 28);
            this.btnCliente.TabIndex = 18;
            this.btnCliente.Text = "...";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDireccion.Location = new System.Drawing.Point(16, 160);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(416, 25);
            this.lblDireccion.TabIndex = 19;
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCiudad
            // 
            this.lblCiudad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCiudad.Location = new System.Drawing.Point(16, 192);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(416, 25);
            this.lblCiudad.TabIndex = 20;
            this.lblCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContacto
            // 
            this.lblContacto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblContacto.Location = new System.Drawing.Point(456, 160);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(376, 25);
            this.lblContacto.TabIndex = 21;
            this.lblContacto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Contacto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTelefono.Location = new System.Drawing.Point(456, 192);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(376, 25);
            this.txtTelefono.TabIndex = 23;
            this.txtTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMVTOCTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 739);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblCol03);
            this.Controls.Add(this.lblCol02);
            this.Controls.Add(this.lblCol01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dgv);
            this.Name = "frmMVTOCTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMVTOCTE";
            this.Load += new System.EventHandler(this.frmMVTOCTE_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMVTOCTE_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCol01;
        private System.Windows.Forms.Label lblCol02;
        private System.Windows.Forms.Label lblCol03;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTelefono;
    }
}