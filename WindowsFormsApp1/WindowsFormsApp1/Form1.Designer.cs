
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
            this.aluNombre = new System.Windows.Forms.TextBox();
            this.aluNota = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listaAlumnos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aluNombre
            // 
            this.aluNombre.Location = new System.Drawing.Point(43, 47);
            this.aluNombre.Name = "aluNombre";
            this.aluNombre.Size = new System.Drawing.Size(404, 22);
            this.aluNombre.TabIndex = 0;
            // 
            // aluNota
            // 
            this.aluNota.Location = new System.Drawing.Point(477, 47);
            this.aluNota.Name = "aluNota";
            this.aluNota.Size = new System.Drawing.Size(128, 22);
            this.aluNota.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar alumno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.Location = new System.Drawing.Point(45, 104);
            this.listaAlumnos.Multiline = true;
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.ReadOnly = true;
            this.listaAlumnos.Size = new System.Drawing.Size(722, 264);
            this.listaAlumnos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listaAlumnos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aluNota);
            this.Controls.Add(this.aluNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aluNombre;
        private System.Windows.Forms.TextBox aluNota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox listaAlumnos;
    }
}

