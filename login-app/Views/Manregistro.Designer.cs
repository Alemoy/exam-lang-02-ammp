
namespace login_app
{
    partial class Manregistro
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
            this.label4 = new System.Windows.Forms.Label();
            this.clientregistro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.detalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.modelo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.marca = new System.Windows.Forms.TextBox();
            this.cbmservi = new System.Windows.Forms.ComboBox();
            this.cbmestado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cliente Registro";
            // 
            // clientregistro
            // 
            this.clientregistro.Location = new System.Drawing.Point(106, 47);
            this.clientregistro.Name = "clientregistro";
            this.clientregistro.Size = new System.Drawing.Size(201, 20);
            this.clientregistro.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Servicio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Detalle";
            // 
            // detalle
            // 
            this.detalle.Location = new System.Drawing.Point(106, 132);
            this.detalle.Name = "detalle";
            this.detalle.Size = new System.Drawing.Size(201, 20);
            this.detalle.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Modelo";
            // 
            // modelo
            // 
            this.modelo.Location = new System.Drawing.Point(106, 216);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(201, 20);
            this.modelo.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Marca";
            // 
            // marca
            // 
            this.marca.Location = new System.Drawing.Point(106, 173);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(201, 20);
            this.marca.TabIndex = 21;
            // 
            // cbmservi
            // 
            this.cbmservi.FormattingEnabled = true;
            this.cbmservi.Location = new System.Drawing.Point(106, 12);
            this.cbmservi.Name = "cbmservi";
            this.cbmservi.Size = new System.Drawing.Size(201, 21);
            this.cbmservi.TabIndex = 25;
            // 
            // cbmestado
            // 
            this.cbmestado.FormattingEnabled = true;
            this.cbmestado.Items.AddRange(new object[] {
            "Sin Resolver",
            "Abierto",
            "En espera",
            "Cerrado"});
            this.cbmestado.Location = new System.Drawing.Point(106, 84);
            this.cbmestado.Name = "cbmestado";
            this.cbmestado.Size = new System.Drawing.Size(201, 21);
            this.cbmestado.TabIndex = 26;
            // 
            // Manregistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 308);
            this.Controls.Add(this.cbmestado);
            this.Controls.Add(this.cbmservi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.detalle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientregistro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Manregistro";
            this.Text = "Manregistro";
            this.Load += new System.EventHandler(this.Manregistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clientregistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox detalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox modelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox marca;
        private System.Windows.Forms.ComboBox cbmservi;
        private System.Windows.Forms.ComboBox cbmestado;
    }
}