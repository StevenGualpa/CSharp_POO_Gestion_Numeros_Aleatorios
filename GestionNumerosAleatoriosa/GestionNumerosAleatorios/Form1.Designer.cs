namespace GestionNumerosAleatorios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_MitadCuadrado = new System.Windows.Forms.Button();
            this.Btn_Fibonacci = new System.Windows.Forms.Button();
            this.Btn_Multiplicativo = new System.Windows.Forms.Button();
            this.Btn_Mixto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Cargar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_Mixto);
            this.panel1.Controls.Add(this.Btn_Multiplicativo);
            this.panel1.Controls.Add(this.Btn_Fibonacci);
            this.panel1.Controls.Add(this.Btn_MitadCuadrado);
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 515);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Btn_Cargar);
            this.panel2.Location = new System.Drawing.Point(483, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 515);
            this.panel2.TabIndex = 1;
            // 
            // Btn_MitadCuadrado
            // 
            this.Btn_MitadCuadrado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_MitadCuadrado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MitadCuadrado.Location = new System.Drawing.Point(100, 133);
            this.Btn_MitadCuadrado.Name = "Btn_MitadCuadrado";
            this.Btn_MitadCuadrado.Size = new System.Drawing.Size(239, 60);
            this.Btn_MitadCuadrado.TabIndex = 0;
            this.Btn_MitadCuadrado.Text = "Mitad Cuadrado";
            this.Btn_MitadCuadrado.UseVisualStyleBackColor = false;
            this.Btn_MitadCuadrado.Click += new System.EventHandler(this.Btn_MitadCuadrado_Click);
            // 
            // Btn_Fibonacci
            // 
            this.Btn_Fibonacci.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Fibonacci.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fibonacci.Location = new System.Drawing.Point(100, 189);
            this.Btn_Fibonacci.Name = "Btn_Fibonacci";
            this.Btn_Fibonacci.Size = new System.Drawing.Size(239, 60);
            this.Btn_Fibonacci.TabIndex = 1;
            this.Btn_Fibonacci.Text = "Finonacci";
            this.Btn_Fibonacci.UseVisualStyleBackColor = false;
            this.Btn_Fibonacci.Click += new System.EventHandler(this.Btn_Fibonacci_Click);
            // 
            // Btn_Multiplicativo
            // 
            this.Btn_Multiplicativo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Multiplicativo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Multiplicativo.Location = new System.Drawing.Point(100, 243);
            this.Btn_Multiplicativo.Name = "Btn_Multiplicativo";
            this.Btn_Multiplicativo.Size = new System.Drawing.Size(239, 60);
            this.Btn_Multiplicativo.TabIndex = 2;
            this.Btn_Multiplicativo.Text = "Multiplicativo";
            this.Btn_Multiplicativo.UseVisualStyleBackColor = false;
            this.Btn_Multiplicativo.Click += new System.EventHandler(this.Btn_Multiplicativo_Click);
            // 
            // Btn_Mixto
            // 
            this.Btn_Mixto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Mixto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mixto.Location = new System.Drawing.Point(100, 296);
            this.Btn_Mixto.Name = "Btn_Mixto";
            this.Btn_Mixto.Size = new System.Drawing.Size(239, 60);
            this.Btn_Mixto.TabIndex = 3;
            this.Btn_Mixto.Text = "Mixto";
            this.Btn_Mixto.UseVisualStyleBackColor = false;
            this.Btn_Mixto.Click += new System.EventHandler(this.Btn_Mixto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generacion de numeros PseudoAleatorios";
            // 
            // Btn_Cargar
            // 
            this.Btn_Cargar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Btn_Cargar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cargar.Location = new System.Drawing.Point(184, 277);
            this.Btn_Cargar.Name = "Btn_Cargar";
            this.Btn_Cargar.Size = new System.Drawing.Size(239, 60);
            this.Btn_Cargar.TabIndex = 5;
            this.Btn_Cargar.Text = "Cargar y Validar";
            this.Btn_Cargar.UseVisualStyleBackColor = false;
            this.Btn_Cargar.Click += new System.EventHandler(this.Btn_Cargar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Validacion de numeros PseudoAleatorios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 721);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Mixto;
        private System.Windows.Forms.Button Btn_Multiplicativo;
        private System.Windows.Forms.Button Btn_Fibonacci;
        private System.Windows.Forms.Button Btn_MitadCuadrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Cargar;
    }
}

