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
            this.L_DNI = new System.Windows.Forms.Label();
            this.L_NOMBRE = new System.Windows.Forms.Label();
            this.L_APELLIDO = new System.Windows.Forms.Label();
            this.L_NYA = new System.Windows.Forms.Label();
            this.L_ELIMINAR = new System.Windows.Forms.Label();
            this.T_DNI = new System.Windows.Forms.TextBox();
            this.T_NOMBRE = new System.Windows.Forms.TextBox();
            this.T_APELLIDO = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.T_TELEFONO = new System.Windows.Forms.TextBox();
            this.L_TELEFONO = new System.Windows.Forms.Label();
            this.RB_HOMBRE = new System.Windows.Forms.RadioButton();
            this.RB_MUJER = new System.Windows.Forms.RadioButton();
            this.CB_NARANJA = new System.Windows.Forms.CheckBox();
            this.CB_VISA = new System.Windows.Forms.CheckBox();
            this.CB_MASTERCARD = new System.Windows.Forms.CheckBox();
            this.B_SALIR = new System.Windows.Forms.Button();
            this.B_ELIMINAR = new System.Windows.Forms.Button();
            this.B_GUARDAR = new System.Windows.Forms.Button();
            this.PB_H_M = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_H_M)).BeginInit();
            this.SuspendLayout();
            // 
            // L_DNI
            // 
            this.L_DNI.AutoSize = true;
            this.L_DNI.Location = new System.Drawing.Point(21, 87);
            this.L_DNI.Name = "L_DNI";
            this.L_DNI.Size = new System.Drawing.Size(33, 13);
            this.L_DNI.TabIndex = 0;
            this.L_DNI.Text = "* DNI";
            // 
            // L_NOMBRE
            // 
            this.L_NOMBRE.AutoSize = true;
            this.L_NOMBRE.Location = new System.Drawing.Point(21, 130);
            this.L_NOMBRE.Name = "L_NOMBRE";
            this.L_NOMBRE.Size = new System.Drawing.Size(51, 13);
            this.L_NOMBRE.TabIndex = 1;
            this.L_NOMBRE.Text = "* Nombre";
            // 
            // L_APELLIDO
            // 
            this.L_APELLIDO.AutoSize = true;
            this.L_APELLIDO.Location = new System.Drawing.Point(21, 175);
            this.L_APELLIDO.Name = "L_APELLIDO";
            this.L_APELLIDO.Size = new System.Drawing.Size(51, 13);
            this.L_APELLIDO.TabIndex = 2;
            this.L_APELLIDO.Text = "* Apellido";
            // 
            // L_NYA
            // 
            this.L_NYA.AutoSize = true;
            this.L_NYA.Location = new System.Drawing.Point(25, 27);
            this.L_NYA.Name = "L_NYA";
            this.L_NYA.Size = new System.Drawing.Size(91, 13);
            this.L_NYA.TabIndex = 3;
            this.L_NYA.Text = "Nombre y apellido";
            // 
            // L_ELIMINAR
            // 
            this.L_ELIMINAR.AutoSize = true;
            this.L_ELIMINAR.ForeColor = System.Drawing.Color.Red;
            this.L_ELIMINAR.Location = new System.Drawing.Point(166, 27);
            this.L_ELIMINAR.Name = "L_ELIMINAR";
            this.L_ELIMINAR.Size = new System.Drawing.Size(50, 13);
            this.L_ELIMINAR.TabIndex = 4;
            this.L_ELIMINAR.Text = "Modificar";
            // 
            // T_DNI
            // 
            this.T_DNI.Location = new System.Drawing.Point(137, 80);
            this.T_DNI.Name = "T_DNI";
            this.T_DNI.Size = new System.Drawing.Size(100, 20);
            this.T_DNI.TabIndex = 5;
            this.T_DNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_DNI_KeyPress);
            // 
            // T_NOMBRE
            // 
            this.T_NOMBRE.Location = new System.Drawing.Point(137, 123);
            this.T_NOMBRE.Name = "T_NOMBRE";
            this.T_NOMBRE.Size = new System.Drawing.Size(100, 20);
            this.T_NOMBRE.TabIndex = 6;
            this.T_NOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_NOMBRE_KeyPress);
            // 
            // T_APELLIDO
            // 
            this.T_APELLIDO.Location = new System.Drawing.Point(137, 168);
            this.T_APELLIDO.Name = "T_APELLIDO";
            this.T_APELLIDO.Size = new System.Drawing.Size(100, 20);
            this.T_APELLIDO.TabIndex = 7;
            this.T_APELLIDO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_APELLIDO_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.T_TELEFONO);
            this.panel1.Controls.Add(this.L_TELEFONO);
            this.panel1.Controls.Add(this.L_ELIMINAR);
            this.panel1.Controls.Add(this.L_NYA);
            this.panel1.Controls.Add(this.T_DNI);
            this.panel1.Controls.Add(this.L_APELLIDO);
            this.panel1.Controls.Add(this.T_APELLIDO);
            this.panel1.Controls.Add(this.L_NOMBRE);
            this.panel1.Controls.Add(this.T_NOMBRE);
            this.panel1.Controls.Add(this.L_DNI);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(38, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 256);
            this.panel1.TabIndex = 10;
            // 
            // T_TELEFONO
            // 
            this.T_TELEFONO.Location = new System.Drawing.Point(137, 215);
            this.T_TELEFONO.Name = "T_TELEFONO";
            this.T_TELEFONO.Size = new System.Drawing.Size(100, 20);
            this.T_TELEFONO.TabIndex = 9;
            this.T_TELEFONO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.T_TELEFONO_KeyPress);
            // 
            // L_TELEFONO
            // 
            this.L_TELEFONO.AutoSize = true;
            this.L_TELEFONO.Location = new System.Drawing.Point(21, 218);
            this.L_TELEFONO.Name = "L_TELEFONO";
            this.L_TELEFONO.Size = new System.Drawing.Size(49, 13);
            this.L_TELEFONO.TabIndex = 8;
            this.L_TELEFONO.Text = "Telefono";
            // 
            // RB_HOMBRE
            // 
            this.RB_HOMBRE.AutoSize = true;
            this.RB_HOMBRE.Checked = true;
            this.RB_HOMBRE.Location = new System.Drawing.Point(351, 139);
            this.RB_HOMBRE.Name = "RB_HOMBRE";
            this.RB_HOMBRE.Size = new System.Drawing.Size(62, 17);
            this.RB_HOMBRE.TabIndex = 12;
            this.RB_HOMBRE.TabStop = true;
            this.RB_HOMBRE.Text = "Hombre";
            this.RB_HOMBRE.UseVisualStyleBackColor = true;
            this.RB_HOMBRE.CheckedChanged += new System.EventHandler(this.RB_HOMBRE_CheckedChanged);
            // 
            // RB_MUJER
            // 
            this.RB_MUJER.AutoSize = true;
            this.RB_MUJER.Location = new System.Drawing.Point(469, 139);
            this.RB_MUJER.Name = "RB_MUJER";
            this.RB_MUJER.Size = new System.Drawing.Size(51, 17);
            this.RB_MUJER.TabIndex = 13;
            this.RB_MUJER.Text = "Mujer";
            this.RB_MUJER.UseVisualStyleBackColor = true;
            // 
            // CB_NARANJA
            // 
            this.CB_NARANJA.AutoSize = true;
            this.CB_NARANJA.Location = new System.Drawing.Point(351, 184);
            this.CB_NARANJA.Name = "CB_NARANJA";
            this.CB_NARANJA.Size = new System.Drawing.Size(63, 17);
            this.CB_NARANJA.TabIndex = 14;
            this.CB_NARANJA.Text = "Naranja";
            this.CB_NARANJA.UseVisualStyleBackColor = true;
            // 
            // CB_VISA
            // 
            this.CB_VISA.AutoSize = true;
            this.CB_VISA.Location = new System.Drawing.Point(351, 218);
            this.CB_VISA.Name = "CB_VISA";
            this.CB_VISA.Size = new System.Drawing.Size(46, 17);
            this.CB_VISA.TabIndex = 15;
            this.CB_VISA.Text = "Visa";
            this.CB_VISA.UseVisualStyleBackColor = true;
            // 
            // CB_MASTERCARD
            // 
            this.CB_MASTERCARD.AutoSize = true;
            this.CB_MASTERCARD.Location = new System.Drawing.Point(351, 249);
            this.CB_MASTERCARD.Name = "CB_MASTERCARD";
            this.CB_MASTERCARD.Size = new System.Drawing.Size(79, 17);
            this.CB_MASTERCARD.TabIndex = 16;
            this.CB_MASTERCARD.Text = "Mastercard";
            this.CB_MASTERCARD.UseVisualStyleBackColor = true;
            // 
            // B_SALIR
            // 
            this.B_SALIR.Image = global::practico2.Properties.Resources.salir2;
            this.B_SALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_SALIR.Location = new System.Drawing.Point(469, 299);
            this.B_SALIR.Name = "B_SALIR";
            this.B_SALIR.Size = new System.Drawing.Size(80, 50);
            this.B_SALIR.TabIndex = 17;
            this.B_SALIR.Text = "Salir";
            this.B_SALIR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_SALIR.UseVisualStyleBackColor = true;
            this.B_SALIR.Click += new System.EventHandler(this.B_SALIR_Click);
            // 
            // B_ELIMINAR
            // 
            this.B_ELIMINAR.Image = global::practico2.Properties.Resources.eliminar2;
            this.B_ELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_ELIMINAR.Location = new System.Drawing.Point(186, 299);
            this.B_ELIMINAR.Name = "B_ELIMINAR";
            this.B_ELIMINAR.Size = new System.Drawing.Size(105, 50);
            this.B_ELIMINAR.TabIndex = 9;
            this.B_ELIMINAR.Text = "Eliminar";
            this.B_ELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_ELIMINAR.UseVisualStyleBackColor = true;
            this.B_ELIMINAR.Click += new System.EventHandler(this.B_ELIMINAR_Click);
            // 
            // B_GUARDAR
            // 
            this.B_GUARDAR.Image = global::practico2.Properties.Resources.guardar2;
            this.B_GUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.B_GUARDAR.Location = new System.Drawing.Point(38, 299);
            this.B_GUARDAR.Name = "B_GUARDAR";
            this.B_GUARDAR.Size = new System.Drawing.Size(105, 50);
            this.B_GUARDAR.TabIndex = 8;
            this.B_GUARDAR.Text = "Guardar";
            this.B_GUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_GUARDAR.UseVisualStyleBackColor = true;
            this.B_GUARDAR.Click += new System.EventHandler(this.B_GUARDAR_Click);
            // 
            // PB_H_M
            // 
            this.PB_H_M.Image = global::practico2.Properties.Resources.hombre;
            this.PB_H_M.Location = new System.Drawing.Point(382, 21);
            this.PB_H_M.Name = "PB_H_M";
            this.PB_H_M.Size = new System.Drawing.Size(100, 107);
            this.PB_H_M.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_H_M.TabIndex = 11;
            this.PB_H_M.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.B_SALIR);
            this.Controls.Add(this.CB_MASTERCARD);
            this.Controls.Add(this.B_ELIMINAR);
            this.Controls.Add(this.CB_VISA);
            this.Controls.Add(this.CB_NARANJA);
            this.Controls.Add(this.B_GUARDAR);
            this.Controls.Add(this.RB_MUJER);
            this.Controls.Add(this.RB_HOMBRE);
            this.Controls.Add(this.PB_H_M);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pequeño formulario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_H_M)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_DNI;
        private System.Windows.Forms.Label L_NOMBRE;
        private System.Windows.Forms.Label L_APELLIDO;
        private System.Windows.Forms.Label L_NYA;
        private System.Windows.Forms.Label L_ELIMINAR;
        private System.Windows.Forms.TextBox T_NOMBRE;
        private System.Windows.Forms.TextBox T_APELLIDO;
        private System.Windows.Forms.Button B_GUARDAR;
        private System.Windows.Forms.Button B_ELIMINAR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox T_DNI;
        private System.Windows.Forms.PictureBox PB_H_M;
        private System.Windows.Forms.RadioButton RB_HOMBRE;
        private System.Windows.Forms.RadioButton RB_MUJER;
        private System.Windows.Forms.CheckBox CB_NARANJA;
        private System.Windows.Forms.CheckBox CB_VISA;
        private System.Windows.Forms.CheckBox CB_MASTERCARD;
        private System.Windows.Forms.Button B_SALIR;
        private System.Windows.Forms.TextBox T_TELEFONO;
        private System.Windows.Forms.Label L_TELEFONO;
    }
}

