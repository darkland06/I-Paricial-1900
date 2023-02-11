
namespace Ejercicio_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NotaTexbox1 = new System.Windows.Forms.TextBox();
            this.NotaTexbox2 = new System.Windows.Forms.TextBox();
            this.NotaTexbox3 = new System.Windows.Forms.TextBox();
            this.NotaTexbox4 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PromedioTexbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 4";
            // 
            // NotaTexbox1
            // 
            this.NotaTexbox1.Location = new System.Drawing.Point(53, 92);
            this.NotaTexbox1.Name = "NotaTexbox1";
            this.NotaTexbox1.Size = new System.Drawing.Size(46, 20);
            this.NotaTexbox1.TabIndex = 4;
            // 
            // NotaTexbox2
            // 
            this.NotaTexbox2.Location = new System.Drawing.Point(53, 153);
            this.NotaTexbox2.Name = "NotaTexbox2";
            this.NotaTexbox2.Size = new System.Drawing.Size(46, 20);
            this.NotaTexbox2.TabIndex = 5;
            // 
            // NotaTexbox3
            // 
            this.NotaTexbox3.Location = new System.Drawing.Point(53, 215);
            this.NotaTexbox3.Name = "NotaTexbox3";
            this.NotaTexbox3.Size = new System.Drawing.Size(46, 20);
            this.NotaTexbox3.TabIndex = 6;
            // 
            // NotaTexbox4
            // 
            this.NotaTexbox4.Location = new System.Drawing.Point(53, 280);
            this.NotaTexbox4.Name = "NotaTexbox4";
            this.NotaTexbox4.Size = new System.Drawing.Size(46, 20);
            this.NotaTexbox4.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(24, 321);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "PROMEDIO:";
            // 
            // PromedioTexbox
            // 
            this.PromedioTexbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromedioTexbox.Location = new System.Drawing.Point(220, 153);
            this.PromedioTexbox.Multiline = true;
            this.PromedioTexbox.Name = "PromedioTexbox";
            this.PromedioTexbox.ReadOnly = true;
            this.PromedioTexbox.Size = new System.Drawing.Size(131, 91);
            this.PromedioTexbox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.PromedioTexbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.NotaTexbox4);
            this.Controls.Add(this.NotaTexbox3);
            this.Controls.Add(this.NotaTexbox2);
            this.Controls.Add(this.NotaTexbox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio #2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NotaTexbox1;
        private System.Windows.Forms.TextBox NotaTexbox2;
        private System.Windows.Forms.TextBox NotaTexbox3;
        private System.Windows.Forms.TextBox NotaTexbox4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PromedioTexbox;
    }
}

