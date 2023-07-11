using System.Windows.Forms.DataVisualization.Charting;

namespace RBS
{
    partial class graph
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            ChartArea chartArea2 = new ChartArea();
            Legend legend2 = new Legend();
            Series series2 = new Series();
            ChartArea chartArea3 = new ChartArea();
            Legend legend3 = new Legend();
            Series series3 = new Series();
            ChartArea chartArea4 = new ChartArea();
            Legend legend4 = new Legend();
            Series series4 = new Series();
            ChartArea chartArea5 = new ChartArea();
            Legend legend5 = new Legend();
            Series series5 = new Series();
            chart1 = new Chart();
            chart2 = new Chart();
            chart3 = new Chart();
            chart4 = new Chart();
            chart5 = new Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart5).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "suuri";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 3);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "取得単位数";
            chart1.Series.Add(series1);
            chart1.Size = new Size(336, 340);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "genngo";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend2";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(404, 3);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea2";
            series2.Legend = "Legend2";
            series2.Name = "取得単位数";
            chart2.Series.Add(series2);
            chart2.Size = new Size(336, 340);
            chart2.TabIndex = 3;
            // 
            // chart3
            // 
            chartArea3.Name = "zinnbunn";
            chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend3";
            chart3.Legends.Add(legend3);
            chart3.Location = new Point(810, 3);
            chart3.Name = "chart3";
            series3.ChartArea = "ChartArea3";
            series3.Legend = "Legend3";
            series3.Name = "取得単位数";
            chart3.Series.Add(series3);
            chart3.Size = new Size(336, 340);
            chart3.TabIndex = 1;
            // 
            // chart4
            // 
            chartArea4.Name = "taiiku";
            chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend4";
            chart4.Legends.Add(legend4);
            chart4.Location = new Point(0, 378);
            chart4.Name = "chart4";
            series4.ChartArea = "ChartArea4";
            series4.Legend = "Legend4";
            series4.Name = "取得単位数";
            chart4.Series.Add(series4);
            chart4.Size = new Size(336, 340);
            chart4.TabIndex = 1;
            // 
            // chart5
            // 
            chartArea5.Name = "sennmonn";
            chart5.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend5";
            chart5.Legends.Add(legend5);
            chart5.Location = new Point(404, 378);
            chart5.Name = "chart5";
            series5.ChartArea = "ChartArea5";
            series5.Legend = "Legend5";
            series5.Name = "取得単位数";
            chart5.Series.Add(series5);
            chart5.Size = new Size(336, 340);
            chart5.TabIndex = 0;
            // 
            // graph
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 714);
            Controls.Add(chart5);
            Controls.Add(chart4);
            Controls.Add(chart3);
            Controls.Add(chart2);
            Controls.Add(chart1);
            Name = "graph";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart4).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Chart chart1;
        private Chart chart2;
        private Chart chart3;
        private Chart chart4;
        private Chart chart5;
    }
}