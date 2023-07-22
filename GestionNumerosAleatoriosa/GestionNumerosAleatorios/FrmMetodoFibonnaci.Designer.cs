namespace GestionNumerosAleatorios
{
    partial class FrmMetodoFibonnaci
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_GenerarAleatorios = new System.Windows.Forms.TextBox();
            this.Btn_GenerarAleatorios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Semilla01 = new System.Windows.Forms.TextBox();
            this.Txt_c = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(218, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de PseudoAletorios";
            // 
            // Txt_GenerarAleatorios
            // 
            this.Txt_GenerarAleatorios.Location = new System.Drawing.Point(428, 40);
            this.Txt_GenerarAleatorios.Name = "Txt_GenerarAleatorios";
            this.Txt_GenerarAleatorios.Size = new System.Drawing.Size(100, 22);
            this.Txt_GenerarAleatorios.TabIndex = 2;
            // 
            // Btn_GenerarAleatorios
            // 
            this.Btn_GenerarAleatorios.Location = new System.Drawing.Point(615, 39);
            this.Btn_GenerarAleatorios.Name = "Btn_GenerarAleatorios";
            this.Btn_GenerarAleatorios.Size = new System.Drawing.Size(75, 23);
            this.Btn_GenerarAleatorios.TabIndex = 3;
            this.Btn_GenerarAleatorios.Text = "Generar";
            this.Btn_GenerarAleatorios.UseVisualStyleBackColor = true;
            this.Btn_GenerarAleatorios.Click += new System.EventHandler(this.Btn_GenerarAleatorios_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Semillas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "X0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "X1";
            // 
            // Txt_Semilla01
            // 
            this.Txt_Semilla01.Location = new System.Drawing.Point(93, 117);
            this.Txt_Semilla01.Name = "Txt_Semilla01";
            this.Txt_Semilla01.Size = new System.Drawing.Size(100, 22);
            this.Txt_Semilla01.TabIndex = 7;
            // 
            // Txt_c
            // 
            this.Txt_c.Location = new System.Drawing.Point(93, 152);
            this.Txt_c.Name = "Txt_c";
            this.Txt_c.Size = new System.Drawing.Size(100, 22);
            this.Txt_c.TabIndex = 8;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(705, 372);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 9;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // FrmMetodoFibonnaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 407);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Txt_c);
            this.Controls.Add(this.Txt_Semilla01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_GenerarAleatorios);
            this.Controls.Add(this.Txt_GenerarAleatorios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmMetodoFibonnaci";
            this.Text = "FrmMetodoFibonnaci";
            this.Load += new System.EventHandler(this.FrmMetodoFibonnaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_GenerarAleatorios;
        private System.Windows.Forms.Button Btn_GenerarAleatorios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Semilla01;
        private System.Windows.Forms.TextBox Txt_c;
        private System.Windows.Forms.Button Btn_Guardar;
    }
}