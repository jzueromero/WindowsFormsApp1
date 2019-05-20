namespace WindowsFormsApp1
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
            this.Mapeo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtTextoInicial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Mapeo
            // 
            this.Mapeo.Location = new System.Drawing.Point(24, 186);
            this.Mapeo.Name = "Mapeo";
            this.Mapeo.Size = new System.Drawing.Size(222, 23);
            this.Mapeo.TabIndex = 0;
            this.Mapeo.Text = "Mapeo";
            this.Mapeo.UseVisualStyleBackColor = true;
            this.Mapeo.Click += new System.EventHandler(this.Mapeo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modelo Notify";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(24, 229);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultado.Size = new System.Drawing.Size(431, 240);
            this.txtResultado.TabIndex = 4;
            // 
            // txtTextoInicial
            // 
            this.txtTextoInicial.Location = new System.Drawing.Point(24, 12);
            this.txtTextoInicial.Multiline = true;
            this.txtTextoInicial.Name = "txtTextoInicial";
            this.txtTextoInicial.Size = new System.Drawing.Size(431, 154);
            this.txtTextoInicial.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 481);
            this.Controls.Add(this.txtTextoInicial);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Mapeo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mapeo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtTextoInicial;
    }
}

