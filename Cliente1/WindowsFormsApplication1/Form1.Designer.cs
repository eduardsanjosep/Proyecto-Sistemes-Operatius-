namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maspartidas = new System.Windows.Forms.RadioButton();
            this.masganadas = new System.Windows.Forms.RadioButton();
            this.maskills = new System.Windows.Forms.RadioButton();
            this.login = new System.Windows.Forms.RadioButton();
            this.crearusuario = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.interfazcreacionusuario = new System.Windows.Forms.GroupBox();
            this.crear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmacontraseña = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.nombreusuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Loguear = new System.Windows.Forms.GroupBox();
            this.log = new System.Windows.Forms.Button();
            this.contr = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Label();
            this.u = new System.Windows.Forms.Label();
            this.lin = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.interfazcreacionusuario.SuspendLayout();
            this.Loguear.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.maspartidas);
            this.groupBox1.Controls.Add(this.masganadas);
            this.groupBox1.Controls.Add(this.maskills);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.crearusuario);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(45, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 315);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // maspartidas
            // 
            this.maspartidas.AutoSize = true;
            this.maspartidas.Location = new System.Drawing.Point(158, 196);
            this.maspartidas.Name = "maspartidas";
            this.maspartidas.Size = new System.Drawing.Size(186, 17);
            this.maspartidas.TabIndex = 16;
            this.maspartidas.TabStop = true;
            this.maspartidas.Text = "Jugador con más partidas jugadas";
            this.maspartidas.UseVisualStyleBackColor = true;
            // 
            // masganadas
            // 
            this.masganadas.AutoSize = true;
            this.masganadas.Location = new System.Drawing.Point(158, 159);
            this.masganadas.Name = "masganadas";
            this.masganadas.Size = new System.Drawing.Size(200, 17);
            this.masganadas.TabIndex = 15;
            this.masganadas.TabStop = true;
            this.masganadas.Text = "Jugador que ha ganado más partidas";
            this.masganadas.UseVisualStyleBackColor = true;
            // 
            // maskills
            // 
            this.maskills.AutoSize = true;
            this.maskills.Location = new System.Drawing.Point(158, 126);
            this.maskills.Name = "maskills";
            this.maskills.Size = new System.Drawing.Size(126, 17);
            this.maskills.TabIndex = 14;
            this.maskills.TabStop = true;
            this.maskills.Text = "Jugador con más kills";
            this.maskills.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.ForeColor = System.Drawing.SystemColors.Desktop;
            this.login.Location = new System.Drawing.Point(158, 95);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(97, 17);
            this.login.TabIndex = 13;
            this.login.TabStop = true;
            this.login.Text = "Log In (aun no)";
            this.login.UseVisualStyleBackColor = true;
            // 
            // crearusuario
            // 
            this.crearusuario.AutoSize = true;
            this.crearusuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.crearusuario.Location = new System.Drawing.Point(158, 66);
            this.crearusuario.Name = "crearusuario";
            this.crearusuario.Size = new System.Drawing.Size(162, 17);
            this.crearusuario.TabIndex = 12;
            this.crearusuario.TabStop = true;
            this.crearusuario.Text = "Crear usuario nuevo (aun no)";
            this.crearusuario.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "Desconectar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // interfazcreacionusuario
            // 
            this.interfazcreacionusuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.interfazcreacionusuario.Controls.Add(this.crear);
            this.interfazcreacionusuario.Controls.Add(this.label7);
            this.interfazcreacionusuario.Controls.Add(this.label6);
            this.interfazcreacionusuario.Controls.Add(this.label5);
            this.interfazcreacionusuario.Controls.Add(this.confirmacontraseña);
            this.interfazcreacionusuario.Controls.Add(this.contraseña);
            this.interfazcreacionusuario.Controls.Add(this.nombreusuario);
            this.interfazcreacionusuario.Controls.Add(this.label4);
            this.interfazcreacionusuario.Location = new System.Drawing.Point(589, 78);
            this.interfazcreacionusuario.Name = "interfazcreacionusuario";
            this.interfazcreacionusuario.Size = new System.Drawing.Size(296, 221);
            this.interfazcreacionusuario.TabIndex = 8;
            this.interfazcreacionusuario.TabStop = false;
            this.interfazcreacionusuario.Enter += new System.EventHandler(this.interfazcreacionusuario_Enter);
            // 
            // crear
            // 
            this.crear.Location = new System.Drawing.Point(110, 174);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(75, 23);
            this.crear.TabIndex = 7;
            this.crear.Text = "Crear usuario";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Confirmar contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre usuario";
            // 
            // confirmacontraseña
            // 
            this.confirmacontraseña.Location = new System.Drawing.Point(156, 136);
            this.confirmacontraseña.Name = "confirmacontraseña";
            this.confirmacontraseña.Size = new System.Drawing.Size(100, 20);
            this.confirmacontraseña.TabIndex = 3;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(156, 100);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(100, 20);
            this.contraseña.TabIndex = 2;
            // 
            // nombreusuario
            // 
            this.nombreusuario.Location = new System.Drawing.Point(156, 64);
            this.nombreusuario.Name = "nombreusuario";
            this.nombreusuario.Size = new System.Drawing.Size(100, 20);
            this.nombreusuario.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Creación de usuario";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Loguear
            // 
            this.Loguear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Loguear.Controls.Add(this.log);
            this.Loguear.Controls.Add(this.contr);
            this.Loguear.Controls.Add(this.usuario);
            this.Loguear.Controls.Add(this.c);
            this.Loguear.Controls.Add(this.u);
            this.Loguear.Controls.Add(this.lin);
            this.Loguear.Location = new System.Drawing.Point(589, 340);
            this.Loguear.Name = "Loguear";
            this.Loguear.Size = new System.Drawing.Size(306, 197);
            this.Loguear.TabIndex = 10;
            this.Loguear.TabStop = false;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(110, 159);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 5;
            this.log.Text = "Log In";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // contr
            // 
            this.contr.Location = new System.Drawing.Point(143, 110);
            this.contr.Name = "contr";
            this.contr.Size = new System.Drawing.Size(100, 20);
            this.contr.TabIndex = 4;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(143, 63);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 3;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(49, 113);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(61, 13);
            this.c.TabIndex = 2;
            this.c.Text = "Contraseña";
            // 
            // u
            // 
            this.u.AutoSize = true;
            this.u.Location = new System.Drawing.Point(49, 70);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(43, 13);
            this.u.TabIndex = 1;
            this.u.Text = "Usuario";
            // 
            // lin
            // 
            this.lin.AutoSize = true;
            this.lin.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lin.Location = new System.Drawing.Point(123, 16);
            this.lin.Name = "lin";
            this.lin.Size = new System.Drawing.Size(46, 15);
            this.lin.TabIndex = 0;
            this.lin.Text = "Log In";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 686);
            this.Controls.Add(this.Loguear);
            this.Controls.Add(this.interfazcreacionusuario);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.interfazcreacionusuario.ResumeLayout(false);
            this.interfazcreacionusuario.PerformLayout();
            this.Loguear.ResumeLayout(false);
            this.Loguear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox interfazcreacionusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton crearusuario;
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox confirmacontraseña;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox nombreusuario;
        private System.Windows.Forms.RadioButton maspartidas;
        private System.Windows.Forms.RadioButton masganadas;
        private System.Windows.Forms.RadioButton maskills;
        private System.Windows.Forms.RadioButton login;
        private System.Windows.Forms.GroupBox Loguear;
        private System.Windows.Forms.TextBox contr;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label u;
        private System.Windows.Forms.Label lin;
        private System.Windows.Forms.Button log;
    }
}

