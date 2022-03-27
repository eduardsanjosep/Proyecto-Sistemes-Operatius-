namespace Juego
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crearusuario = new System.Windows.Forms.RadioButton();
            this.login = new System.Windows.Forms.RadioButton();
            this.maskills = new System.Windows.Forms.RadioButton();
            this.maspartidas = new System.Windows.Forms.RadioButton();
            this.masganadas = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Cpassword = new System.Windows.Forms.TextBox();
            this.crear = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.psswd = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.Button();
            this.consulta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(34, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "CONNECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "DISCONNECT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.consulta);
            this.groupBox1.Controls.Add(this.masganadas);
            this.groupBox1.Controls.Add(this.maspartidas);
            this.groupBox1.Controls.Add(this.maskills);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.crearusuario);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(34, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 511);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // crearusuario
            // 
            this.crearusuario.AutoSize = true;
            this.crearusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.crearusuario.Location = new System.Drawing.Point(34, 76);
            this.crearusuario.Name = "crearusuario";
            this.crearusuario.Size = new System.Drawing.Size(124, 20);
            this.crearusuario.TabIndex = 0;
            this.crearusuario.TabStop = true;
            this.crearusuario.Text = "CREATE USER";
            this.crearusuario.UseVisualStyleBackColor = true;
            this.crearusuario.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login.Location = new System.Drawing.Point(34, 123);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(68, 20);
            this.login.TabIndex = 1;
            this.login.TabStop = true;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = true;
            this.login.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // maskills
            // 
            this.maskills.AutoSize = true;
            this.maskills.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maskills.Location = new System.Drawing.Point(34, 174);
            this.maskills.Name = "maskills";
            this.maskills.Size = new System.Drawing.Size(158, 20);
            this.maskills.TabIndex = 2;
            this.maskills.TabStop = true;
            this.maskills.Text = "Jugador con más kills";
            this.maskills.UseVisualStyleBackColor = true;
            this.maskills.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // maspartidas
            // 
            this.maspartidas.AutoSize = true;
            this.maspartidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maspartidas.Location = new System.Drawing.Point(34, 220);
            this.maspartidas.Name = "maspartidas";
            this.maspartidas.Size = new System.Drawing.Size(253, 20);
            this.maspartidas.TabIndex = 3;
            this.maspartidas.TabStop = true;
            this.maspartidas.Text = "Jugador que ha ganado más partidas";
            this.maspartidas.UseVisualStyleBackColor = true;
            // 
            // masganadas
            // 
            this.masganadas.AutoSize = true;
            this.masganadas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.masganadas.Location = new System.Drawing.Point(34, 269);
            this.masganadas.Name = "masganadas";
            this.masganadas.Size = new System.Drawing.Size(236, 20);
            this.masganadas.TabIndex = 4;
            this.masganadas.TabStop = true;
            this.masganadas.Text = "Jugador con más partidas jugadas";
            this.masganadas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.crear);
            this.groupBox2.Controls.Add(this.Cpassword);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.username);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Label10);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(479, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 279);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN UP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(36, 111);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(75, 16);
            this.Label10.TabIndex = 2;
            this.Label10.Text = "Password";
            this.Label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password confirmation";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(38, 68);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(228, 22);
            this.username.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(39, 130);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(228, 22);
            this.password.TabIndex = 5;
            // 
            // Cpassword
            // 
            this.Cpassword.Location = new System.Drawing.Point(38, 193);
            this.Cpassword.Name = "Cpassword";
            this.Cpassword.Size = new System.Drawing.Size(227, 22);
            this.Cpassword.TabIndex = 6;
            // 
            // crear
            // 
            this.crear.Location = new System.Drawing.Point(241, 238);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(109, 35);
            this.crear.TabIndex = 7;
            this.crear.Text = "SIGN UP";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.log);
            this.groupBox3.Controls.Add(this.psswd);
            this.groupBox3.Controls.Add(this.user);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(478, 429);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 206);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(139, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "LOGIN";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(26, 65);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(238, 22);
            this.user.TabIndex = 3;
            // 
            // psswd
            // 
            this.psswd.Location = new System.Drawing.Point(28, 115);
            this.psswd.Name = "psswd";
            this.psswd.Size = new System.Drawing.Size(235, 22);
            this.psswd.TabIndex = 4;
            // 
            // log
            // 
            this.log.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.log.Location = new System.Drawing.Point(242, 162);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(105, 38);
            this.log.TabIndex = 5;
            this.log.Text = "LOGIN";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // consulta
            // 
            this.consulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consulta.Location = new System.Drawing.Point(244, 467);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(101, 36);
            this.consulta.TabIndex = 5;
            this.consulta.Text = "SEND";
            this.consulta.UseVisualStyleBackColor = true;
            this.consulta.Click += new System.EventHandler(this.consulta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(93, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "CONSULTAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1390, 720);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton masganadas;
        private System.Windows.Forms.RadioButton maspartidas;
        private System.Windows.Forms.RadioButton maskills;
        private System.Windows.Forms.RadioButton login;
        private System.Windows.Forms.RadioButton crearusuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cpassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.TextBox psswd;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button consulta;
        private System.Windows.Forms.Label label7;
    }
}

