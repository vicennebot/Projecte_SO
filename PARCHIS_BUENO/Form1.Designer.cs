
namespace PARCHIS_BUENO
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
            this.Barcelona = new System.Windows.Forms.RadioButton();
            this.Posicion = new System.Windows.Forms.RadioButton();
            this.Resultado = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.RadioButton();
            this.Registrarse = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.mostrarconectados = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tablero = new System.Windows.Forms.Panel();
            this.amarilloLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.tablero.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Barcelona
            // 
            this.Barcelona.AutoSize = true;
            this.Barcelona.Location = new System.Drawing.Point(12, 89);
            this.Barcelona.Name = "Barcelona";
            this.Barcelona.Size = new System.Drawing.Size(519, 21);
            this.Barcelona.TabIndex = 1;
            this.Barcelona.TabStop = true;
            this.Barcelona.Text = "Jugadores que han ganado en una ciudad (introduce el nombre de la ciudad)";
            this.Barcelona.UseVisualStyleBackColor = true;
            this.Barcelona.CheckedChanged += new System.EventHandler(this.Barcelona_CheckedChanged);
            // 
            // Posicion
            // 
            this.Posicion.AutoSize = true;
            this.Posicion.Location = new System.Drawing.Point(12, 144);
            this.Posicion.Name = "Posicion";
            this.Posicion.Size = new System.Drawing.Size(325, 21);
            this.Posicion.TabIndex = 2;
            this.Posicion.TabStop = true;
            this.Posicion.Text = "En que posición está un jugador por username";
            this.Posicion.UseVisualStyleBackColor = true;
            this.Posicion.CheckedChanged += new System.EventHandler(this.Posicion_CheckedChanged);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(12, 214);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(398, 21);
            this.Resultado.TabIndex = 3;
            this.Resultado.TabStop = true;
            this.Resultado.Text = "Dime el ganador de la partida (introduce el id de la misma)";
            this.Resultado.UseVisualStyleBackColor = true;
            this.Resultado.CheckedChanged += new System.EventHandler(this.Resultado_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(402, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 241);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(402, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 7;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(12, 15);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(227, 21);
            this.Login.TabIndex = 8;
            this.Login.TabStop = true;
            this.Login.Text = "Log in (username/contrasenya)";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.CheckedChanged += new System.EventHandler(this.Login_CheckedChanged);
            // 
            // Registrarse
            // 
            this.Registrarse.AutoSize = true;
            this.Registrarse.Location = new System.Drawing.Point(256, 15);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(262, 21);
            this.Registrarse.TabIndex = 9;
            this.Registrarse.TabStop = true;
            this.Registrarse.Text = "Registrarse (username/contraseña, )";
            this.Registrarse.UseVisualStyleBackColor = true;
            this.Registrarse.CheckedChanged += new System.EventHandler(this.Registrarse_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(256, 49);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(420, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 49);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(209, 22);
            this.textBox5.TabIndex = 11;
            // 
            // mostrarconectados
            // 
            this.mostrarconectados.AutoSize = true;
            this.mostrarconectados.Location = new System.Drawing.Point(12, 286);
            this.mostrarconectados.Name = "mostrarconectados";
            this.mostrarconectados.Size = new System.Drawing.Size(203, 21);
            this.mostrarconectados.TabIndex = 13;
            this.mostrarconectados.TabStop = true;
            this.mostrarconectados.Text = "Mostrar lista de conectados";
            this.mostrarconectados.UseVisualStyleBackColor = true;
            this.mostrarconectados.CheckedChanged += new System.EventHandler(this.mostrarconectados_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tablero);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(508, 509);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(9, 8);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // tablero
            // 
            this.tablero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tablero.BackgroundImage")));
            this.tablero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tablero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablero.Controls.Add(this.amarilloLbl);
            this.tablero.Location = new System.Drawing.Point(5, 5);
            this.tablero.Margin = new System.Windows.Forms.Padding(4);
            this.tablero.Name = "tablero";
            this.tablero.Size = new System.Drawing.Size(1101, 833);
            this.tablero.TabIndex = 1;
            // 
            // amarilloLbl
            // 
            this.amarilloLbl.BackColor = System.Drawing.Color.Yellow;
            this.amarilloLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.amarilloLbl.Location = new System.Drawing.Point(900, 657);
            this.amarilloLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amarilloLbl.Name = "amarilloLbl";
            this.amarilloLbl.Size = new System.Drawing.Size(37, 36);
            this.amarilloLbl.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(603, 477);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(51, 84);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(524, 180);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 802);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(900, 657);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 36);
            this.label3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 808);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mostrarconectados);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Posicion);
            this.Controls.Add(this.Barcelona);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tablero.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Barcelona;
        private System.Windows.Forms.RadioButton Posicion;
        private System.Windows.Forms.RadioButton Resultado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Login;
        private System.Windows.Forms.RadioButton Registrarse;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton mostrarconectados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel tablero;
        private System.Windows.Forms.Label amarilloLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}

