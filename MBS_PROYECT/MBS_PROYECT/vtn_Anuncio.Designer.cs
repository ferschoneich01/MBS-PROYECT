﻿
namespace MBS_PROYECT
{
    partial class vtn_Anuncio
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAnuncio = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnuncio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "PUBLICAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECCIONAR:\r\n";
            // 
            // pbAnuncio
            // 
            this.pbAnuncio.Location = new System.Drawing.Point(271, 33);
            this.pbAnuncio.Name = "pbAnuncio";
            this.pbAnuncio.Size = new System.Drawing.Size(288, 219);
            this.pbAnuncio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnuncio.TabIndex = 2;
            this.pbAnuncio.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 246);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "ANUNCIO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(271, 259);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(205, 20);
            this.txtURL.TabIndex = 4;
            this.txtURL.Visible = false;
            // 
            // vtn_Anuncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 291);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbAnuncio);
            this.Name = "vtn_Anuncio";
            this.Text = "Coloca tu Anuncio";
            ((System.ComponentModel.ISupportInitialize)(this.pbAnuncio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAnuncio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtURL;
    }
}