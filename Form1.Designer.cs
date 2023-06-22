
namespace CLIENTEPARCHIS
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
            this.Login = new System.Windows.Forms.RadioButton();
            this.Registrarse = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.conectar = new System.Windows.Forms.Button();
            this.enviar = new System.Windows.Forms.Button();
            this.matrizconectados = new System.Windows.Forms.DataGridView();
            this.desconectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Jugar = new System.Windows.Forms.Button();
            this.Invitar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comentar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Eliminar_Usuario = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.matrizconectados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(16, 16);
            this.Login.Margin = new System.Windows.Forms.Padding(2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(51, 17);
            this.Login.TabIndex = 0;
            this.Login.TabStop = true;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // Registrarse
            // 
            this.Registrarse.AutoSize = true;
            this.Registrarse.Location = new System.Drawing.Point(16, 38);
            this.Registrarse.Margin = new System.Windows.Forms.Padding(2);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(78, 17);
            this.Registrarse.TabIndex = 1;
            this.Registrarse.TabStop = true;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 109);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 155);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 3;
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(526, 105);
            this.conectar.Margin = new System.Windows.Forms.Padding(2);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(21, 15);
            this.conectar.TabIndex = 9;
            this.conectar.Text = "Conectar";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.conectar_Click);
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(16, 195);
            this.enviar.Margin = new System.Windows.Forms.Padding(2);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(123, 22);
            this.enviar.TabIndex = 10;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // matrizconectados
            // 
            this.matrizconectados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrizconectados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.matrizconectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizconectados.Location = new System.Drawing.Point(22, 325);
            this.matrizconectados.Margin = new System.Windows.Forms.Padding(2);
            this.matrizconectados.Name = "matrizconectados";
            this.matrizconectados.RowHeadersWidth = 51;
            this.matrizconectados.RowTemplate.Height = 24;
            this.matrizconectados.Size = new System.Drawing.Size(183, 280);
            this.matrizconectados.TabIndex = 11;
            this.matrizconectados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.matrizconectados_CellContentClick);
            // 
            // desconectar
            // 
            this.desconectar.Location = new System.Drawing.Point(184, 17);
            this.desconectar.Margin = new System.Windows.Forms.Padding(2);
            this.desconectar.Name = "desconectar";
            this.desconectar.Size = new System.Drawing.Size(76, 62);
            this.desconectar.TabIndex = 12;
            this.desconectar.Text = "Cerrar Sesión";
            this.desconectar.UseVisualStyleBackColor = true;
            this.desconectar.Click += new System.EventHandler(this.desconectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contrasenya";
            // 
            // Jugar
            // 
            this.Jugar.Location = new System.Drawing.Point(225, 414);
            this.Jugar.Margin = new System.Windows.Forms.Padding(2);
            this.Jugar.Name = "Jugar";
            this.Jugar.Size = new System.Drawing.Size(172, 76);
            this.Jugar.TabIndex = 16;
            this.Jugar.Text = "Jugar";
            this.Jugar.UseVisualStyleBackColor = true;
            this.Jugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // Invitar
            // 
            this.Invitar.Location = new System.Drawing.Point(250, 352);
            this.Invitar.Margin = new System.Windows.Forms.Padding(2);
            this.Invitar.Name = "Invitar";
            this.Invitar.Size = new System.Drawing.Size(122, 37);
            this.Invitar.TabIndex = 17;
            this.Invitar.Text = "Invitar";
            this.Invitar.UseVisualStyleBackColor = true;
            this.Invitar.Click += new System.EventHandler(this.Invitar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Selecciona el username de la persona que desee invitar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(324, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(306, 225);
            this.listBox1.TabIndex = 22;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(324, 256);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(306, 20);
            this.textBox7.TabIndex = 23;
            // 
            // comentar
            // 
            this.comentar.Location = new System.Drawing.Point(324, 282);
            this.comentar.Name = "comentar";
            this.comentar.Size = new System.Drawing.Size(306, 23);
            this.comentar.TabIndex = 24;
            this.comentar.Text = "Comentar";
            this.comentar.UseVisualStyleBackColor = true;
            this.comentar.Click += new System.EventHandler(this.comentar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CLIENTEPARCHIS.Properties.Resources.ocultar;
            this.pictureBox2.Location = new System.Drawing.Point(144, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CLIENTEPARCHIS.Properties.Resources.imagen_ver;
            this.pictureBox1.Location = new System.Drawing.Point(148, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Eliminar_Usuario
            // 
            this.Eliminar_Usuario.AutoSize = true;
            this.Eliminar_Usuario.Location = new System.Drawing.Point(16, 62);
            this.Eliminar_Usuario.Name = "Eliminar_Usuario";
            this.Eliminar_Usuario.Size = new System.Drawing.Size(98, 17);
            this.Eliminar_Usuario.TabIndex = 28;
            this.Eliminar_Usuario.TabStop = true;
            this.Eliminar_Usuario.Text = "Eliminar usuario";
            this.Eliminar_Usuario.UseVisualStyleBackColor = true;
            this.Eliminar_Usuario.CheckedChanged += new System.EventHandler(this.Eliminar_Usuario_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 609);
            this.Controls.Add(this.Eliminar_Usuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comentar);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Invitar);
            this.Controls.Add(this.Jugar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desconectar);
            this.Controls.Add(this.matrizconectados);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.conectar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matrizconectados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Login;
        private System.Windows.Forms.RadioButton Registrarse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.Button enviar;
        private System.Windows.Forms.DataGridView matrizconectados;
        private System.Windows.Forms.Button desconectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Jugar;
        private System.Windows.Forms.Button Invitar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button comentar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton Eliminar_Usuario;
    }
}

