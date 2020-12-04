namespace Grafico.Folder_Profe
{
    partial class G_menuProfe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_cursos = new System.Windows.Forms.Panel();
            this.btn_buscarMat = new System.Windows.Forms.Button();
            this.txt_buscarMat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_listaEstProf = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_perfilProf = new System.Windows.Forms.Button();
            this.btn_cursosAsig = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.p_perfil = new System.Windows.Forms.Panel();
            this.btn_guardarE = new System.Windows.Forms.Button();
            this.msk_fechaNacE = new System.Windows.Forms.MaskedTextBox();
            this.msk_telefonoE = new System.Windows.Forms.MaskedTextBox();
            this.msk_ideE = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_actE = new System.Windows.Forms.Button();
            this.txt_nombreE = new System.Windows.Forms.TextBox();
            this.txt_apellidoUnoE = new System.Windows.Forms.TextBox();
            this.txt_apellidoDosE = new System.Windows.Forms.TextBox();
            this.txt_direccionE = new System.Windows.Forms.TextBox();
            this.txt_emailE = new System.Windows.Forms.TextBox();
            this.txt_usuE = new System.Windows.Forms.TextBox();
            this.txt_contraE = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.p_cursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaEstProf)).BeginInit();
            this.p_perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_rol);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Controls.Add(this.btn_perfilProf);
            this.panel1.Controls.Add(this.btn_cursosAsig);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 379);
            this.panel1.TabIndex = 0;
            // 
            // p_cursos
            // 
            this.p_cursos.Controls.Add(this.btn_buscarMat);
            this.p_cursos.Controls.Add(this.txt_buscarMat);
            this.p_cursos.Controls.Add(this.label3);
            this.p_cursos.Controls.Add(this.dgv_listaEstProf);
            this.p_cursos.Controls.Add(this.label4);
            this.p_cursos.Controls.Add(this.label2);
            this.p_cursos.Location = new System.Drawing.Point(203, 22);
            this.p_cursos.Name = "p_cursos";
            this.p_cursos.Size = new System.Drawing.Size(585, 402);
            this.p_cursos.TabIndex = 1;
            this.p_cursos.Visible = false;
            // 
            // btn_buscarMat
            // 
            this.btn_buscarMat.BackColor = System.Drawing.Color.White;
            this.btn_buscarMat.ForeColor = System.Drawing.Color.Black;
            this.btn_buscarMat.Location = new System.Drawing.Point(184, 107);
            this.btn_buscarMat.Name = "btn_buscarMat";
            this.btn_buscarMat.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarMat.TabIndex = 7;
            this.btn_buscarMat.Text = "Filtrar.";
            this.btn_buscarMat.UseVisualStyleBackColor = false;
            this.btn_buscarMat.Click += new System.EventHandler(this.btn_buscarMat_Click);
            // 
            // txt_buscarMat
            // 
            this.txt_buscarMat.Location = new System.Drawing.Point(21, 110);
            this.txt_buscarMat.Name = "txt_buscarMat";
            this.txt_buscarMat.Size = new System.Drawing.Size(157, 20);
            this.txt_buscarMat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese el curso por el cual quiere filtrar.";
            // 
            // dgv_listaEstProf
            // 
            this.dgv_listaEstProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaEstProf.Location = new System.Drawing.Point(21, 193);
            this.dgv_listaEstProf.Name = "dgv_listaEstProf";
            this.dgv_listaEstProf.Size = new System.Drawing.Size(544, 191);
            this.dgv_listaEstProf.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lista de estudiantes.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "LISTA DE CURSOS Y ESTUDIANTES ASIGNADOS.";
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rol.Location = new System.Drawing.Point(13, 36);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(25, 14);
            this.lbl_rol.TabIndex = 0;
            this.lbl_rol.Text = "xxx";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(13, 13);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(25, 14);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "xxx";
            // 
            // btn_perfilProf
            // 
            this.btn_perfilProf.BackColor = System.Drawing.Color.White;
            this.btn_perfilProf.ForeColor = System.Drawing.Color.Black;
            this.btn_perfilProf.Location = new System.Drawing.Point(40, 75);
            this.btn_perfilProf.Name = "btn_perfilProf";
            this.btn_perfilProf.Size = new System.Drawing.Size(75, 23);
            this.btn_perfilProf.TabIndex = 1;
            this.btn_perfilProf.Text = "Perfil.";
            this.btn_perfilProf.UseVisualStyleBackColor = false;
            this.btn_perfilProf.Click += new System.EventHandler(this.btn_perfilProf_Click);
            // 
            // btn_cursosAsig
            // 
            this.btn_cursosAsig.BackColor = System.Drawing.Color.White;
            this.btn_cursosAsig.ForeColor = System.Drawing.Color.Black;
            this.btn_cursosAsig.Location = new System.Drawing.Point(40, 104);
            this.btn_cursosAsig.Name = "btn_cursosAsig";
            this.btn_cursosAsig.Size = new System.Drawing.Size(75, 23);
            this.btn_cursosAsig.TabIndex = 2;
            this.btn_cursosAsig.Text = "Cursos Asignados.";
            this.btn_cursosAsig.UseVisualStyleBackColor = false;
            this.btn_cursosAsig.Click += new System.EventHandler(this.btn_cursosAsig_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.White;
            this.btn_cerrar.ForeColor = System.Drawing.Color.Black;
            this.btn_cerrar.Location = new System.Drawing.Point(3, 333);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "Cerrar.";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // p_perfil
            // 
            this.p_perfil.Controls.Add(this.btn_guardarE);
            this.p_perfil.Controls.Add(this.msk_fechaNacE);
            this.p_perfil.Controls.Add(this.msk_telefonoE);
            this.p_perfil.Controls.Add(this.msk_ideE);
            this.p_perfil.Controls.Add(this.label15);
            this.p_perfil.Controls.Add(this.btn_actE);
            this.p_perfil.Controls.Add(this.txt_nombreE);
            this.p_perfil.Controls.Add(this.txt_apellidoUnoE);
            this.p_perfil.Controls.Add(this.txt_apellidoDosE);
            this.p_perfil.Controls.Add(this.txt_direccionE);
            this.p_perfil.Controls.Add(this.txt_emailE);
            this.p_perfil.Controls.Add(this.txt_usuE);
            this.p_perfil.Controls.Add(this.txt_contraE);
            this.p_perfil.Controls.Add(this.label14);
            this.p_perfil.Controls.Add(this.label13);
            this.p_perfil.Controls.Add(this.label12);
            this.p_perfil.Controls.Add(this.label10);
            this.p_perfil.Controls.Add(this.label9);
            this.p_perfil.Controls.Add(this.label8);
            this.p_perfil.Controls.Add(this.label7);
            this.p_perfil.Controls.Add(this.label6);
            this.p_perfil.Controls.Add(this.label5);
            this.p_perfil.Controls.Add(this.label1);
            this.p_perfil.Location = new System.Drawing.Point(203, 22);
            this.p_perfil.Name = "p_perfil";
            this.p_perfil.Size = new System.Drawing.Size(585, 402);
            this.p_perfil.TabIndex = 0;
            this.p_perfil.Visible = false;
            // 
            // btn_guardarE
            // 
            this.btn_guardarE.BackColor = System.Drawing.Color.White;
            this.btn_guardarE.ForeColor = System.Drawing.Color.Black;
            this.btn_guardarE.Location = new System.Drawing.Point(259, 316);
            this.btn_guardarE.Name = "btn_guardarE";
            this.btn_guardarE.Size = new System.Drawing.Size(75, 23);
            this.btn_guardarE.TabIndex = 76;
            this.btn_guardarE.Text = "Guardar.";
            this.btn_guardarE.UseVisualStyleBackColor = false;
            this.btn_guardarE.Visible = false;
            this.btn_guardarE.Click += new System.EventHandler(this.btn_guardarE_Click);
            // 
            // msk_fechaNacE
            // 
            this.msk_fechaNacE.Enabled = false;
            this.msk_fechaNacE.Location = new System.Drawing.Point(151, 250);
            this.msk_fechaNacE.Name = "msk_fechaNacE";
            this.msk_fechaNacE.Size = new System.Drawing.Size(65, 20);
            this.msk_fechaNacE.TabIndex = 75;
            // 
            // msk_telefonoE
            // 
            this.msk_telefonoE.Enabled = false;
            this.msk_telefonoE.Location = new System.Drawing.Point(24, 250);
            this.msk_telefonoE.Mask = "00-00-00-00";
            this.msk_telefonoE.Name = "msk_telefonoE";
            this.msk_telefonoE.Size = new System.Drawing.Size(100, 20);
            this.msk_telefonoE.TabIndex = 74;
            // 
            // msk_ideE
            // 
            this.msk_ideE.Enabled = false;
            this.msk_ideE.Location = new System.Drawing.Point(400, 90);
            this.msk_ideE.Mask = "0-000-000";
            this.msk_ideE.Name = "msk_ideE";
            this.msk_ideE.Size = new System.Drawing.Size(100, 20);
            this.msk_ideE.TabIndex = 73;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 14);
            this.label15.TabIndex = 72;
            this.label15.Text = "Telefono.";
            // 
            // btn_actE
            // 
            this.btn_actE.BackColor = System.Drawing.Color.White;
            this.btn_actE.ForeColor = System.Drawing.Color.Black;
            this.btn_actE.Location = new System.Drawing.Point(259, 316);
            this.btn_actE.Name = "btn_actE";
            this.btn_actE.Size = new System.Drawing.Size(75, 23);
            this.btn_actE.TabIndex = 71;
            this.btn_actE.Text = "Editar.";
            this.btn_actE.UseVisualStyleBackColor = false;
            this.btn_actE.Click += new System.EventHandler(this.btn_actE_Click);
            // 
            // txt_nombreE
            // 
            this.txt_nombreE.Enabled = false;
            this.txt_nombreE.Location = new System.Drawing.Point(24, 90);
            this.txt_nombreE.Name = "txt_nombreE";
            this.txt_nombreE.Size = new System.Drawing.Size(100, 20);
            this.txt_nombreE.TabIndex = 69;
            // 
            // txt_apellidoUnoE
            // 
            this.txt_apellidoUnoE.Enabled = false;
            this.txt_apellidoUnoE.Location = new System.Drawing.Point(159, 90);
            this.txt_apellidoUnoE.Name = "txt_apellidoUnoE";
            this.txt_apellidoUnoE.Size = new System.Drawing.Size(100, 20);
            this.txt_apellidoUnoE.TabIndex = 68;
            // 
            // txt_apellidoDosE
            // 
            this.txt_apellidoDosE.Enabled = false;
            this.txt_apellidoDosE.Location = new System.Drawing.Point(280, 90);
            this.txt_apellidoDosE.Name = "txt_apellidoDosE";
            this.txt_apellidoDosE.Size = new System.Drawing.Size(100, 20);
            this.txt_apellidoDosE.TabIndex = 67;
            // 
            // txt_direccionE
            // 
            this.txt_direccionE.Enabled = false;
            this.txt_direccionE.Location = new System.Drawing.Point(24, 146);
            this.txt_direccionE.Multiline = true;
            this.txt_direccionE.Name = "txt_direccionE";
            this.txt_direccionE.Size = new System.Drawing.Size(262, 47);
            this.txt_direccionE.TabIndex = 66;
            // 
            // txt_emailE
            // 
            this.txt_emailE.Enabled = false;
            this.txt_emailE.Location = new System.Drawing.Point(326, 146);
            this.txt_emailE.Multiline = true;
            this.txt_emailE.Name = "txt_emailE";
            this.txt_emailE.Size = new System.Drawing.Size(198, 21);
            this.txt_emailE.TabIndex = 65;
            // 
            // txt_usuE
            // 
            this.txt_usuE.Enabled = false;
            this.txt_usuE.Location = new System.Drawing.Point(277, 250);
            this.txt_usuE.Name = "txt_usuE";
            this.txt_usuE.Size = new System.Drawing.Size(100, 20);
            this.txt_usuE.TabIndex = 64;
            // 
            // txt_contraE
            // 
            this.txt_contraE.Enabled = false;
            this.txt_contraE.Location = new System.Drawing.Point(397, 250);
            this.txt_contraE.Name = "txt_contraE";
            this.txt_contraE.Size = new System.Drawing.Size(100, 20);
            this.txt_contraE.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(151, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 14);
            this.label14.TabIndex = 62;
            this.label14.Text = "Fecha Nacimiento.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 14);
            this.label13.TabIndex = 61;
            this.label13.Text = "Dirección.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(323, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 14);
            this.label12.TabIndex = 60;
            this.label12.Text = "Email.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(277, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 14);
            this.label10.TabIndex = 59;
            this.label10.Text = "Usuario.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(397, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 14);
            this.label9.TabIndex = 58;
            this.label9.Text = "Contraseña.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(397, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 14);
            this.label8.TabIndex = 57;
            this.label8.Text = "Identificación.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(156, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 14);
            this.label7.TabIndex = 56;
            this.label7.Text = "Apellido Materno.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 14);
            this.label6.TabIndex = 55;
            this.label6.Text = "Apellido paterno.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 14);
            this.label5.TabIndex = 54;
            this.label5.Text = "Nombre.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERFIL.";
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
            // G_menuProfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p_cursos);
            this.Controls.Add(this.p_perfil);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "G_menuProfe";
            this.Text = "G_menuProfe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.G_menuProfe_FormClosing);
            this.Load += new System.EventHandler(this.G_menuProfe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.p_cursos.ResumeLayout(false);
            this.p_cursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaEstProf)).EndInit();
            this.p_perfil.ResumeLayout(false);
            this.p_perfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_perfilProf;
        private System.Windows.Forms.Button btn_cursosAsig;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Panel p_perfil;
        private System.Windows.Forms.Panel p_cursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_rol;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_guardarE;
        private System.Windows.Forms.MaskedTextBox msk_fechaNacE;
        private System.Windows.Forms.MaskedTextBox msk_telefonoE;
        private System.Windows.Forms.MaskedTextBox msk_ideE;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_actE;
        private System.Windows.Forms.TextBox txt_nombreE;
        private System.Windows.Forms.TextBox txt_apellidoUnoE;
        private System.Windows.Forms.TextBox txt_apellidoDosE;
        private System.Windows.Forms.TextBox txt_direccionE;
        private System.Windows.Forms.TextBox txt_emailE;
        private System.Windows.Forms.TextBox txt_usuE;
        private System.Windows.Forms.TextBox txt_contraE;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_listaEstProf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_buscarMat;
        private System.Windows.Forms.TextBox txt_buscarMat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.ErrorProvider error2;
        private System.Windows.Forms.ErrorProvider error3;
        private System.Windows.Forms.ErrorProvider error4;
    }
}