namespace Grafico.Folder_Login
{
    partial class G_recuperar
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.btn_validar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.btn_recuperar = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_email = new System.Windows.Forms.GroupBox();
            this.gb_nuevaContra = new System.Windows.Forms.GroupBox();
            this.btn_nuevaContra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_contraAct = new System.Windows.Forms.TextBox();
            this.gb_cod = new System.Windows.Forms.GroupBox();
            this.gb_email.SuspendLayout();
            this.gb_nuevaContra.SuspendLayout();
            this.gb_cod.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "¿No recibiste el codigo?";
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.White;
            this.btn_volver.ForeColor = System.Drawing.Color.Black;
            this.btn_volver.Location = new System.Drawing.Point(66, 152);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(95, 23);
            this.btn_volver.TabIndex = 14;
            this.btn_volver.Text = "Volver a intentar.";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // btn_validar
            // 
            this.btn_validar.BackColor = System.Drawing.Color.White;
            this.btn_validar.ForeColor = System.Drawing.Color.Black;
            this.btn_validar.Location = new System.Drawing.Point(76, 92);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(75, 23);
            this.btn_validar.TabIndex = 13;
            this.btn_validar.Text = "Validar.";
            this.btn_validar.UseVisualStyleBackColor = false;
            this.btn_validar.Click += new System.EventHandler(this.btn_validar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingrese el codigo.";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(25, 66);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(177, 20);
            this.txt_codigo.TabIndex = 11;
            // 
            // btn_recuperar
            // 
            this.btn_recuperar.BackColor = System.Drawing.Color.White;
            this.btn_recuperar.ForeColor = System.Drawing.Color.Black;
            this.btn_recuperar.Location = new System.Drawing.Point(49, 133);
            this.btn_recuperar.Name = "btn_recuperar";
            this.btn_recuperar.Size = new System.Drawing.Size(139, 23);
            this.btn_recuperar.TabIndex = 10;
            this.btn_recuperar.Text = "Enviar Codigo.";
            this.btn_recuperar.UseVisualStyleBackColor = false;
            this.btn_recuperar.Click += new System.EventHandler(this.btn_recuperar_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(47, 92);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(143, 20);
            this.txt_email.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese los datos solicitados.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email.";
            // 
            // gb_email
            // 
            this.gb_email.BackColor = System.Drawing.Color.CadetBlue;
            this.gb_email.Controls.Add(this.label1);
            this.gb_email.Controls.Add(this.label4);
            this.gb_email.Controls.Add(this.txt_email);
            this.gb_email.Controls.Add(this.btn_recuperar);
            this.gb_email.Location = new System.Drawing.Point(12, 10);
            this.gb_email.Name = "gb_email";
            this.gb_email.Size = new System.Drawing.Size(237, 217);
            this.gb_email.TabIndex = 17;
            this.gb_email.TabStop = false;
            // 
            // gb_nuevaContra
            // 
            this.gb_nuevaContra.BackColor = System.Drawing.Color.CadetBlue;
            this.gb_nuevaContra.Controls.Add(this.btn_nuevaContra);
            this.gb_nuevaContra.Controls.Add(this.label5);
            this.gb_nuevaContra.Controls.Add(this.txt_contraAct);
            this.gb_nuevaContra.Location = new System.Drawing.Point(12, 12);
            this.gb_nuevaContra.Name = "gb_nuevaContra";
            this.gb_nuevaContra.Size = new System.Drawing.Size(237, 215);
            this.gb_nuevaContra.TabIndex = 19;
            this.gb_nuevaContra.TabStop = false;
            this.gb_nuevaContra.Visible = false;
            // 
            // btn_nuevaContra
            // 
            this.btn_nuevaContra.BackColor = System.Drawing.Color.White;
            this.btn_nuevaContra.ForeColor = System.Drawing.Color.Black;
            this.btn_nuevaContra.Location = new System.Drawing.Point(84, 92);
            this.btn_nuevaContra.Name = "btn_nuevaContra";
            this.btn_nuevaContra.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevaContra.TabIndex = 2;
            this.btn_nuevaContra.Text = "Guardar.";
            this.btn_nuevaContra.UseVisualStyleBackColor = false;
            this.btn_nuevaContra.Click += new System.EventHandler(this.btn_nuevaContra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nueva Contraseña.";
            // 
            // txt_contraAct
            // 
            this.txt_contraAct.Location = new System.Drawing.Point(50, 66);
            this.txt_contraAct.Name = "txt_contraAct";
            this.txt_contraAct.Size = new System.Drawing.Size(143, 20);
            this.txt_contraAct.TabIndex = 0;
            // 
            // gb_cod
            // 
            this.gb_cod.BackColor = System.Drawing.Color.CadetBlue;
            this.gb_cod.Controls.Add(this.label2);
            this.gb_cod.Controls.Add(this.txt_codigo);
            this.gb_cod.Controls.Add(this.label3);
            this.gb_cod.Controls.Add(this.btn_validar);
            this.gb_cod.Controls.Add(this.btn_volver);
            this.gb_cod.Location = new System.Drawing.Point(12, 12);
            this.gb_cod.Name = "gb_cod";
            this.gb_cod.Size = new System.Drawing.Size(237, 215);
            this.gb_cod.TabIndex = 18;
            this.gb_cod.TabStop = false;
            this.gb_cod.Visible = false;
            // 
            // G_recuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(261, 239);
            this.Controls.Add(this.gb_cod);
            this.Controls.Add(this.gb_nuevaContra);
            this.Controls.Add(this.gb_email);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "G_recuperar";
            this.Text = "G_recuperar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.G_recuperar_FormClosing);
            this.Load += new System.EventHandler(this.G_recuperar_Load);
            this.gb_email.ResumeLayout(false);
            this.gb_email.PerformLayout();
            this.gb_nuevaContra.ResumeLayout(false);
            this.gb_nuevaContra.PerformLayout();
            this.gb_cod.ResumeLayout(false);
            this.gb_cod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button btn_recuperar;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb_email;
        private System.Windows.Forms.GroupBox gb_cod;
        private System.Windows.Forms.GroupBox gb_nuevaContra;
        private System.Windows.Forms.Button btn_nuevaContra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_contraAct;
    }
}