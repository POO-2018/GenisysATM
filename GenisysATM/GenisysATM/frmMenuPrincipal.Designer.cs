namespace GenisysATM
{
    partial class frmMenuPrincipal
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
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnCambioPin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btntarjetaCredito = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRetiroDolares = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRetiroLempiras = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnServiciosPublicos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCliente = new System.Windows.Forms.Label();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpciones
            // 
            this.gbOpciones.BackColor = System.Drawing.Color.Transparent;
            this.gbOpciones.Controls.Add(this.btnCambioPin);
            this.gbOpciones.Controls.Add(this.btntarjetaCredito);
            this.gbOpciones.Controls.Add(this.btnRetiroDolares);
            this.gbOpciones.Controls.Add(this.btnRetiroLempiras);
            this.gbOpciones.Controls.Add(this.btnServiciosPublicos);
            this.gbOpciones.Controls.Add(this.btnSalir);
            this.gbOpciones.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.Location = new System.Drawing.Point(12, 228);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(1416, 660);
            this.gbOpciones.TabIndex = 0;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "SELECCIONE LA OPCIÓN A REALIZAR";
            // 
            // btnCambioPin
            // 
            this.btnCambioPin.Depth = 0;
            this.btnCambioPin.Location = new System.Drawing.Point(963, 280);
            this.btnCambioPin.Margin = new System.Windows.Forms.Padding(6);
            this.btnCambioPin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCambioPin.Name = "btnCambioPin";
            this.btnCambioPin.Primary = true;
            this.btnCambioPin.Size = new System.Drawing.Size(418, 137);
            this.btnCambioPin.TabIndex = 15;
            this.btnCambioPin.Text = "Cambio de PIN";
            this.btnCambioPin.UseVisualStyleBackColor = true;
            // 
            // btntarjetaCredito
            // 
            this.btntarjetaCredito.Depth = 0;
            this.btntarjetaCredito.Location = new System.Drawing.Point(963, 86);
            this.btntarjetaCredito.Margin = new System.Windows.Forms.Padding(6);
            this.btntarjetaCredito.MouseState = MaterialSkin.MouseState.HOVER;
            this.btntarjetaCredito.Name = "btntarjetaCredito";
            this.btntarjetaCredito.Primary = true;
            this.btntarjetaCredito.Size = new System.Drawing.Size(418, 137);
            this.btntarjetaCredito.TabIndex = 12;
            this.btntarjetaCredito.Text = "Pago tarjeta de Crédito";
            this.btntarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // btnRetiroDolares
            // 
            this.btnRetiroDolares.Depth = 0;
            this.btnRetiroDolares.Location = new System.Drawing.Point(33, 280);
            this.btnRetiroDolares.Margin = new System.Windows.Forms.Padding(6);
            this.btnRetiroDolares.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRetiroDolares.Name = "btnRetiroDolares";
            this.btnRetiroDolares.Primary = true;
            this.btnRetiroDolares.Size = new System.Drawing.Size(418, 137);
            this.btnRetiroDolares.TabIndex = 13;
            this.btnRetiroDolares.Text = "Retiro en Dolares";
            this.btnRetiroDolares.UseVisualStyleBackColor = true;
            // 
            // btnRetiroLempiras
            // 
            this.btnRetiroLempiras.Depth = 0;
            this.btnRetiroLempiras.Location = new System.Drawing.Point(33, 86);
            this.btnRetiroLempiras.Margin = new System.Windows.Forms.Padding(6);
            this.btnRetiroLempiras.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRetiroLempiras.Name = "btnRetiroLempiras";
            this.btnRetiroLempiras.Primary = true;
            this.btnRetiroLempiras.Size = new System.Drawing.Size(418, 137);
            this.btnRetiroLempiras.TabIndex = 10;
            this.btnRetiroLempiras.Text = "Retiro en lempiras";
            this.btnRetiroLempiras.UseVisualStyleBackColor = true;
            this.btnRetiroLempiras.Click += new System.EventHandler(this.btnRetiroLempiras_Click);
            // 
            // btnServiciosPublicos
            // 
            this.btnServiciosPublicos.Depth = 0;
            this.btnServiciosPublicos.Location = new System.Drawing.Point(33, 465);
            this.btnServiciosPublicos.Margin = new System.Windows.Forms.Padding(6);
            this.btnServiciosPublicos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnServiciosPublicos.Name = "btnServiciosPublicos";
            this.btnServiciosPublicos.Primary = true;
            this.btnServiciosPublicos.Size = new System.Drawing.Size(418, 137);
            this.btnServiciosPublicos.TabIndex = 14;
            this.btnServiciosPublicos.Text = "Pago servicios públicos";
            this.btnServiciosPublicos.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(963, 465);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(418, 137);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Roboto", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(569, 110);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(859, 73);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.gbOpciones);
            this.Name = "frmMenuPrincipal";
            this.Text = "Menú Principal Genisys ATM";
            this.gbOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpciones;
        private MaterialSkin.Controls.MaterialRaisedButton btnCambioPin;
        private MaterialSkin.Controls.MaterialRaisedButton btntarjetaCredito;
        private MaterialSkin.Controls.MaterialRaisedButton btnRetiroDolares;
        private MaterialSkin.Controls.MaterialRaisedButton btnRetiroLempiras;
        private MaterialSkin.Controls.MaterialRaisedButton btnServiciosPublicos;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.Label lblCliente;
    }
}