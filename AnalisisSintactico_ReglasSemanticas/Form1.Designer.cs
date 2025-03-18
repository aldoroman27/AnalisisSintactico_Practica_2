namespace AnalisisSintactico_ReglasSemanticas
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
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.PilaExpresion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Practica 2: Analisis  Sintactico Con Reglas Semanticas";
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.BackColor = System.Drawing.Color.Lime;
            this.btnAnalizar.Location = new System.Drawing.Point(125, 113);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(75, 23);
            this.btnAnalizar.TabIndex = 1;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = false;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Crimson;
            this.btnBorrar.Location = new System.Drawing.Point(314, 113);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(125, 58);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(264, 20);
            this.txtExpresion.TabIndex = 3;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(217, 95);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(35, 13);
            this.Resultado.TabIndex = 4;
            this.Resultado.Text = "label2";
            this.Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Resultado.Visible = false;
            // 
            // PilaExpresion
            // 
            this.PilaExpresion.AutoSize = true;
            this.PilaExpresion.Location = new System.Drawing.Point(197, 152);
            this.PilaExpresion.Name = "PilaExpresion";
            this.PilaExpresion.Size = new System.Drawing.Size(35, 13);
            this.PilaExpresion.TabIndex = 5;
            this.PilaExpresion.Text = "label2";
            this.PilaExpresion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PilaExpresion.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 245);
            this.Controls.Add(this.PilaExpresion);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.txtExpresion);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practica 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Label PilaExpresion;
    }
}

