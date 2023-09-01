namespace practico2
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
            this.LAB_DNI = new System.Windows.Forms.Label();
            this.LAB_NOMBRE = new System.Windows.Forms.Label();
            this.LAB_APELLIDO = new System.Windows.Forms.Label();
            this.LAB_NYA = new System.Windows.Forms.Label();
            this.LAB_MODIFICAR = new System.Windows.Forms.Label();
            this.TXT_DNI = new System.Windows.Forms.TextBox();
            this.TXT_NOMBRE = new System.Windows.Forms.TextBox();
            this.TXT_APELLIDO = new System.Windows.Forms.TextBox();
            this.BUT_GUARDAR = new System.Windows.Forms.Button();
            this.BUT_ELIMINAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LAB_DNI
            // 
            this.LAB_DNI.AutoSize = true;
            this.LAB_DNI.Location = new System.Drawing.Point(115, 121);
            this.LAB_DNI.Name = "LAB_DNI";
            this.LAB_DNI.Size = new System.Drawing.Size(26, 13);
            this.LAB_DNI.TabIndex = 0;
            this.LAB_DNI.Text = "DNI";
            // 
            // LAB_NOMBRE
            // 
            this.LAB_NOMBRE.AutoSize = true;
            this.LAB_NOMBRE.Location = new System.Drawing.Point(115, 170);
            this.LAB_NOMBRE.Name = "LAB_NOMBRE";
            this.LAB_NOMBRE.Size = new System.Drawing.Size(44, 13);
            this.LAB_NOMBRE.TabIndex = 1;
            this.LAB_NOMBRE.Text = "Nombre";
            // 
            // LAB_APELLIDO
            // 
            this.LAB_APELLIDO.AutoSize = true;
            this.LAB_APELLIDO.Location = new System.Drawing.Point(115, 224);
            this.LAB_APELLIDO.Name = "LAB_APELLIDO";
            this.LAB_APELLIDO.Size = new System.Drawing.Size(44, 13);
            this.LAB_APELLIDO.TabIndex = 2;
            this.LAB_APELLIDO.Text = "Apellido";
            // 
            // LAB_NYA
            // 
            this.LAB_NYA.AutoSize = true;
            this.LAB_NYA.Location = new System.Drawing.Point(115, 45);
            this.LAB_NYA.Name = "LAB_NYA";
            this.LAB_NYA.Size = new System.Drawing.Size(94, 13);
            this.LAB_NYA.TabIndex = 3;
            this.LAB_NYA.Text = "Nombre y apellido:";
            // 
            // LAB_MODIFICAR
            // 
            this.LAB_MODIFICAR.AutoSize = true;
            this.LAB_MODIFICAR.ForeColor = System.Drawing.Color.Red;
            this.LAB_MODIFICAR.Location = new System.Drawing.Point(253, 45);
            this.LAB_MODIFICAR.Name = "LAB_MODIFICAR";
            this.LAB_MODIFICAR.Size = new System.Drawing.Size(50, 13);
            this.LAB_MODIFICAR.TabIndex = 4;
            this.LAB_MODIFICAR.Text = "Modificar";
            // 
            // TXT_DNI
            // 
            this.TXT_DNI.Location = new System.Drawing.Point(256, 113);
            this.TXT_DNI.Name = "TXT_DNI";
            this.TXT_DNI.Size = new System.Drawing.Size(100, 20);
            this.TXT_DNI.TabIndex = 5;
            this.TXT_DNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_DNI_KeyPress);
            // 
            // TXT_NOMBRE
            // 
            this.TXT_NOMBRE.Location = new System.Drawing.Point(256, 163);
            this.TXT_NOMBRE.Name = "TXT_NOMBRE";
            this.TXT_NOMBRE.Size = new System.Drawing.Size(100, 20);
            this.TXT_NOMBRE.TabIndex = 6;
            this.TXT_NOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_NOMBRE_KeyPress);
            // 
            // TXT_APELLIDO
            // 
            this.TXT_APELLIDO.Location = new System.Drawing.Point(256, 216);
            this.TXT_APELLIDO.Name = "TXT_APELLIDO";
            this.TXT_APELLIDO.Size = new System.Drawing.Size(100, 20);
            this.TXT_APELLIDO.TabIndex = 7;
            this.TXT_APELLIDO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_APELLIDO_KeyPress);
            // 
            // BUT_GUARDAR
            // 
            this.BUT_GUARDAR.Location = new System.Drawing.Point(118, 303);
            this.BUT_GUARDAR.Name = "BUT_GUARDAR";
            this.BUT_GUARDAR.Size = new System.Drawing.Size(75, 23);
            this.BUT_GUARDAR.TabIndex = 8;
            this.BUT_GUARDAR.Text = "Guardar";
            this.BUT_GUARDAR.UseVisualStyleBackColor = true;
            this.BUT_GUARDAR.Click += new System.EventHandler(this.BUT_GUARDAR_Click);
            // 
            // BUT_ELIMINAR
            // 
            this.BUT_ELIMINAR.Location = new System.Drawing.Point(281, 303);
            this.BUT_ELIMINAR.Name = "BUT_ELIMINAR";
            this.BUT_ELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.BUT_ELIMINAR.TabIndex = 9;
            this.BUT_ELIMINAR.Text = "Eliminar";
            this.BUT_ELIMINAR.UseVisualStyleBackColor = true;
            this.BUT_ELIMINAR.Click += new System.EventHandler(this.BUT_ELIMINAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.BUT_ELIMINAR);
            this.Controls.Add(this.BUT_GUARDAR);
            this.Controls.Add(this.TXT_APELLIDO);
            this.Controls.Add(this.TXT_NOMBRE);
            this.Controls.Add(this.TXT_DNI);
            this.Controls.Add(this.LAB_MODIFICAR);
            this.Controls.Add(this.LAB_NYA);
            this.Controls.Add(this.LAB_APELLIDO);
            this.Controls.Add(this.LAB_NOMBRE);
            this.Controls.Add(this.LAB_DNI);
            this.Name = "Form1";
            this.Text = "Pequeño formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAB_DNI;
        private System.Windows.Forms.Label LAB_NOMBRE;
        private System.Windows.Forms.Label LAB_APELLIDO;
        private System.Windows.Forms.Label LAB_NYA;
        private System.Windows.Forms.Label LAB_MODIFICAR;
        private System.Windows.Forms.TextBox TXT_DNI;
        private System.Windows.Forms.TextBox TXT_NOMBRE;
        private System.Windows.Forms.TextBox TXT_APELLIDO;
        private System.Windows.Forms.Button BUT_GUARDAR;
        private System.Windows.Forms.Button BUT_ELIMINAR;
    }
}

