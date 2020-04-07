namespace Lab1
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.n_val = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lyambda_val = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyambda_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.Info;
            chartArea3.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisX.Title = "X";
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            chartArea3.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisY.Title = "Y";
            chartArea3.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            chartArea3.CursorX.Interval = 0.001D;
            chartArea3.CursorX.LineWidth = 2;
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            this.chart.Location = new System.Drawing.Point(12, 59);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(330, 345);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft NeoGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Новак Владислав ИТ-41БО\r\nВариант № 6";
            // 
            // n_val
            // 
            this.n_val.Location = new System.Drawing.Point(411, 352);
            this.n_val.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.n_val.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_val.Name = "n_val";
            this.n_val.Size = new System.Drawing.Size(120, 20);
            this.n_val.TabIndex = 23;
            this.n_val.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.n_val.ValueChanged += new System.EventHandler(this.paramsChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft NeoGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(389, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "n:";
            // 
            // lyambda_val
            // 
            this.lyambda_val.DecimalPlaces = 1;
            this.lyambda_val.Location = new System.Drawing.Point(410, 306);
            this.lyambda_val.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.lyambda_val.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lyambda_val.Name = "lyambda_val";
            this.lyambda_val.Size = new System.Drawing.Size(120, 20);
            this.lyambda_val.TabIndex = 30;
            this.lyambda_val.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.lyambda_val.ValueChanged += new System.EventHandler(this.paramsChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft NeoGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(388, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "p:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft NeoGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(410, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clickCalc);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGrid.Location = new System.Drawing.Point(348, 81);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(215, 207);
            this.dataGrid.TabIndex = 32;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "nM";
            this.Column1.HeaderText = "nm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "p";
            this.Column2.HeaderText = "p";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(572, 436);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lyambda_val);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n_val);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Лабораторная работа № 1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyambda_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown n_val;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown lyambda_val;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

