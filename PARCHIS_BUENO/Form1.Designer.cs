
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
            this.button1 = new System.Windows.Forms.Button();
            this.Barcelona = new System.Windows.Forms.RadioButton();
            this.Posicion = new System.Windows.Forms.RadioButton();
            this.Resultado = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Barcelona
            // 
            this.Barcelona.AutoSize = true;
            this.Barcelona.Location = new System.Drawing.Point(214, 97);
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
            this.Posicion.Location = new System.Drawing.Point(214, 152);
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
            this.Resultado.Location = new System.Drawing.Point(214, 219);
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
            this.textBox1.Location = new System.Drawing.Point(214, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(405, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(214, 249);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(405, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 491);
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
    }
}

