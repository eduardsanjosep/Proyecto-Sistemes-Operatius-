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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.consulta = new System.Windows.Forms.Button();
            this.masganadas = new System.Windows.Forms.RadioButton();
            this.maspartidas = new System.Windows.Forms.RadioButton();
            this.maskills = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.psswd = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.crear = new System.Windows.Forms.Button();
            this.Cpassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ListaConectados = new System.Windows.Forms.Label();
            this.conectados = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.conectados);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.consulta);
            this.groupBox1.Controls.Add(this.masganadas);
            this.groupBox1.Controls.Add(this.maspartidas);
            this.groupBox1.Controls.Add(this.maskills);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(26, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(268, 301);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(70, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "CONSULTAS";
            // 
            // consulta
            // 
            this.consulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.consulta.Location = new System.Drawing.Point(188, 266);
            this.consulta.Margin = new System.Windows.Forms.Padding(2);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(76, 29);
            this.consulta.TabIndex = 5;
            this.consulta.Text = "SEND";
            this.consulta.UseVisualStyleBackColor = true;
            this.consulta.Click += new System.EventHandler(this.consulta_Click);
            // 
            // masganadas
            // 
            this.masganadas.AutoSize = true;
            this.masganadas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.masganadas.Location = new System.Drawing.Point(24, 157);
            this.masganadas.Margin = new System.Windows.Forms.Padding(2);
            this.masganadas.Name = "masganadas";
            this.masganadas.Size = new System.Drawing.Size(186, 17);
            this.masganadas.TabIndex = 4;
            this.masganadas.TabStop = true;
            this.masganadas.Text = "Jugador con más partidas jugadas";
            this.masganadas.UseVisualStyleBackColor = true;
            this.masganadas.CheckedChanged += new System.EventHandler(this.masganadas_CheckedChanged);
            // 
            // maspartidas
            // 
            this.maspartidas.AutoSize = true;
            this.maspartidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maspartidas.Location = new System.Drawing.Point(24, 117);
            this.maspartidas.Margin = new System.Windows.Forms.Padding(2);
            this.maspartidas.Name = "maspartidas";
            this.maspartidas.Size = new System.Drawing.Size(200, 17);
            this.maspartidas.TabIndex = 3;
            this.maspartidas.TabStop = true;
            this.maspartidas.Text = "Jugador que ha ganado más partidas";
            this.maspartidas.UseVisualStyleBackColor = true;
            // 
            // maskills
            // 
            this.maskills.AutoSize = true;
            this.maskills.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maskills.Location = new System.Drawing.Point(24, 80);
            this.maskills.Margin = new System.Windows.Forms.Padding(2);
            this.maskills.Name = "maskills";
            this.maskills.Size = new System.Drawing.Size(126, 17);
            this.maskills.TabIndex = 2;
            this.maskills.TabStop = true;
            this.maskills.Text = "Jugador con más kills";
            this.maskills.UseVisualStyleBackColor = true;
            this.maskills.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.crear);
            this.groupBox2.Controls.Add(this.Cpassword);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.username);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Label10);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(471, 233);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(267, 227);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.log);
            this.groupBox3.Controls.Add(this.psswd);
            this.groupBox3.Controls.Add(this.user);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(267, 227);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(9, 191);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "SIGN UP!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // log
            // 
            this.log.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.log.Location = new System.Drawing.Point(184, 191);
            this.log.Margin = new System.Windows.Forms.Padding(2);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(79, 31);
            this.log.TabIndex = 5;
            this.log.Text = "LOGIN";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // psswd
            // 
            this.psswd.Location = new System.Drawing.Point(31, 106);
            this.psswd.Margin = new System.Windows.Forms.Padding(2);
            this.psswd.Name = "psswd";
            this.psswd.Size = new System.Drawing.Size(177, 20);
            this.psswd.TabIndex = 4;
            this.psswd.TextChanged += new System.EventHandler(this.psswd_TextChanged);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(28, 55);
            this.user.Margin = new System.Windows.Forms.Padding(2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(180, 20);
            this.user.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(28, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(104, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "LOGIN";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // crear
            // 
            this.crear.Location = new System.Drawing.Point(181, 193);
            this.crear.Margin = new System.Windows.Forms.Padding(2);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(82, 28);
            this.crear.TabIndex = 7;
            this.crear.Text = "SIGN UP";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.button3_Click);
            // 
            // Cpassword
            // 
            this.Cpassword.Location = new System.Drawing.Point(28, 157);
            this.Cpassword.Margin = new System.Windows.Forms.Padding(2);
            this.Cpassword.Name = "Cpassword";
            this.Cpassword.Size = new System.Drawing.Size(180, 20);
            this.Cpassword.TabIndex = 6;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(29, 106);
            this.password.Margin = new System.Windows.Forms.Padding(2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(179, 20);
            this.password.TabIndex = 5;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(28, 55);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(180, 20);
            this.username.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password confirmation";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(27, 90);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(61, 13);
            this.Label10.TabIndex = 2;
            this.Label10.Text = "Password";
            this.Label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN UP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1012, 622);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "DISCONNECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListaConectados
            // 
            this.ListaConectados.Location = new System.Drawing.Point(827, 233);
            this.ListaConectados.MaximumSize = new System.Drawing.Size(1500, 1500);
            this.ListaConectados.Name = "ListaConectados";
            this.ListaConectados.Size = new System.Drawing.Size(224, 173);
            this.ListaConectados.TabIndex = 6;
            // 
            // conectados
            // 
            this.conectados.AutoSize = true;
            this.conectados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.conectados.Location = new System.Drawing.Point(24, 200);
            this.conectados.Margin = new System.Windows.Forms.Padding(2);
            this.conectados.Name = "conectados";
            this.conectados.Size = new System.Drawing.Size(133, 17);
            this.conectados.TabIndex = 7;
            this.conectados.TabStop = true;
            this.conectados.Text = "Jugadores conectados";
            this.conectados.UseVisualStyleBackColor = true;
            this.conectados.CheckedChanged += new System.EventHandler(this.conectados_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1154, 686);
            this.Controls.Add(this.ListaConectados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPACE DEATHCORE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton masganadas;
        private System.Windows.Forms.RadioButton maspartidas;
        private System.Windows.Forms.RadioButton maskills;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ListaConectados;
        private System.Windows.Forms.RadioButton conectados;
    }
}

