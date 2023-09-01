namespace practico4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LAB_DESDE = new System.Windows.Forms.Label();
            this.LAB_HASTA = new System.Windows.Forms.Label();
            this.TXT_DESDE = new System.Windows.Forms.TextBox();
            this.TXT_HASTA = new System.Windows.Forms.TextBox();
            this.BUT_GENERAR = new System.Windows.Forms.Button();
            this.LAB_LISTA = new System.Windows.Forms.Label();
            this.LBOX_NUMEROS = new System.Windows.Forms.ListBox();
            this.CLB_PAR_IMPAR_PRIMO = new System.Windows.Forms.CheckedListBox();
            this.CH_NUMERITOS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BUT_GRAFICAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CH_NUMERITOS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LAB_DESDE
            // 
            this.LAB_DESDE.AutoSize = true;
            this.LAB_DESDE.Location = new System.Drawing.Point(50, 39);
            this.LAB_DESDE.Name = "LAB_DESDE";
            this.LAB_DESDE.Size = new System.Drawing.Size(38, 13);
            this.LAB_DESDE.TabIndex = 0;
            this.LAB_DESDE.Text = "Desde";
            // 
            // LAB_HASTA
            // 
            this.LAB_HASTA.AutoSize = true;
            this.LAB_HASTA.Location = new System.Drawing.Point(50, 93);
            this.LAB_HASTA.Name = "LAB_HASTA";
            this.LAB_HASTA.Size = new System.Drawing.Size(35, 13);
            this.LAB_HASTA.TabIndex = 1;
            this.LAB_HASTA.Text = "Hasta";
            // 
            // TXT_DESDE
            // 
            this.TXT_DESDE.Location = new System.Drawing.Point(153, 39);
            this.TXT_DESDE.Name = "TXT_DESDE";
            this.TXT_DESDE.Size = new System.Drawing.Size(100, 20);
            this.TXT_DESDE.TabIndex = 2;
            this.TXT_DESDE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_DESDE_KeyPress);
            // 
            // TXT_HASTA
            // 
            this.TXT_HASTA.Location = new System.Drawing.Point(153, 93);
            this.TXT_HASTA.Name = "TXT_HASTA";
            this.TXT_HASTA.Size = new System.Drawing.Size(100, 20);
            this.TXT_HASTA.TabIndex = 3;
            this.TXT_HASTA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_HASTA_KeyPress);
            // 
            // BUT_GENERAR
            // 
            this.BUT_GENERAR.Location = new System.Drawing.Point(24, 151);
            this.BUT_GENERAR.Name = "BUT_GENERAR";
            this.BUT_GENERAR.Size = new System.Drawing.Size(100, 23);
            this.BUT_GENERAR.TabIndex = 4;
            this.BUT_GENERAR.Text = "Generar función";
            this.BUT_GENERAR.UseVisualStyleBackColor = true;
            this.BUT_GENERAR.Click += new System.EventHandler(this.BUT_GENERAR_Click);
            // 
            // LAB_LISTA
            // 
            this.LAB_LISTA.AutoSize = true;
            this.LAB_LISTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_LISTA.Location = new System.Drawing.Point(179, 34);
            this.LAB_LISTA.Name = "LAB_LISTA";
            this.LAB_LISTA.Size = new System.Drawing.Size(147, 20);
            this.LAB_LISTA.TabIndex = 6;
            this.LAB_LISTA.Text = "Lista de numeros";
            // 
            // LBOX_NUMEROS
            // 
            this.LBOX_NUMEROS.FormattingEnabled = true;
            this.LBOX_NUMEROS.Location = new System.Drawing.Point(290, 27);
            this.LBOX_NUMEROS.Name = "LBOX_NUMEROS";
            this.LBOX_NUMEROS.Size = new System.Drawing.Size(200, 173);
            this.LBOX_NUMEROS.TabIndex = 7;
            // 
            // CLB_PAR_IMPAR_PRIMO
            // 
            this.CLB_PAR_IMPAR_PRIMO.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CLB_PAR_IMPAR_PRIMO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CLB_PAR_IMPAR_PRIMO.CheckOnClick = true;
            this.CLB_PAR_IMPAR_PRIMO.FormattingEnabled = true;
            this.CLB_PAR_IMPAR_PRIMO.Items.AddRange(new object[] {
            "Numeros pares",
            "Numeros impares",
            "Numeros primos"});
            this.CLB_PAR_IMPAR_PRIMO.Location = new System.Drawing.Point(153, 151);
            this.CLB_PAR_IMPAR_PRIMO.Name = "CLB_PAR_IMPAR_PRIMO";
            this.CLB_PAR_IMPAR_PRIMO.Size = new System.Drawing.Size(119, 45);
            this.CLB_PAR_IMPAR_PRIMO.TabIndex = 14;
            this.CLB_PAR_IMPAR_PRIMO.SelectedIndexChanged += new System.EventHandler(this.CLB_PAR_IMPAR_PRIMO_SelectedIndexChanged);
            // 
            // CH_NUMERITOS
            // 
            chartArea1.Name = "ChartArea1";
            this.CH_NUMERITOS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.CH_NUMERITOS.Legends.Add(legend1);
            this.CH_NUMERITOS.Location = new System.Drawing.Point(549, 34);
            this.CH_NUMERITOS.Name = "CH_NUMERITOS";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "serie_numeros";
            this.CH_NUMERITOS.Series.Add(series1);
            this.CH_NUMERITOS.Size = new System.Drawing.Size(323, 300);
            this.CH_NUMERITOS.TabIndex = 15;
            this.CH_NUMERITOS.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BUT_GRAFICAR);
            this.panel1.Controls.Add(this.TXT_DESDE);
            this.panel1.Controls.Add(this.LAB_DESDE);
            this.panel1.Controls.Add(this.LBOX_NUMEROS);
            this.panel1.Controls.Add(this.CLB_PAR_IMPAR_PRIMO);
            this.panel1.Controls.Add(this.LAB_HASTA);
            this.panel1.Controls.Add(this.TXT_HASTA);
            this.panel1.Controls.Add(this.BUT_GENERAR);
            this.panel1.Location = new System.Drawing.Point(17, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 235);
            this.panel1.TabIndex = 16;
            // 
            // BUT_GRAFICAR
            // 
            this.BUT_GRAFICAR.Location = new System.Drawing.Point(24, 191);
            this.BUT_GRAFICAR.Name = "BUT_GRAFICAR";
            this.BUT_GRAFICAR.Size = new System.Drawing.Size(100, 23);
            this.BUT_GRAFICAR.TabIndex = 15;
            this.BUT_GRAFICAR.Text = "Generar grafico";
            this.BUT_GRAFICAR.UseVisualStyleBackColor = true;
            this.BUT_GRAFICAR.Click += new System.EventHandler(this.BUT_GRAFICAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CH_NUMERITOS);
            this.Controls.Add(this.LAB_LISTA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CH_NUMERITOS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAB_DESDE;
        private System.Windows.Forms.Label LAB_HASTA;
        private System.Windows.Forms.TextBox TXT_DESDE;
        private System.Windows.Forms.TextBox TXT_HASTA;
        private System.Windows.Forms.Button BUT_GENERAR;
        private System.Windows.Forms.Label LAB_LISTA;
        private System.Windows.Forms.ListBox LBOX_NUMEROS;
        private System.Windows.Forms.CheckedListBox CLB_PAR_IMPAR_PRIMO;
        private System.Windows.Forms.DataVisualization.Charting.Chart CH_NUMERITOS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BUT_GRAFICAR;
    }
}

