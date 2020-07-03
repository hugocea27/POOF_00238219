using System.ComponentModel;

namespace Parcial
{
    partial class PanelVigilante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_idempleado = new System.Windows.Forms.Label();
            this.lbl_temperatura = new System.Windows.Forms.Label();
            this.lbl_fechayhora = new System.Windows.Forms.Label();
            this.txt_idempleado = new System.Windows.Forms.TextBox();
            this.txt_temperatura = new System.Windows.Forms.TextBox();
            this.txt_fechayhora = new System.Windows.Forms.TextBox();
            this.btm_entrada = new System.Windows.Forms.Button();
            this.btm_salida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_titulo.Location = new System.Drawing.Point(106, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(359, 42);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Gestión de entradas y salidas";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_idempleado
            // 
            this.lbl_idempleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_idempleado.Location = new System.Drawing.Point(64, 68);
            this.lbl_idempleado.Name = "lbl_idempleado";
            this.lbl_idempleado.Size = new System.Drawing.Size(152, 23);
            this.lbl_idempleado.TabIndex = 1;
            this.lbl_idempleado.Text = "ID del empleado:";
            this.lbl_idempleado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_temperatura
            // 
            this.lbl_temperatura.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_temperatura.Location = new System.Drawing.Point(64, 117);
            this.lbl_temperatura.Name = "lbl_temperatura";
            this.lbl_temperatura.Size = new System.Drawing.Size(152, 23);
            this.lbl_temperatura.TabIndex = 2;
            this.lbl_temperatura.Text = "Temperatura";
            this.lbl_temperatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fechayhora
            // 
            this.lbl_fechayhora.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_fechayhora.Location = new System.Drawing.Point(64, 166);
            this.lbl_fechayhora.Name = "lbl_fechayhora";
            this.lbl_fechayhora.Size = new System.Drawing.Size(152, 23);
            this.lbl_fechayhora.TabIndex = 3;
            this.lbl_fechayhora.Text = "Fecha y hora";
            this.lbl_fechayhora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_idempleado
            // 
            this.txt_idempleado.Location = new System.Drawing.Point(222, 70);
            this.txt_idempleado.Name = "txt_idempleado";
            this.txt_idempleado.Size = new System.Drawing.Size(206, 23);
            this.txt_idempleado.TabIndex = 4;
            // 
            // txt_temperatura
            // 
            this.txt_temperatura.Location = new System.Drawing.Point(222, 117);
            this.txt_temperatura.Name = "txt_temperatura";
            this.txt_temperatura.Size = new System.Drawing.Size(206, 23);
            this.txt_temperatura.TabIndex = 5;
            // 
            // txt_fechayhora
            // 
            this.txt_fechayhora.Location = new System.Drawing.Point(222, 166);
            this.txt_fechayhora.Name = "txt_fechayhora";
            this.txt_fechayhora.Size = new System.Drawing.Size(206, 23);
            this.txt_fechayhora.TabIndex = 6;
            // 
            // btm_entrada
            // 
            this.btm_entrada.Location = new System.Drawing.Point(118, 263);
            this.btm_entrada.Name = "btm_entrada";
            this.btm_entrada.Size = new System.Drawing.Size(134, 23);
            this.btm_entrada.TabIndex = 7;
            this.btm_entrada.Text = "Agregar entrada";
            this.btm_entrada.UseVisualStyleBackColor = true;
            this.btm_entrada.Click += new System.EventHandler(this.btm_entrada_Click_1);
            // 
            // btm_salida
            // 
            this.btm_salida.Location = new System.Drawing.Point(294, 263);
            this.btm_salida.Name = "btm_salida";
            this.btm_salida.Size = new System.Drawing.Size(134, 23);
            this.btm_salida.TabIndex = 8;
            this.btm_salida.Text = "Agregar salida";
            this.btm_salida.UseVisualStyleBackColor = true;
            this.btm_salida.Click += new System.EventHandler(this.btm_salida_Click);
            // 
            // PanelVigilante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btm_salida);
            this.Controls.Add(this.btm_entrada);
            this.Controls.Add(this.txt_fechayhora);
            this.Controls.Add(this.txt_temperatura);
            this.Controls.Add(this.txt_idempleado);
            this.Controls.Add(this.lbl_fechayhora);
            this.Controls.Add(this.lbl_temperatura);
            this.Controls.Add(this.lbl_idempleado);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "PanelVigilante";
            this.Text = "PanelVigilante";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_idempleado;
        private System.Windows.Forms.TextBox txt_fechayhora;
        private System.Windows.Forms.TextBox txt_temperatura;
        private System.Windows.Forms.TextBox txt_idempleado;
        private System.Windows.Forms.Label lbl_fechayhora;
        private System.Windows.Forms.Label lbl_temperatura;
        private System.Windows.Forms.Button btm_salida;
        private System.Windows.Forms.Button btm_entrada;
    }
}