namespace MBS_PROYECT
{
    partial class vtn_facturacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vtn_facturacion));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlcambio = new System.Windows.Forms.Panel();
            this.lblCambio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlpago = new System.Windows.Forms.Panel();
            this.lblPago = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlmodo = new System.Windows.Forms.Panel();
            this.modopago = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.montototal = new System.Windows.Forms.Label();
            this.pnlmonto = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.pnlcambio.SuspendLayout();
            this.pnlpago.SuspendLayout();
            this.pnlmodo.SuspendLayout();
            this.pnlmonto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(878, 40);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "FACTURA";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.Location = new System.Drawing.Point(130, 13);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(25, 21);
            this.lbfecha.TabIndex = 22;
            this.lbfecha.Text = "...";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(49, 13);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(69, 21);
            this.Fecha.TabIndex = 21;
            this.Fecha.Text = "Fecha : ";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.lblhora.Location = new System.Drawing.Point(270, 13);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(21, 19);
            this.lblhora.TabIndex = 24;
            this.lblhora.Text = "...";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.hora.Location = new System.Drawing.Point(212, 13);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(52, 19);
            this.hora.TabIndex = 23;
            this.hora.Text = "Hora :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(39, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Monto total";
            // 
            // pnlcambio
            // 
            this.pnlcambio.Controls.Add(this.lblCambio);
            this.pnlcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlcambio.ForeColor = System.Drawing.Color.Red;
            this.pnlcambio.Location = new System.Drawing.Point(43, 319);
            this.pnlcambio.Name = "pnlcambio";
            this.pnlcambio.Size = new System.Drawing.Size(315, 48);
            this.pnlcambio.TabIndex = 32;
            this.pnlcambio.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnlcambio_Paint);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(3, 0);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(55, 36);
            this.lblCambio.TabIndex = 7;
            this.lblCambio.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(39, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "Cambio ";
            // 
            // pnlpago
            // 
            this.pnlpago.Controls.Add(this.lblPago);
            this.pnlpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlpago.ForeColor = System.Drawing.Color.Lime;
            this.pnlpago.Location = new System.Drawing.Point(43, 240);
            this.pnlpago.Name = "pnlpago";
            this.pnlpago.Size = new System.Drawing.Size(315, 51);
            this.pnlpago.TabIndex = 30;
            this.pnlpago.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnlpago_Paint);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPago.Location = new System.Drawing.Point(3, 0);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(55, 36);
            this.lblPago.TabIndex = 7;
            this.lblPago.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(39, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Pago";
            // 
            // pnlmodo
            // 
            this.pnlmodo.Controls.Add(this.modopago);
            this.pnlmodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlmodo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pnlmodo.Location = new System.Drawing.Point(43, 161);
            this.pnlmodo.Name = "pnlmodo";
            this.pnlmodo.Size = new System.Drawing.Size(315, 51);
            this.pnlmodo.TabIndex = 28;
            this.pnlmodo.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnlmodo_Paint);
            // 
            // modopago
            // 
            this.modopago.AutoSize = true;
            this.modopago.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modopago.Location = new System.Drawing.Point(3, 0);
            this.modopago.Name = "modopago";
            this.modopago.Size = new System.Drawing.Size(39, 36);
            this.modopago.TabIndex = 7;
            this.modopago.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(39, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Modo de pago";
            // 
            // montototal
            // 
            this.montototal.AutoSize = true;
            this.montototal.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montototal.Location = new System.Drawing.Point(3, 0);
            this.montototal.Name = "montototal";
            this.montototal.Size = new System.Drawing.Size(55, 36);
            this.montototal.TabIndex = 7;
            this.montototal.Text = "0.0";
            this.montototal.Click += new System.EventHandler(this.montototal_Click);
            // 
            // pnlmonto
            // 
            this.pnlmonto.Controls.Add(this.montototal);
            this.pnlmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlmonto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pnlmonto.Location = new System.Drawing.Point(43, 85);
            this.pnlmonto.Name = "pnlmonto";
            this.pnlmonto.Size = new System.Drawing.Size(315, 48);
            this.pnlmonto.TabIndex = 26;
            this.pnlmonto.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnlmonto_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.Fecha);
            this.panel1.Controls.Add(this.pnlcambio);
            this.panel1.Controls.Add(this.lbfecha);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.hora);
            this.panel1.Controls.Add(this.pnlpago);
            this.panel1.Controls.Add(this.lblhora);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pnlmodo);
            this.panel1.Controls.Add(this.pnlmonto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 380);
            this.panel1.TabIndex = 33;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(394, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(45, 42);
            this.btnImprimir.TabIndex = 33;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(187, 433);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 27);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // vtn_facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAceptar;
            this.ClientSize = new System.Drawing.Size(466, 472);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vtn_facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.pnlcambio.ResumeLayout(false);
            this.pnlcambio.PerformLayout();
            this.pnlpago.ResumeLayout(false);
            this.pnlpago.PerformLayout();
            this.pnlmodo.ResumeLayout(false);
            this.pnlmodo.PerformLayout();
            this.pnlmonto.ResumeLayout(false);
            this.pnlmonto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlcambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlpago;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlmodo;
        private System.Windows.Forms.Label modopago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label montototal;
        private System.Windows.Forms.Panel pnlmonto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAceptar;
    }
}

