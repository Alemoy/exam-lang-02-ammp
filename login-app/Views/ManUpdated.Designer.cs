
namespace login_app
{
    partial class ManUpdated
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
            this.cbmestado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clientregistro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbmestado
            // 
            this.cbmestado.FormattingEnabled = true;
            this.cbmestado.Items.AddRange(new object[] {
            "Sin Resolver",
            "Abierto",
            "En espera",
            "Cerrado"});
            this.cbmestado.Location = new System.Drawing.Point(117, 49);
            this.cbmestado.Name = "cbmestado";
            this.cbmestado.Size = new System.Drawing.Size(201, 21);
            this.cbmestado.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tikect Id";
            // 
            // clientregistro
            // 
            this.clientregistro.Location = new System.Drawing.Point(117, 12);
            this.clientregistro.Name = "clientregistro";
            this.clientregistro.Size = new System.Drawing.Size(201, 20);
            this.clientregistro.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Estado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManUpdated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 122);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbmestado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientregistro);
            this.Controls.Add(this.label3);
            this.Name = "ManUpdated";
            this.Text = "ManUpdated";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmestado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clientregistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}