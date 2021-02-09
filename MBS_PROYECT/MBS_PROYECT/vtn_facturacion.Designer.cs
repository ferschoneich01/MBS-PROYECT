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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbfecha = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlcambio = new System.Windows.Forms.Panel();
            this.cambio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlpago = new System.Windows.Forms.Panel();
            this.pago = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlmodo = new System.Windows.Forms.Panel();
            this.modopago = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.montototal = new System.Windows.Forms.Label();
            this.pnlmonto = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlcambio.SuspendLayout();
            this.pnlpago.SuspendLayout();
            this.pnlmodo.SuspendLayout();
            this.pnlmonto.SuspendLayout();
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de productos ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 365);
            this.dataGridView1.TabIndex = 20;
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.Location = new System.Drawing.Point(585, 55);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(25, 21);
            this.lbfecha.TabIndex = 22;
            this.lbfecha.Text = "...";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(510, 55);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(69, 21);
            this.Fecha.TabIndex = 21;
            this.Fecha.Text = "Fecha : ";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.lblhora.Location = new System.Drawing.Point(721, 55);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(21, 19);
            this.lblhora.TabIndex = 24;
            this.lblhora.Text = "...";
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Font = new System.Drawing.Font("Times New Roman", 12.25F);
            this.hora.Location = new System.Drawing.Point(663, 55);
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
            this.label3.Location = new System.Drawing.Point(488, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Monto total";
            // 
            // pnlcambio
            // 
            this.pnlcambio.Controls.Add(this.cambio);
            this.pnlcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlcambio.ForeColor = System.Drawing.Color.Red;
            this.pnlcambio.Location = new System.Drawing.Point(492, 360);
            this.pnlcambio.Name = "pnlcambio";
            this.pnlcambio.Size = new System.Drawing.Size(315, 48);
            this.pnlcambio.TabIndex = 32;
            this.pnlcambio.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnlcambio_Paint);
            // 
            // cambio
            // 
            this.cambio.AutoSize = true;
            this.cambio.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cambio.Location = new System.Drawing.Point(3, 0);
            this.cambio.Name = "cambio";
            this.cambio.Size = new System.Drawing.Size(55, 36);
            this.cambio.TabIndex = 7;
            this.cambio.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(488, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "Cambio ";
            // 
            // pnlpago
            // 
            this.pnlpago.Controls.Add(this.pago);
            this.pnlpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlpago.ForeColor = System.Drawing.Color.Lime;
            this.pnlpago.Location = new System.Drawing.Point(492, 281);
            this.pnlpago.Name = "pnlpago";
            this.pnlpago.Size = new System.Drawing.Size(315, 51);
            this.pnlpago.TabIndex = 30;
            this.pnlpago.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnlpago_Paint);
            // 
            // pago
            // 
            this.pago.AutoSize = true;
            this.pago.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pago.Location = new System.Drawing.Point(3, 0);
            this.pago.Name = "pago";
            this.pago.Size = new System.Drawing.Size(55, 36);
            this.pago.TabIndex = 7;
            this.pago.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(488, 256);
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
            this.pnlmodo.Location = new System.Drawing.Point(492, 202);
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
            this.label5.Location = new System.Drawing.Point(488, 177);
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
            // 
            // pnlmonto
            // 
            this.pnlmonto.Controls.Add(this.montototal);
            this.pnlmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlmonto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pnlmonto.Location = new System.Drawing.Point(492, 126);
            this.pnlmonto.Name = "pnlmonto";
            this.pnlmonto.Size = new System.Drawing.Size(315, 48);
            this.pnlmonto.TabIndex = 26;
            this.pnlmonto.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnlmonto_Paint);
            // 
            // vtn_facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 460);
            this.Controls.Add(this.pnlcambio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnlpago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlmodo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlmonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "vtn_facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlcambio.ResumeLayout(false);
            this.pnlcambio.PerformLayout();
            this.pnlpago.ResumeLayout(false);
            this.pnlpago.PerformLayout();
            this.pnlmodo.ResumeLayout(false);
            this.pnlmodo.PerformLayout();
            this.pnlmonto.ResumeLayout(false);
            this.pnlmonto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlcambio;
        private System.Windows.Forms.Label cambio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlpago;
        private System.Windows.Forms.Label pago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlmodo;
        private System.Windows.Forms.Label modopago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label montototal;
        private System.Windows.Forms.Panel pnlmonto;
    }
}

