namespace MWODati
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 7D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtNomeRicerca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chbLight = new System.Windows.Forms.CheckBox();
            this.chbMedium = new System.Windows.Forms.CheckBox();
            this.chbAssault = new System.Windows.Forms.CheckBox();
            this.chbHeavy = new System.Windows.Forms.CheckBox();
            this.chbGeneral = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtRisultato = new System.Windows.Forms.RichTextBox();
            this.configBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeRicerca
            // 
            this.txtNomeRicerca.Location = new System.Drawing.Point(776, 22);
            this.txtNomeRicerca.Name = "txtNomeRicerca";
            this.txtNomeRicerca.Size = new System.Drawing.Size(209, 20);
            this.txtNomeRicerca.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(793, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chbLight
            // 
            this.chbLight.AutoSize = true;
            this.chbLight.ForeColor = System.Drawing.Color.White;
            this.chbLight.Location = new System.Drawing.Point(793, 73);
            this.chbLight.Name = "chbLight";
            this.chbLight.Size = new System.Drawing.Size(49, 17);
            this.chbLight.TabIndex = 3;
            this.chbLight.Text = "Light";
            this.chbLight.UseVisualStyleBackColor = true;
            this.chbLight.CheckedChanged += new System.EventHandler(this.chbLight_CheckedChanged);
            // 
            // chbMedium
            // 
            this.chbMedium.AutoSize = true;
            this.chbMedium.ForeColor = System.Drawing.Color.White;
            this.chbMedium.Location = new System.Drawing.Point(793, 96);
            this.chbMedium.Name = "chbMedium";
            this.chbMedium.Size = new System.Drawing.Size(63, 17);
            this.chbMedium.TabIndex = 4;
            this.chbMedium.Text = "Medium";
            this.chbMedium.UseVisualStyleBackColor = true;
            this.chbMedium.CheckedChanged += new System.EventHandler(this.chbMedium_CheckedChanged);
            // 
            // chbAssault
            // 
            this.chbAssault.AutoSize = true;
            this.chbAssault.ForeColor = System.Drawing.Color.White;
            this.chbAssault.Location = new System.Drawing.Point(793, 142);
            this.chbAssault.Name = "chbAssault";
            this.chbAssault.Size = new System.Drawing.Size(60, 17);
            this.chbAssault.TabIndex = 6;
            this.chbAssault.Text = "Assault";
            this.chbAssault.UseVisualStyleBackColor = true;
            // 
            // chbHeavy
            // 
            this.chbHeavy.AutoSize = true;
            this.chbHeavy.ForeColor = System.Drawing.Color.White;
            this.chbHeavy.Location = new System.Drawing.Point(793, 119);
            this.chbHeavy.Name = "chbHeavy";
            this.chbHeavy.Size = new System.Drawing.Size(57, 17);
            this.chbHeavy.TabIndex = 5;
            this.chbHeavy.Text = "Heavy";
            this.chbHeavy.UseVisualStyleBackColor = true;
            this.chbHeavy.CheckedChanged += new System.EventHandler(this.chbHeavy_CheckedChanged);
            // 
            // chbGeneral
            // 
            this.chbGeneral.AutoSize = true;
            this.chbGeneral.ForeColor = System.Drawing.Color.White;
            this.chbGeneral.Location = new System.Drawing.Point(793, 165);
            this.chbGeneral.Name = "chbGeneral";
            this.chbGeneral.Size = new System.Drawing.Size(63, 17);
            this.chbGeneral.TabIndex = 7;
            this.chbGeneral.Text = "General";
            this.chbGeneral.UseVisualStyleBackColor = true;
            this.chbGeneral.CheckedChanged += new System.EventHandler(this.chbGeneral_CheckedChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 390);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "BarChart";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(722, 157);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Gray;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Season 1",
            "Season 2",
            "Season 3"});
            this.listBox1.Location = new System.Drawing.Point(897, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(88, 104);
            this.listBox1.TabIndex = 9;
            // 
            // txtRisultato
            // 
            this.txtRisultato.BackColor = System.Drawing.Color.Black;
            this.txtRisultato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRisultato.ForeColor = System.Drawing.Color.White;
            this.txtRisultato.Location = new System.Drawing.Point(23, 22);
            this.txtRisultato.Name = "txtRisultato";
            this.txtRisultato.ReadOnly = true;
            this.txtRisultato.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtRisultato.Size = new System.Drawing.Size(722, 272);
            this.txtRisultato.TabIndex = 10;
            this.txtRisultato.Text = "";
            // 
            // configBindingSource
            // 
            this.configBindingSource.DataSource = typeof(MWODati.Config);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(997, 596);
            this.Controls.Add(this.txtRisultato);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chbGeneral);
            this.Controls.Add(this.chbAssault);
            this.Controls.Add(this.chbHeavy);
            this.Controls.Add(this.chbMedium);
            this.Controls.Add(this.chbLight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNomeRicerca);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeRicerca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chbLight;
        private System.Windows.Forms.CheckBox chbMedium;
        private System.Windows.Forms.CheckBox chbAssault;
        private System.Windows.Forms.CheckBox chbHeavy;
        private System.Windows.Forms.CheckBox chbGeneral;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource configBindingSource;
        public System.Windows.Forms.RichTextBox txtRisultato;
    }
}

