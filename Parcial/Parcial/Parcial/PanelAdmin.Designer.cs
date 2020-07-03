using System.ComponentModel;

namespace Parcial
{
    partial class PanelAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btm_eliminar = new System.Windows.Forms.Button();
            this.txt_eliminarcarnet = new System.Windows.Forms.TextBox();
            this.lbl_carnet_2 = new System.Windows.Forms.Label();
            this.btm_agregar = new System.Windows.Forms.Button();
            this.lbl_dui = new System.Windows.Forms.Label();
            this.txt_dui = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.txt_iddepartamento = new System.Windows.Forms.TextBox();
            this.txt_carnet = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_contra = new System.Windows.Forms.Label();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.lbl_idUsuario = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgw_usuarios = new System.Windows.Forms.DataGridView();
            this.dgw_departamentos = new System.Windows.Forms.DataGridView();
            this.dgw_registro = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Usuarios = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgw_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgw_departamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgw_registro)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 323);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btm_eliminar);
            this.tabPage1.Controls.Add(this.txt_eliminarcarnet);
            this.tabPage1.Controls.Add(this.lbl_carnet_2);
            this.tabPage1.Controls.Add(this.btm_agregar);
            this.tabPage1.Controls.Add(this.lbl_dui);
            this.tabPage1.Controls.Add(this.txt_dui);
            this.tabPage1.Controls.Add(this.txt_apellido);
            this.tabPage1.Controls.Add(this.txt_nombre);
            this.tabPage1.Controls.Add(this.txt_contra);
            this.tabPage1.Controls.Add(this.txt_iddepartamento);
            this.tabPage1.Controls.Add(this.txt_carnet);
            this.tabPage1.Controls.Add(this.lbl_apellido);
            this.tabPage1.Controls.Add(this.lbl_nombre);
            this.tabPage1.Controls.Add(this.lbl_contra);
            this.tabPage1.Controls.Add(this.lbl_departamento);
            this.tabPage1.Controls.Add(this.lbl_idUsuario);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btm_eliminar
            // 
            this.btm_eliminar.Location = new System.Drawing.Point(388, 82);
            this.btm_eliminar.Name = "btm_eliminar";
            this.btm_eliminar.Size = new System.Drawing.Size(100, 23);
            this.btm_eliminar.TabIndex = 15;
            this.btm_eliminar.Text = "Eliminar";
            this.btm_eliminar.UseVisualStyleBackColor = true;
            this.btm_eliminar.Click += new System.EventHandler(this.btm_eliminar_Click);
            // 
            // txt_eliminarcarnet
            // 
            this.txt_eliminarcarnet.Location = new System.Drawing.Point(388, 57);
            this.txt_eliminarcarnet.Name = "txt_eliminarcarnet";
            this.txt_eliminarcarnet.Size = new System.Drawing.Size(100, 23);
            this.txt_eliminarcarnet.TabIndex = 14;
            // 
            // lbl_carnet_2
            // 
            this.lbl_carnet_2.Location = new System.Drawing.Point(388, 30);
            this.lbl_carnet_2.Name = "lbl_carnet_2";
            this.lbl_carnet_2.Size = new System.Drawing.Size(100, 23);
            this.lbl_carnet_2.TabIndex = 13;
            this.lbl_carnet_2.Text = "Carnet:";
            this.lbl_carnet_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btm_agregar
            // 
            this.btm_agregar.Location = new System.Drawing.Point(90, 205);
            this.btm_agregar.Name = "btm_agregar";
            this.btm_agregar.Size = new System.Drawing.Size(100, 23);
            this.btm_agregar.TabIndex = 12;
            this.btm_agregar.Text = "Agregar";
            this.btm_agregar.UseVisualStyleBackColor = true;
            this.btm_agregar.Click += new System.EventHandler(this.btm_agregar_Click);
            // 
            // lbl_dui
            // 
            this.lbl_dui.Location = new System.Drawing.Point(157, 30);
            this.lbl_dui.Name = "lbl_dui";
            this.lbl_dui.Size = new System.Drawing.Size(100, 23);
            this.lbl_dui.TabIndex = 11;
            this.lbl_dui.Text = "DUI:";
            this.lbl_dui.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_dui
            // 
            this.txt_dui.Location = new System.Drawing.Point(157, 57);
            this.txt_dui.Name = "txt_dui";
            this.txt_dui.Size = new System.Drawing.Size(100, 23);
            this.txt_dui.TabIndex = 10;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(157, 160);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 23);
            this.txt_apellido.TabIndex = 9;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(157, 108);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_nombre.TabIndex = 8;
            // 
            // txt_contra
            // 
            this.txt_contra.Location = new System.Drawing.Point(31, 160);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(100, 23);
            this.txt_contra.TabIndex = 7;
            // 
            // txt_iddepartamento
            // 
            this.txt_iddepartamento.Location = new System.Drawing.Point(31, 108);
            this.txt_iddepartamento.Name = "txt_iddepartamento";
            this.txt_iddepartamento.Size = new System.Drawing.Size(100, 23);
            this.txt_iddepartamento.TabIndex = 6;
            // 
            // txt_carnet
            // 
            this.txt_carnet.Location = new System.Drawing.Point(31, 57);
            this.txt_carnet.Name = "txt_carnet";
            this.txt_carnet.Size = new System.Drawing.Size(100, 23);
            this.txt_carnet.TabIndex = 5;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.Location = new System.Drawing.Point(157, 134);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(100, 23);
            this.lbl_apellido.TabIndex = 4;
            this.lbl_apellido.Text = "Apellido:";
            this.lbl_apellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Location = new System.Drawing.Point(157, 82);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(100, 23);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre:";
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_contra
            // 
            this.lbl_contra.Location = new System.Drawing.Point(31, 134);
            this.lbl_contra.Name = "lbl_contra";
            this.lbl_contra.Size = new System.Drawing.Size(100, 23);
            this.lbl_contra.TabIndex = 2;
            this.lbl_contra.Text = "Contraseña:";
            this.lbl_contra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.Location = new System.Drawing.Point(31, 82);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(100, 23);
            this.lbl_departamento.TabIndex = 1;
            this.lbl_departamento.Text = "ID Departamento:";
            this.lbl_departamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_idUsuario
            // 
            this.lbl_idUsuario.Location = new System.Drawing.Point(31, 30);
            this.lbl_idUsuario.Name = "lbl_idUsuario";
            this.lbl_idUsuario.Size = new System.Drawing.Size(100, 23);
            this.lbl_idUsuario.TabIndex = 0;
            this.lbl_idUsuario.Text = "Carnet:";
            this.lbl_idUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Usuarios);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgw_usuarios);
            this.tabPage2.Controls.Add(this.dgw_departamentos);
            this.tabPage2.Controls.Add(this.dgw_registro);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgw_usuarios
            // 
            this.dgw_usuarios.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_usuarios.Location = new System.Drawing.Point(17, 197);
            this.dgw_usuarios.Name = "dgw_usuarios";
            this.dgw_usuarios.RowHeadersVisible = false;
            this.dgw_usuarios.Size = new System.Drawing.Size(213, 95);
            this.dgw_usuarios.TabIndex = 2;
            // 
            // dgw_departamentos
            // 
            this.dgw_departamentos.AllowUserToAddRows = false;
            this.dgw_departamentos.AllowUserToDeleteRows = false;
            this.dgw_departamentos.AllowUserToOrderColumns = true;
            this.dgw_departamentos.AllowUserToResizeColumns = false;
            this.dgw_departamentos.AllowUserToResizeRows = false;
            this.dgw_departamentos.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_departamentos.Location = new System.Drawing.Point(316, 46);
            this.dgw_departamentos.Name = "dgw_departamentos";
            this.dgw_departamentos.RowHeadersVisible = false;
            this.dgw_departamentos.Size = new System.Drawing.Size(213, 105);
            this.dgw_departamentos.TabIndex = 1;
            // 
            // dgw_registro
            // 
            this.dgw_registro.AllowUserToAddRows = false;
            this.dgw_registro.AllowUserToDeleteRows = false;
            this.dgw_registro.AllowUserToOrderColumns = true;
            this.dgw_registro.AllowUserToResizeColumns = false;
            this.dgw_registro.AllowUserToResizeRows = false;
            this.dgw_registro.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_registro.Location = new System.Drawing.Point(17, 46);
            this.dgw_registro.Name = "dgw_registro";
            this.dgw_registro.RowHeadersVisible = false;
            this.dgw_registro.Size = new System.Drawing.Size(213, 105);
            this.dgw_registro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(78, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registros";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(340, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Departamento concurrido";
            // 
            // Usuarios
            // 
            this.Usuarios.Location = new System.Drawing.Point(87, 171);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(100, 23);
            this.Usuarios.TabIndex = 5;
            this.Usuarios.Text = "Usuarios";
            // 
            // PanelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "PanelAdmin";
            this.Text = "PanelAdmin";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgw_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgw_departamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgw_registro)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lbl_idUsuario;
        private System.Windows.Forms.Button btm_agregar;
        private System.Windows.Forms.TextBox txt_dui;
        private System.Windows.Forms.Label lbl_dui;
        private System.Windows.Forms.TextBox txt_carnet;
        private System.Windows.Forms.TextBox txt_iddepartamento;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_contra;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.Label lbl_carnet_2;
        private System.Windows.Forms.TextBox txt_eliminarcarnet;
        private System.Windows.Forms.Button btm_eliminar;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.DataGridView dgw_departamentos;
        private System.Windows.Forms.DataGridView dgw_registro;
        private System.Windows.Forms.DataGridView dgw_usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Usuarios;
    }
}