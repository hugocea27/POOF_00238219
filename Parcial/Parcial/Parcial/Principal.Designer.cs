using System.ComponentModel;

namespace Parcial
{
    partial class Principal
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
            this.dgw_registro = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dgw_registro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_registro
            // 
            this.dgw_registro.AllowUserToAddRows = false;
            this.dgw_registro.AllowUserToDeleteRows = false;
            this.dgw_registro.AllowUserToResizeColumns = false;
            this.dgw_registro.AllowUserToResizeRows = false;
            this.dgw_registro.ColumnHeadersVisible = false;
            this.dgw_registro.Location = new System.Drawing.Point(164, 68);
            this.dgw_registro.Name = "dgw_registro";
            this.dgw_registro.ReadOnly = true;
            this.dgw_registro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgw_registro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgw_registro.Size = new System.Drawing.Size(275, 144);
            this.dgw_registro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(252, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entradas personales";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgw_registro);
            this.Name = "Principal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize) (this.dgw_registro)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_registro;
        private System.Windows.Forms.Label label1;
    }
}