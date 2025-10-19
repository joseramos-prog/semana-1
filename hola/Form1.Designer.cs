namespace hola
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
            this.lblnumero = new System.Windows.Forms.Label();
            this.btnsumar = new System.Windows.Forms.Button();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtrespuesta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(122, 102);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(117, 16);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "ingrese un numero";
            this.lblnumero.Click += new System.EventHandler(this.lblnumero_Click);
            // 
            // btnsumar
            // 
            this.btnsumar.Location = new System.Drawing.Point(512, 80);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(75, 23);
            this.btnsumar.TabIndex = 1;
            this.btnsumar.Text = "sumar";
            this.btnsumar.UseVisualStyleBackColor = true;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(324, 80);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 22);
            this.txtnumero.TabIndex = 2;
            // 
            // txtrespuesta
            // 
            this.txtrespuesta.Location = new System.Drawing.Point(324, 163);
            this.txtrespuesta.Name = "txtrespuesta";
            this.txtrespuesta.Size = new System.Drawing.Size(100, 22);
            this.txtrespuesta.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtrespuesta);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.lblnumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtrespuesta;
    }
}

