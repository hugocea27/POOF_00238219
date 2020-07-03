namespace Parcial
{
    partial class Form1
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
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contra = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.btm_logear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_usuario.Location = new System.Drawing.Point(136, 121);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(111, 23);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "USUARIO:";
            this.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_contra
            // 
            this.lbl_contra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_contra.Location = new System.Drawing.Point(90, 165);
            this.lbl_contra.Name = "lbl_contra";
            this.lbl_contra.Size = new System.Drawing.Size(157, 23);
            this.lbl_contra.TabIndex = 1;
            this.lbl_contra.Text = "CONTRASEÑA:";
            this.lbl_contra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(253, 121);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(177, 23);
            this.txt_usuario.TabIndex = 2;
            // 
            // txt_contra
            // 
            this.txt_contra.Location = new System.Drawing.Point(253, 165);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(177, 23);
            this.txt_contra.TabIndex = 3;
            // 
            // btm_logear
            // 
            this.btm_logear.Location = new System.Drawing.Point(253, 209);
            this.btm_logear.Name = "btm_logear";
            this.btm_logear.Size = new System.Drawing.Size(94, 40);
            this.btm_logear.TabIndex = 4;
            this.btm_logear.Text = "INGRESAR";
            this.btm_logear.UseVisualStyleBackColor = true;
            this.btm_logear.Click += new System.EventHandler(this.btm_logear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btm_logear);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_contra);
            this.Controls.Add(this.lbl_usuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_contra;
        private System.Windows.Forms.Button btm_logear;
    }
}