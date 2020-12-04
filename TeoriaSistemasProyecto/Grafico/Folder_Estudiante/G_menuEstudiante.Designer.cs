namespace Grafico.Folder_Estudiante
{
    partial class G_menuEstudiante
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_materiaM = new System.Windows.Forms.Button();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_perfilEst = new System.Windows.Forms.Button();
            this.p_perfilEst = new System.Windows.Forms.Panel();
            this.btn_guardarEst = new System.Windows.Forms.Button();
            this.msk_fechaNacEst = new System.Windows.Forms.MaskedTextBox();
            this.msk_telefonoEst = new System.Windows.Forms.MaskedTextBox();
            this.msk_ideEst = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_actEst = new System.Windows.Forms.Button();
            this.txt_nombreEst = new System.Windows.Forms.TextBox();
            this.txt_apellidoUnoEst = new System.Windows.Forms.TextBox();
            this.txt_apellidoDosEst = new System.Windows.Forms.TextBox();
            this.txt_direccionEst = new System.Windows.Forms.TextBox();
            this.txt_emailEst = new System.Windows.Forms.TextBox();
            this.txt_usuEst = new System.Windows.Forms.TextBox();
            this.txt_contraEst = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.p_materiaM = new System.Windows.Forms.Panel();
            this.dgv_materiasM = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.p_perfilEst.SuspendLayout();
            this.p_materiaM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiasM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.btn_materiaM);
            this.panel1.Controls.Add(this.lbl_rol);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Controls.Add(this.btn_perfilEst);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 390);
            this.panel1.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.White;
            this.btn_cerrar.ForeColor = System.Drawing.Color.Black;
            this.btn_cerrar.Location = new System.Drawing.Point(4, 364);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "Cerrar.";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_materiaM
            // 
            this.btn_materiaM.BackColor = System.Drawing.Color.White;
            this.btn_materiaM.ForeColor = System.Drawing.Color.Black;
            this.btn_materiaM.Location = new System.Drawing.Point(17, 130);
            this.btn_materiaM.Name = "btn_materiaM";
            this.btn_materiaM.Size = new System.Drawing.Size(122, 23);
            this.btn_materiaM.TabIndex = 3;
            this.btn_materiaM.Text = "Materias matriculadas.";
            this.btn_materiaM.UseVisualStyleBackColor = false;
            this.btn_materiaM.Click += new System.EventHandler(this.btn_materiaM_Click);
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rol.Location = new System.Drawing.Point(21, 46);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(38, 14);
            this.lbl_rol.TabIndex = 2;
            this.lbl_rol.Text = "label2";
            this.lbl_rol.Visible = false;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(21, 21);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(38, 14);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "label1";
            this.lbl_nombre.Visible = false;
            // 
            // btn_perfilEst
            // 
            this.btn_perfilEst.BackColor = System.Drawing.Color.White;
            this.btn_perfilEst.ForeColor = System.Drawing.Color.Black;
            this.btn_perfilEst.Location = new System.Drawing.Point(17, 93);
            this.btn_perfilEst.Name = "btn_perfilEst";
            this.btn_perfilEst.Size = new System.Drawing.Size(122, 23);
            this.btn_perfilEst.TabIndex = 0;
            this.btn_perfilEst.Text = "Perfil.";
            this.btn_perfilEst.UseVisualStyleBackColor = false;
            this.btn_perfilEst.Click += new System.EventHandler(this.btn_perfilEst_Click);
            // 
            // p_perfilEst
            // 
            this.p_perfilEst.Controls.Add(this.btn_guardarEst);
            this.p_perfilEst.Controls.Add(this.msk_fechaNacEst);
            this.p_perfilEst.Controls.Add(this.msk_telefonoEst);
            this.p_perfilEst.Controls.Add(this.msk_ideEst);
            this.p_perfilEst.Controls.Add(this.label15);
            this.p_perfilEst.Controls.Add(this.btn_actEst);
            this.p_perfilEst.Controls.Add(this.txt_nombreEst);
            this.p_perfilEst.Controls.Add(this.txt_apellidoUnoEst);
            this.p_perfilEst.Controls.Add(this.txt_apellidoDosEst);
            this.p_perfilEst.Controls.Add(this.txt_direccionEst);
            this.p_perfilEst.Controls.Add(this.txt_emailEst);
            this.p_perfilEst.Controls.Add(this.txt_usuEst);
            this.p_perfilEst.Controls.Add(this.txt_contraEst);
            this.p_perfilEst.Controls.Add(this.label14);
            this.p_perfilEst.Controls.Add(this.label13);
            this.p_perfilEst.Controls.Add(this.label12);
            this.p_perfilEst.Controls.Add(this.label10);
            this.p_perfilEst.Controls.Add(this.label9);
            this.p_perfilEst.Controls.Add(this.label8);
            this.p_perfilEst.Controls.Add(this.label7);
            this.p_perfilEst.Controls.Add(this.label6);
            this.p_perfilEst.Controls.Add(this.label5);
            this.p_perfilEst.ForeColor = System.Drawing.Color.White;
            this.p_perfilEst.Location = new System.Drawing.Point(176, 28);
            this.p_perfilEst.Name = "p_perfilEst";
            this.p_perfilEst.Size = new System.Drawing.Size(600, 390);
            this.p_perfilEst.TabIndex = 1;
            this.p_perfilEst.Visible = false;
            // 
            // btn_guardarEst
            // 
            this.btn_guardarEst.ForeColor = System.Drawing.Color.Black;
            this.btn_guardarEst.Location = new System.Drawing.Point(248, 310);
            this.btn_guardarEst.Name = "btn_guardarEst";
            this.btn_guardarEst.Size = new System.Drawing.Size(75, 23);
            this.btn_guardarEst.TabIndex = 53;
            this.btn_guardarEst.Text = "Guardar.";
            this.btn_guardarEst.UseVisualStyleBackColor = true;
            this.btn_guardarEst.Visible = false;
            this.btn_guardarEst.Click += new System.EventHandler(this.btn_guardarEst_Click);
            // 
            // msk_fechaNacEst
            // 
            this.msk_fechaNacEst.Enabled = false;
            this.msk_fechaNacEst.Location = new System.Drawing.Point(182, 244);
            this.msk_fechaNacEst.Name = "msk_fechaNacEst";
            this.msk_fechaNacEst.Size = new System.Drawing.Size(65, 20);
            this.msk_fechaNacEst.TabIndex = 52;
            // 
            // msk_telefonoEst
            // 
            this.msk_telefonoEst.Enabled = false;
            this.msk_telefonoEst.Location = new System.Drawing.Point(58, 244);
            this.msk_telefonoEst.Mask = "00-00-00-00";
            this.msk_telefonoEst.Name = "msk_telefonoEst";
            this.msk_telefonoEst.Size = new System.Drawing.Size(100, 20);
            this.msk_telefonoEst.TabIndex = 51;
            // 
            // msk_ideEst
            // 
            this.msk_ideEst.Enabled = false;
            this.msk_ideEst.Location = new System.Drawing.Point(418, 73);
            this.msk_ideEst.Mask = "0-000-000";
            this.msk_ideEst.Name = "msk_ideEst";
            this.msk_ideEst.Size = new System.Drawing.Size(100, 20);
            this.msk_ideEst.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Telefono.";
            // 
            // btn_actEst
            // 
            this.btn_actEst.Location = new System.Drawing.Point(248, 310);
            this.btn_actEst.Name = "btn_actEst";
            this.btn_actEst.Size = new System.Drawing.Size(75, 23);
            this.btn_actEst.TabIndex = 48;
            this.btn_actEst.Text = "Editar.";
            this.btn_actEst.UseVisualStyleBackColor = true;
            this.btn_actEst.Click += new System.EventHandler(this.btn_actEst_Click);
            // 
            // txt_nombreEst
            // 
            this.txt_nombreEst.Enabled = false;
            this.txt_nombreEst.Location = new System.Drawing.Point(39, 73);
            this.txt_nombreEst.Name = "txt_nombreEst";
            this.txt_nombreEst.Size = new System.Drawing.Size(100, 20);
            this.txt_nombreEst.TabIndex = 46;
            // 
            // txt_apellidoUnoEst
            // 
            this.txt_apellidoUnoEst.Enabled = false;
            this.txt_apellidoUnoEst.Location = new System.Drawing.Point(161, 73);
            this.txt_apellidoUnoEst.Name = "txt_apellidoUnoEst";
            this.txt_apellidoUnoEst.Size = new System.Drawing.Size(100, 20);
            this.txt_apellidoUnoEst.TabIndex = 45;
            // 
            // txt_apellidoDosEst
            // 
            this.txt_apellidoDosEst.Enabled = false;
            this.txt_apellidoDosEst.Location = new System.Drawing.Point(298, 73);
            this.txt_apellidoDosEst.Name = "txt_apellidoDosEst";
            this.txt_apellidoDosEst.Size = new System.Drawing.Size(100, 20);
            this.txt_apellidoDosEst.TabIndex = 44;
            // 
            // txt_direccionEst
            // 
            this.txt_direccionEst.Enabled = false;
            this.txt_direccionEst.Location = new System.Drawing.Point(36, 130);
            this.txt_direccionEst.Multiline = true;
            this.txt_direccionEst.Name = "txt_direccionEst";
            this.txt_direccionEst.Size = new System.Drawing.Size(262, 47);
            this.txt_direccionEst.TabIndex = 43;
            // 
            // txt_emailEst
            // 
            this.txt_emailEst.Enabled = false;
            this.txt_emailEst.Location = new System.Drawing.Point(328, 130);
            this.txt_emailEst.Multiline = true;
            this.txt_emailEst.Name = "txt_emailEst";
            this.txt_emailEst.Size = new System.Drawing.Size(237, 21);
            this.txt_emailEst.TabIndex = 42;
            // 
            // txt_usuEst
            // 
            this.txt_usuEst.Enabled = false;
            this.txt_usuEst.Location = new System.Drawing.Point(317, 245);
            this.txt_usuEst.Name = "txt_usuEst";
            this.txt_usuEst.Size = new System.Drawing.Size(100, 20);
            this.txt_usuEst.TabIndex = 40;
            // 
            // txt_contraEst
            // 
            this.txt_contraEst.Enabled = false;
            this.txt_contraEst.Location = new System.Drawing.Point(441, 245);
            this.txt_contraEst.Name = "txt_contraEst";
            this.txt_contraEst.Size = new System.Drawing.Size(100, 20);
            this.txt_contraEst.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(179, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Fecha Nacimiento.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Dirección.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(325, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Email.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Usuario.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Contraseña.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Identificación.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Apellido Materno.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Apellido paterno.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nombre.";
            // 
            // p_materiaM
            // 
            this.p_materiaM.BackColor = System.Drawing.Color.CadetBlue;
            this.p_materiaM.Controls.Add(this.dgv_materiasM);
            this.p_materiaM.Controls.Add(this.label1);
            this.p_materiaM.ForeColor = System.Drawing.Color.White;
            this.p_materiaM.Location = new System.Drawing.Point(176, 28);
            this.p_materiaM.Name = "p_materiaM";
            this.p_materiaM.Size = new System.Drawing.Size(600, 390);
            this.p_materiaM.TabIndex = 54;
            this.p_materiaM.Visible = false;
            // 
            // dgv_materiasM
            // 
            this.dgv_materiasM.AllowUserToAddRows = false;
            this.dgv_materiasM.AllowUserToDeleteRows = false;
            this.dgv_materiasM.BackgroundColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_materiasM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_materiasM.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_materiasM.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_materiasM.Location = new System.Drawing.Point(21, 114);
            this.dgv_materiasM.Name = "dgv_materiasM";
            this.dgv_materiasM.ReadOnly = true;
            this.dgv_materiasM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_materiasM.Size = new System.Drawing.Size(568, 219);
            this.dgv_materiasM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materias matriculadas actualmente.";
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // error2
            // 
            this.error2.ContainerControl = this;
            // 
            // error3
            // 
            this.error3.ContainerControl = this;
            // 
            // error4
            // 
            this.error4.ContainerControl = this;
            // 
            // error5
            // 
            this.error5.ContainerControl = this;
            // 
            // G_menuEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p_materiaM);
            this.Controls.Add(this.p_perfilEst);
            this.Controls.Add(this.panel1);
            this.Name = "G_menuEstudiante";
            this.Text = "G_menuEstudiante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.G_menuEstudiante_FormClosing);
            this.Load += new System.EventHandler(this.G_menuEstudiante_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.p_perfilEst.ResumeLayout(false);
            this.p_perfilEst.PerformLayout();
            this.p_materiaM.ResumeLayout(false);
            this.p_materiaM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materiasM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel p_perfilEst;
        private System.Windows.Forms.MaskedTextBox msk_fechaNacEst;
        private System.Windows.Forms.MaskedTextBox msk_telefonoEst;
        private System.Windows.Forms.MaskedTextBox msk_ideEst;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_actEst;
        private System.Windows.Forms.TextBox txt_nombreEst;
        private System.Windows.Forms.TextBox txt_apellidoUnoEst;
        private System.Windows.Forms.TextBox txt_apellidoDosEst;
        private System.Windows.Forms.TextBox txt_direccionEst;
        private System.Windows.Forms.TextBox txt_emailEst;
        private System.Windows.Forms.TextBox txt_usuEst;
        private System.Windows.Forms.TextBox txt_contraEst;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_perfilEst;
        private System.Windows.Forms.Button btn_guardarEst;
        private System.Windows.Forms.Label lbl_rol;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_materiaM;
        private System.Windows.Forms.Panel p_materiaM;
        private System.Windows.Forms.DataGridView dgv_materiasM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.ErrorProvider error2;
        private System.Windows.Forms.ErrorProvider error3;
        private System.Windows.Forms.ErrorProvider error4;
        private System.Windows.Forms.ErrorProvider error5;
    }
}