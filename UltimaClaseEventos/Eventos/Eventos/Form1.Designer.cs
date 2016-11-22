namespace Eventos
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtboxUno = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(98, 227);        
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // txtboxUno
            // 
            this.txtboxUno.Location = new System.Drawing.Point(53, 188);
            this.txtboxUno.Name = "txtboxUno";
            this.txtboxUno.Size = new System.Drawing.Size(178, 20);
            this.txtboxUno.TabIndex = 1;
            this.txtboxUno.TextChanged += new System.EventHandler(this.txtboxUno_TextChanged);
            this.txtboxUno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAceptar_KeyPressMIO);
            this.txtboxUno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAceptar_KeyPress2);
            this.txtboxUno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAceptar_KeyPress);

            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAceptar_KeyPressMIO);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAceptar_KeyPress2);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAceptar_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtboxUno);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtboxUno;
        private System.Windows.Forms.TextBox textBox1;
    }
}

