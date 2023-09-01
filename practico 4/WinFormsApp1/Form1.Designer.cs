namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            labelTitulo = new Label();
            btnNumerosPares = new Button();
            btnNumerosImpares = new Button();
            btnNumerosPrimos = new Button();
            label2 = new Label();
            label1 = new Label();
            btnGenerar = new Button();
            listBoxNumeros = new ListBox();
            txtHasta = new TextBox();
            txtDesde = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(btnNumerosPares);
            panel1.Controls.Add(btnNumerosImpares);
            panel1.Controls.Add(btnNumerosPrimos);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnGenerar);
            panel1.Controls.Add(listBoxNumeros);
            panel1.Controls.Add(txtHasta);
            panel1.Controls.Add(txtDesde);
            panel1.Location = new Point(34, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 426);
            panel1.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.Location = new Point(101, 29);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(200, 32);
            labelTitulo.TabIndex = 10;
            labelTitulo.Text = "Lista de Numeros";
            // 
            // btnNumerosPares
            // 
            btnNumerosPares.Location = new Point(101, 271);
            btnNumerosPares.Name = "btnNumerosPares";
            btnNumerosPares.Size = new Size(75, 23);
            btnNumerosPares.TabIndex = 9;
            btnNumerosPares.Text = "Pares";
            btnNumerosPares.UseVisualStyleBackColor = true;
            btnNumerosPares.Click += btnNumerosPares_Click_1;
            // 
            // btnNumerosImpares
            // 
            btnNumerosImpares.Location = new Point(101, 300);
            btnNumerosImpares.Name = "btnNumerosImpares";
            btnNumerosImpares.Size = new Size(75, 23);
            btnNumerosImpares.TabIndex = 9;
            btnNumerosImpares.Text = "Impares";
            btnNumerosImpares.UseVisualStyleBackColor = true;
            btnNumerosImpares.Click += btnNumerosImpares_Click;
            // 
            // btnNumerosPrimos
            // 
            btnNumerosPrimos.Location = new Point(101, 242);
            btnNumerosPrimos.Name = "btnNumerosPrimos";
            btnNumerosPrimos.Size = new Size(75, 23);
            btnNumerosPrimos.TabIndex = 7;
            btnNumerosPrimos.Text = "Primos";
            btnNumerosPrimos.UseVisualStyleBackColor = true;
            btnNumerosPrimos.Click += btnNumerosPrimos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 152);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 6;
            label2.Text = "hasta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 102);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "desde";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(101, 213);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // listBoxNumeros
            // 
            listBoxNumeros.FormattingEnabled = true;
            listBoxNumeros.ItemHeight = 15;
            listBoxNumeros.Location = new Point(232, 94);
            listBoxNumeros.Name = "listBoxNumeros";
            listBoxNumeros.Size = new Size(120, 244);
            listBoxNumeros.TabIndex = 3;
            // 
            // txtHasta
            // 
            txtHasta.Location = new Point(86, 144);
            txtHasta.Name = "txtHasta";
            txtHasta.Size = new Size(100, 23);
            txtHasta.TabIndex = 1;
            // 
            // txtDesde
            // 
            txtDesde.Location = new Point(86, 94);
            txtDesde.Name = "txtDesde";
            txtDesde.Size = new Size(100, 23);
            txtDesde.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(451, 12);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(300, 300);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chart1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Graficador Numeros";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listBoxNumeros;
        private TextBox txtHasta;
        private TextBox txtDesde;
        private Label label2;
        private Label label1;
        private Button btnGenerar;
        private Button btnNumerosPares;
        private Button btnNumerosImpares;
        private Button btnNumerosPrimos;
        private Label labelTitulo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}