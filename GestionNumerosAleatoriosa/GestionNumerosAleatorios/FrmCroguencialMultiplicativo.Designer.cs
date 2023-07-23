namespace GestionNumerosAleatorios
{
    partial class FrmCroguencialMultiplicativo
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
            this.Txt_m = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_a = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Txt_Semilla01 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_GenerarAleatorios = new System.Windows.Forms.Button();
            this.Txt_GenerarAleatorios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_m
            // 
            this.Txt_m.Location = new System.Drawing.Point(87, 156);
            this.Txt_m.Name = "Txt_m";
            this.Txt_m.Size = new System.Drawing.Size(100, 22);
            this.Txt_m.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "m";
            // 
            // Txt_a
            // 
            this.Txt_a.Location = new System.Drawing.Point(87, 128);
            this.Txt_a.Name = "Txt_a";
            this.Txt_a.Size = new System.Drawing.Size(100, 22);
            this.Txt_a.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "a";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(699, 351);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 23;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // Txt_Semilla01
            // 
            this.Txt_Semilla01.Location = new System.Drawing.Point(87, 96);
            this.Txt_Semilla01.Name = "Txt_Semilla01";
            this.Txt_Semilla01.Size = new System.Drawing.Size(100, 22);
            this.Txt_Semilla01.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "X0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Semillas";
            // 
            // Btn_GenerarAleatorios
            // 
            this.Btn_GenerarAleatorios.Location = new System.Drawing.Point(609, 18);
            this.Btn_GenerarAleatorios.Name = "Btn_GenerarAleatorios";
            this.Btn_GenerarAleatorios.Size = new System.Drawing.Size(75, 23);
            this.Btn_GenerarAleatorios.TabIndex = 17;
            this.Btn_GenerarAleatorios.Text = "Generar";
            this.Btn_GenerarAleatorios.UseVisualStyleBackColor = true;
            this.Btn_GenerarAleatorios.Click += new System.EventHandler(this.Btn_GenerarAleatorios_Click);
            // 
            // Txt_GenerarAleatorios
            // 
            this.Txt_GenerarAleatorios.Location = new System.Drawing.Point(422, 19);
            this.Txt_GenerarAleatorios.Name = "Txt_GenerarAleatorios";
            this.Txt_GenerarAleatorios.Size = new System.Drawing.Size(100, 22);
            this.Txt_GenerarAleatorios.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cantidad de PseudoAletorios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(212, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 271);
            this.dataGridView1.TabIndex = 14;
            // 
            // FrmCroguencialMultiplicativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 385);
            this.Controls.Add(this.Txt_m);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_a);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Txt_Semilla01);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_GenerarAleatorios);
            this.Controls.Add(this.Txt_GenerarAleatorios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCroguencialMultiplicativo";
            this.Text = "FrmCroguencialMultiplicativo";
            this.Load += new System.EventHandler(this.FrmCroguencialMultiplicativo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_m;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_a;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.TextBox Txt_Semilla01;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_GenerarAleatorios;
        private System.Windows.Forms.TextBox Txt_GenerarAleatorios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}