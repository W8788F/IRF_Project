namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea29 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend29 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title29 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea30 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend30 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title30 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea31 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend31 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title31 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea32 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend32 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title32 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ismerv = new System.Windows.Forms.ComboBox();
            this.ismervijellemzo = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // ismerv
            // 
            this.ismerv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ismerv.ForeColor = System.Drawing.Color.Red;
            this.ismerv.FormattingEnabled = true;
            this.ismerv.Items.AddRange(new object[] {
            "Megye",
            "Iskola típus",
            "Nem",
            "Képzés típusa"});
            this.ismerv.Location = new System.Drawing.Point(62, 80);
            this.ismerv.Name = "ismerv";
            this.ismerv.Size = new System.Drawing.Size(200, 28);
            this.ismerv.TabIndex = 0;
            this.ismerv.SelectedIndexChanged += new System.EventHandler(this.ismerv_SelectedIndexChanged);
            // 
            // ismervijellemzo
            // 
            this.ismervijellemzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ismervijellemzo.ForeColor = System.Drawing.Color.Red;
            this.ismervijellemzo.FormattingEnabled = true;
            this.ismervijellemzo.Location = new System.Drawing.Point(62, 163);
            this.ismervijellemzo.Name = "ismervijellemzo";
            this.ismervijellemzo.Size = new System.Drawing.Size(197, 28);
            this.ismervijellemzo.TabIndex = 1;
            this.ismervijellemzo.SelectedIndexChanged += new System.EventHandler(this.ismervijellemzo_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea29.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea29.AxisX2.LogarithmBase = 5D;
            chartArea29.AxisX2.Maximum = 5D;
            chartArea29.AxisX2.Minimum = 0D;
            chartArea29.AxisY.Interval = 0.5D;
            chartArea29.AxisY.Maximum = 4D;
            chartArea29.AxisY.Minimum = 0D;
            chartArea29.AxisY.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea29.AxisY2.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea29.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea29.CursorY.Interval = 0.5D;
            chartArea29.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea29);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Cross;
            legend29.Enabled = false;
            legend29.Name = "Legend1";
            this.chart1.Legends.Add(legend29);
            this.chart1.Location = new System.Drawing.Point(62, 237);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series29.ChartArea = "ChartArea1";
            series29.Legend = "Legend1";
            series29.LegendText = "Jegy átlag";
            series29.Name = "Series1";
            this.chart1.Series.Add(series29);
            this.chart1.Size = new System.Drawing.Size(291, 343);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            title29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title29.Name = "Jegyek átlaga";
            title29.Text = "Jegyek átlaga";
            this.chart1.Titles.Add(title29);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kérem válassza ki mi alapján szeretne szűrni!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(58, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kérem válassza ki mit szeretne a többi adattal összehasonlítani!";
            // 
            // chart2
            // 
            chartArea30.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea30.AxisX.IsReversed = true;
            chartArea30.AxisY.Interval = 0.5D;
            chartArea30.AxisY.Maximum = 4D;
            chartArea30.AxisY.Minimum = 0D;
            chartArea30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea30.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea30);
            legend30.Enabled = false;
            legend30.Name = "Legend1";
            this.chart2.Legends.Add(legend30);
            this.chart2.Location = new System.Drawing.Point(410, 237);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series30.ChartArea = "ChartArea1";
            series30.Legend = "Legend1";
            series30.Name = "Series1";
            this.chart2.Series.Add(series30);
            this.chart2.Size = new System.Drawing.Size(292, 343);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            title30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title30.Name = "Title1";
            title30.Text = "Jegyek átlaga";
            this.chart2.Titles.Add(title30);
            // 
            // chart3
            // 
            chartArea31.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea31.AxisY.Interval = 20D;
            chartArea31.AxisY.Maximum = 100D;
            chartArea31.AxisY.Minimum = 0D;
            chartArea31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea31.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea31);
            legend31.Enabled = false;
            legend31.Name = "Legend1";
            this.chart3.Legends.Add(legend31);
            this.chart3.Location = new System.Drawing.Point(62, 595);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series31.ChartArea = "ChartArea1";
            series31.Legend = "Legend1";
            series31.LegendText = "Átlag százalék";
            series31.Name = "Series1";
            this.chart3.Series.Add(series31);
            this.chart3.Size = new System.Drawing.Size(291, 342);
            this.chart3.TabIndex = 7;
            this.chart3.Text = "chart3";
            title31.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title31.Name = "Title1";
            title31.Text = "Átlag százalék";
            this.chart3.Titles.Add(title31);
            // 
            // chart4
            // 
            chartArea32.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea32.AxisX.IsReversed = true;
            chartArea32.AxisY.Interval = 20D;
            chartArea32.AxisY.Maximum = 100D;
            chartArea32.AxisY.Minimum = 0D;
            chartArea32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea32.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea32);
            legend32.Enabled = false;
            legend32.Name = "Legend1";
            this.chart4.Legends.Add(legend32);
            this.chart4.Location = new System.Drawing.Point(410, 595);
            this.chart4.Name = "chart4";
            this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series32.ChartArea = "ChartArea1";
            series32.Legend = "Legend1";
            series32.Name = "Series1";
            this.chart4.Series.Add(series32);
            this.chart4.Size = new System.Drawing.Size(292, 342);
            this.chart4.TabIndex = 8;
            this.chart4.Text = "chart4";
            title32.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title32.Name = "Title1";
            title32.Text = "Átlag százalék";
            this.chart4.Titles.Add(title32);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(741, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(277, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(277, 606);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(626, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(626, 606);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1025, 961);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ismervijellemzo);
            this.Controls.Add(this.ismerv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ismerv;
        private System.Windows.Forms.ComboBox ismervijellemzo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
    }
}

