namespace practico1
{
    partial class Formulario1
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
            this.B_GUARDAR = new System.Windows.Forms.Button();
            this.B_ELIMINAR = new System.Windows.Forms.Button();
            this.T_NOMBRE = new System.Windows.Forms.TextBox();
            this.T_APELLIDO = new System.Windows.Forms.TextBox();
            this.L_NOMBRE = new System.Windows.Forms.Label();
            this.L_APELLIDO = new System.Windows.Forms.Label();
            this.T_MULTILINEA = new System.Windows.Forms.TextBox();
            this.B_SALIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_GUARDAR
            // 
            this.B_GUARDAR.Location = new System.Drawing.Point(48, 172);
            this.B_GUARDAR.Name = "B_GUARDAR";
            this.B_GUARDAR.Size = new System.Drawing.Size(75, 23);
            this.B_GUARDAR.TabIndex = 0;
            this.B_GUARDAR.Text = "Guardar";
            this.B_GUARDAR.UseVisualStyleBackColor = true;
            this.B_GUARDAR.Click += new System.EventHandler(this.B_GUARDAR_Click);
            // 
            // B_ELIMINAR
            // 
            this.B_ELIMINAR.Location = new System.Drawing.Point(173, 172);
            this.B_ELIMINAR.Name = "B_ELIMINAR";
            this.B_ELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.B_ELIMINAR.TabIndex = 1;
            this.B_ELIMINAR.Text = "Eliminar";
            this.B_ELIMINAR.UseVisualStyleBackColor = true;
            this.B_ELIMINAR.Click += new System.EventHandler(this.B_ELIMINAR_Click);
            // 
            // T_NOMBRE
            // 
            this.T_NOMBRE.Location = new System.Drawing.Point(127, 50);
            this.T_NOMBRE.Name = "T_NOMBRE";
            this.T_NOMBRE.Size = new System.Drawing.Size(100, 20);
            this.T_NOMBRE.TabIndex = 2;
            // 
            // T_APELLIDO
            // 
            this.T_APELLIDO.Location = new System.Drawing.Point(127, 102);
            this.T_APELLIDO.Name = "T_APELLIDO";
            this.T_APELLIDO.Size = new System.Drawing.Size(100, 20);
            this.T_APELLIDO.TabIndex = 3;
            // 
            // L_NOMBRE
            // 
            this.L_NOMBRE.AutoSize = true;
            this.L_NOMBRE.Location = new System.Drawing.Point(45, 57);
            this.L_NOMBRE.Name = "L_NOMBRE";
            this.L_NOMBRE.Size = new System.Drawing.Size(44, 13);
            this.L_NOMBRE.TabIndex = 4;
            this.L_NOMBRE.Text = "Nombre";
            // 
            // L_APELLIDO
            // 
            this.L_APELLIDO.AutoSize = true;
            this.L_APELLIDO.Location = new System.Drawing.Point(45, 109);
            this.L_APELLIDO.Name = "L_APELLIDO";
            this.L_APELLIDO.Size = new System.Drawing.Size(44, 13);
            this.L_APELLIDO.TabIndex = 5;
            this.L_APELLIDO.Text = "Apellido";
            // 
            // T_MULTILINEA
            // 
            this.T_MULTILINEA.Location = new System.Drawing.Point(298, 50);
            this.T_MULTILINEA.Multiline = true;
            this.T_MULTILINEA.Name = "T_MULTILINEA";
            this.T_MULTILINEA.Size = new System.Drawing.Size(130, 145);
            this.T_MULTILINEA.TabIndex = 6;
            // 
            // B_SALIR
            // 
            this.B_SALIR.Location = new System.Drawing.Point(397, 226);
            this.B_SALIR.Name = "B_SALIR";
            this.B_SALIR.Size = new System.Drawing.Size(75, 23);
            this.B_SALIR.TabIndex = 7;
            this.B_SALIR.Text = "Salir";
            this.B_SALIR.UseVisualStyleBackColor = true;
            this.B_SALIR.Click += new System.EventHandler(this.B_SALIR_Click);
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.B_SALIR);
            this.Controls.Add(this.T_MULTILINEA);
            this.Controls.Add(this.L_APELLIDO);
            this.Controls.Add(this.L_NOMBRE);
            this.Controls.Add(this.T_APELLIDO);
            this.Controls.Add(this.T_NOMBRE);
            this.Controls.Add(this.B_ELIMINAR);
            this.Controls.Add(this.B_GUARDAR);
            this.KeyPreview = true;
            this.Name = "Formulario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi primer forms";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Formulario1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_GUARDAR;
        private System.Windows.Forms.Button B_ELIMINAR;
        private System.Windows.Forms.TextBox T_NOMBRE;
        private System.Windows.Forms.TextBox T_APELLIDO;
        private System.Windows.Forms.Label L_NOMBRE;
        private System.Windows.Forms.Label L_APELLIDO;
        private System.Windows.Forms.TextBox T_MULTILINEA;
        private System.Windows.Forms.Button B_SALIR;
    }
}

