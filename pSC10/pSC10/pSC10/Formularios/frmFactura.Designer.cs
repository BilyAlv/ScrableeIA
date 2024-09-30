
namespace pSC10
{
    partial class frmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblPagaImpuesto = new System.Windows.Forms.Label();
            this.lblFechaFactura = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImpuestoLn = new System.Windows.Forms.Label();
            this.lblTotalLn = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblNombrePaga = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBorrarLn = new System.Windows.Forms.Button();
            this.btnInsertarLn = new System.Windows.Forms.Button();
            this.btnCONFACT = new System.Windows.Forms.Button();
            this.btnVENCTE = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(752, 104);
            this.label1.TabIndex = 5;
            this.label1.Text = " Facturacion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(8, 352);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1384, 280);
            this.dgv.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(904, 640);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = " Sub Total";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(904, 672);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = " Impuesto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(904, 704);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = " Total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(1136, 704);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(224, 24);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.BackColor = System.Drawing.Color.White;
            this.lblImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuesto.ForeColor = System.Drawing.Color.Black;
            this.lblImpuesto.Location = new System.Drawing.Point(1136, 672);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(224, 24);
            this.lblImpuesto.TabIndex = 16;
            this.lblImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.White;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.Black;
            this.lblSubtotal.Location = new System.Drawing.Point(1136, 640);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(224, 24);
            this.lblSubtotal.TabIndex = 15;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = " Paga Impuesto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightBlue;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = " Cliente";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightBlue;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = " Numero Factura";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightBlue;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = " Fecha Factura";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(240, 160);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(136, 24);
            this.txtCliente.TabIndex = 22;
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // lblFactura
            // 
            this.lblFactura.BackColor = System.Drawing.Color.White;
            this.lblFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.ForeColor = System.Drawing.Color.Black;
            this.lblFactura.Location = new System.Drawing.Point(240, 128);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(136, 24);
            this.lblFactura.TabIndex = 24;
            this.lblFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPagaImpuesto
            // 
            this.lblPagaImpuesto.BackColor = System.Drawing.Color.White;
            this.lblPagaImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPagaImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPagaImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagaImpuesto.ForeColor = System.Drawing.Color.Black;
            this.lblPagaImpuesto.Location = new System.Drawing.Point(240, 192);
            this.lblPagaImpuesto.Name = "lblPagaImpuesto";
            this.lblPagaImpuesto.Size = new System.Drawing.Size(136, 24);
            this.lblPagaImpuesto.TabIndex = 25;
            this.lblPagaImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.BackColor = System.Drawing.Color.White;
            this.lblFechaFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFactura.ForeColor = System.Drawing.Color.Black;
            this.lblFechaFactura.Location = new System.Drawing.Point(240, 224);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(184, 24);
            this.lblFechaFactura.TabIndex = 26;
            this.lblFechaFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(432, 160);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(576, 24);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArticulo
            // 
            this.lblArticulo.BackColor = System.Drawing.Color.White;
            this.lblArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.ForeColor = System.Drawing.Color.Black;
            this.lblArticulo.Location = new System.Drawing.Point(192, 320);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(592, 24);
            this.lblArticulo.TabIndex = 33;
            this.lblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.White;
            this.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Black;
            this.lblPrecio.Location = new System.Drawing.Point(928, 320);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(144, 24);
            this.lblPrecio.TabIndex = 34;
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImpuestoLn
            // 
            this.lblImpuestoLn.BackColor = System.Drawing.Color.White;
            this.lblImpuestoLn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImpuestoLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblImpuestoLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestoLn.ForeColor = System.Drawing.Color.Black;
            this.lblImpuestoLn.Location = new System.Drawing.Point(1072, 320);
            this.lblImpuestoLn.Name = "lblImpuestoLn";
            this.lblImpuestoLn.Size = new System.Drawing.Size(144, 24);
            this.lblImpuestoLn.TabIndex = 35;
            this.lblImpuestoLn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalLn
            // 
            this.lblTotalLn.BackColor = System.Drawing.Color.White;
            this.lblTotalLn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLn.ForeColor = System.Drawing.Color.Black;
            this.lblTotalLn.Location = new System.Drawing.Point(1216, 320);
            this.lblTotalLn.Name = "lblTotalLn";
            this.lblTotalLn.Size = new System.Drawing.Size(144, 24);
            this.lblTotalLn.TabIndex = 36;
            this.lblTotalLn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.LightBlue;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(784, 296);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 24);
            this.label19.TabIndex = 37;
            this.label19.Text = "Cantidad";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.LightBlue;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(928, 296);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 24);
            this.label20.TabIndex = 38;
            this.label20.Text = "Precio";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.LightBlue;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(1072, 296);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(144, 24);
            this.label21.TabIndex = 39;
            this.label21.Text = "Impuesto";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.LightBlue;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(1216, 296);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(144, 24);
            this.label22.TabIndex = 40;
            this.label22.Text = "Total Ln";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.LightBlue;
            this.label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(8, 296);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(184, 24);
            this.label23.TabIndex = 41;
            this.label23.Text = " Articulo";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.LightBlue;
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(192, 296);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(592, 24);
            this.label24.TabIndex = 42;
            this.label24.Text = " Descripcion";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(8, 320);
            this.txtArticulo.Multiline = true;
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(136, 24);
            this.txtArticulo.TabIndex = 43;
            this.txtArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticulo_KeyDown);
            this.txtArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArticulo_KeyPress);
            this.txtArticulo.Leave += new System.EventHandler(this.txtArticulo_Leave);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(784, 320);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(144, 24);
            this.txtCantidad.TabIndex = 44;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // lblNombrePaga
            // 
            this.lblNombrePaga.BackColor = System.Drawing.Color.White;
            this.lblNombrePaga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombrePaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombrePaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePaga.ForeColor = System.Drawing.Color.Black;
            this.lblNombrePaga.Location = new System.Drawing.Point(432, 192);
            this.lblNombrePaga.Name = "lblNombrePaga";
            this.lblNombrePaga.Size = new System.Drawing.Size(352, 24);
            this.lblNombrePaga.TabIndex = 50;
            this.lblNombrePaga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::pSC10.Properties.Resources.editdelete;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBorrar.Location = new System.Drawing.Point(1024, 8);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(120, 104);
            this.btnBorrar.TabIndex = 51;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::pSC10.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnEditar.Location = new System.Drawing.Point(176, 640);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(160, 88);
            this.btnEditar.TabIndex = 49;
            this.btnEditar.Text = " Editar Linea";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnArticulo
            // 
            this.btnArticulo.Image = global::pSC10.Properties.Resources._16__Search_;
            this.btnArticulo.Location = new System.Drawing.Point(144, 318);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(48, 28);
            this.btnArticulo.TabIndex = 48;
            this.btnArticulo.Text = "...";
            this.btnArticulo.UseVisualStyleBackColor = true;
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // button1
            // 
            this.button1.Image = global::pSC10.Properties.Resources.filenew;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(512, 640);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 88);
            this.button1.TabIndex = 47;
            this.button1.Text = "Limpiar Detalle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBorrarLn
            // 
            this.btnBorrarLn.Image = global::pSC10.Properties.Resources.delete_table_row;
            this.btnBorrarLn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBorrarLn.Location = new System.Drawing.Point(344, 640);
            this.btnBorrarLn.Name = "btnBorrarLn";
            this.btnBorrarLn.Size = new System.Drawing.Size(160, 88);
            this.btnBorrarLn.TabIndex = 46;
            this.btnBorrarLn.Text = "Borrar Linea";
            this.btnBorrarLn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBorrarLn.UseVisualStyleBackColor = true;
            this.btnBorrarLn.Click += new System.EventHandler(this.btnBorrarLn_Click);
            // 
            // btnInsertarLn
            // 
            this.btnInsertarLn.Image = global::pSC10.Properties.Resources.insert_table_row;
            this.btnInsertarLn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnInsertarLn.Location = new System.Drawing.Point(8, 640);
            this.btnInsertarLn.Name = "btnInsertarLn";
            this.btnInsertarLn.Size = new System.Drawing.Size(160, 88);
            this.btnInsertarLn.TabIndex = 45;
            this.btnInsertarLn.Text = "Insertar Linea";
            this.btnInsertarLn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnInsertarLn.UseVisualStyleBackColor = true;
            this.btnInsertarLn.Click += new System.EventHandler(this.btnInsertarLn_Click);
            // 
            // btnCONFACT
            // 
            this.btnCONFACT.Image = global::pSC10.Properties.Resources._16__Search_;
            this.btnCONFACT.Location = new System.Drawing.Point(376, 127);
            this.btnCONFACT.Name = "btnCONFACT";
            this.btnCONFACT.Size = new System.Drawing.Size(48, 26);
            this.btnCONFACT.TabIndex = 28;
            this.btnCONFACT.Text = "...";
            this.btnCONFACT.UseVisualStyleBackColor = true;
            this.btnCONFACT.Click += new System.EventHandler(this.btnCONFACT_Click);
            // 
            // btnVENCTE
            // 
            this.btnVENCTE.Image = global::pSC10.Properties.Resources._16__Search_;
            this.btnVENCTE.Location = new System.Drawing.Point(376, 159);
            this.btnVENCTE.Name = "btnVENCTE";
            this.btnVENCTE.Size = new System.Drawing.Size(48, 26);
            this.btnVENCTE.TabIndex = 23;
            this.btnVENCTE.Text = "...";
            this.btnVENCTE.UseVisualStyleBackColor = true;
            this.btnVENCTE.Click += new System.EventHandler(this.btnVENCTE_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::pSC10.Properties.Resources.exit;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSalir.Location = new System.Drawing.Point(1280, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 104);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::pSC10.Properties.Resources.fileprint;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnImprimir.Location = new System.Drawing.Point(1152, 8);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(120, 104);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = " Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::pSC10.Properties.Resources.filenew;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLimpiar.Location = new System.Drawing.Point(896, 8);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 104);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::pSC10.Properties.Resources.filesave;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnGuardar.Location = new System.Drawing.Point(768, 8);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 104);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Imprimir";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 761);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblNombrePaga);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnArticulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBorrarLn);
            this.Controls.Add(this.btnInsertarLn);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblTotalLn);
            this.Controls.Add(this.lblImpuestoLn);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.btnCONFACT);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFechaFactura);
            this.Controls.Add(this.lblPagaImpuesto);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.btnVENCTE);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFactura_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnVENCTE;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblPagaImpuesto;
        private System.Windows.Forms.Label lblFechaFactura;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCONFACT;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblImpuestoLn;
        private System.Windows.Forms.Label lblTotalLn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnInsertarLn;
        private System.Windows.Forms.Button btnBorrarLn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblNombrePaga;
        private System.Windows.Forms.Button btnBorrar;
    }
}