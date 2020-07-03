using System.ComponentModel;

namespace Parcial
{
    partial class Bienvenida
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
            this.lbl_bienvenido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.btm_verEntradas = new System.Windows.Forms.Button();
            this.btm_panelVigilante = new System.Windows.Forms.Button();
            this.btm_panelAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_bienvenido
            // 
            this.lbl_bienvenido.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_bienvenido.Location = new System.Drawing.Point(84, 38);
            this.lbl_bienvenido.Name = "lbl_bienvenido";
            this.lbl_bienvenido.Size = new System.Drawing.Size(429, 42);
            this.lbl_bienvenido.TabIndex = 0;
            this.lbl_bienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_nombre.Location = new System.Drawing.Point(194, 92);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(202, 42);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_apellido.Location = new System.Drawing.Point(194, 134);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(202, 42);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btm_verEntradas
            // 
            this.btm_verEntradas.Location = new System.Drawing.Point(239, 227);
            this.btm_verEntradas.Name = "btm_verEntradas";
            this.btm_verEntradas.Size = new System.Drawing.Size(115, 33);
            this.btm_verEntradas.TabIndex = 3;
            this.btm_verEntradas.Text = "Entradas";
            this.btm_verEntradas.UseVisualStyleBackColor = true;
            this.btm_verEntradas.Click += new System.EventHandler(this.btm_verEntradas_Click);
            // 
            // btm_panelVigilante
            // 
            this.btm_panelVigilante.Location = new System.Drawing.Point(239, 267);
            this.btm_panelVigilante.Name = "btm_panelVigilante";
            this.btm_panelVigilante.Size = new System.Drawing.Size(115, 33);
            this.btm_panelVigilante.TabIndex = 4;
            this.btm_panelVigilante.Text = "Panel Vigilante";
            this.btm_panelVigilante.UseVisualStyleBackColor = true;
            this.btm_panelVigilante.Click += new System.EventHandler(this.btm_panelVigilante_Click);
            // 
            // btm_panelAdmin
            // 
            this.btm_panelAdmin.Location = new System.Drawing.Point(239, 307);
            this.btm_panelAdmin.Name = "btm_panelAdmin";
            this.btm_panelAdmin.Size = new System.Drawing.Size(115, 33);
            this.btm_panelAdmin.TabIndex = 5;
            this.btm_panelAdmin.Text = "Panel Admin";
            this.btm_panelAdmin.UseVisualStyleBackColor = true;
            this.btm_panelAdmin.Click += new System.EventHandler(this.btm_panelAdmin_Click);
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btm_panelAdmin);
            this.Controls.Add(this.btm_panelVigilante);
            this.Controls.Add(this.btm_verEntradas);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_bienvenido);
            this.Name = "Bienvenida";
            this.Text = "Bienvenida";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_bienvenido;
        private System.Windows.Forms.Button btm_verEntradas;
        private System.Windows.Forms.Button btm_panelVigilante;
        private System.Windows.Forms.Button btm_panelAdmin;
    }
}