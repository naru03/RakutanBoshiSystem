/*******************************************************************
*** File Name : graph.cs
*** Version : V1.0
*** Designer : 篠塚 勇希
*** Date : 2023.07.11
*** Purpose : 現在の各系統の取得単位に応じて各学年で取得した単位数をグラフ化する。
***
*******************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RBS
{
    public partial class graph : Form
    {
        public graph()
        {
            InitializeComponent();
            string[] labels = new string[] { "１年", "２年", "３年", "４年" };
            int[] values_suuri = new int[] { Score_Manage.graph_suuri1sum, Score_Manage.graph_suuri2sum, Score_Manage.graph_suuri3sum, Score_Manage.graph_suuri4sum };
            double[] values_genngo = new double[] { Score_Manage.graph_genngo1sum, Score_Manage.graph_genngo2sum, Score_Manage.graph_genngo3sum, Score_Manage.graph_genngo4sum };
            double[] values_zinnbunn = new double[] { Score_Manage.graph_zinnbunn1sum, Score_Manage.graph_zinnbunn2sum, Score_Manage.graph_zinnbunn3sum, Score_Manage.graph_zinnbunn4sum };
            double[] values_taiiku = new double[] { Score_Manage.graph_taiiku1sum, Score_Manage.graph_taiiku2sum, Score_Manage.graph_taiiku3sum, Score_Manage.graph_taiiku4sum };
            double[] values_sennmonn = new double[] { Score_Manage.graph_sennmonn1sum, Score_Manage.graph_sennmonn2sum, Score_Manage.graph_sennmonn3sum, Score_Manage.graph_sennmonn4sum };
            // 数理基礎科目のグラフの種類を指定
            chart1.Series.Clear();
            chart1.Series.Add("取得単位数");
            chart1.Series["取得単位数"].ChartType = SeriesChartType.Column;
            chart1.Series["取得単位数"]["PointWidth"] = "0.5"; // 0.8は間隔の比率を表す（0.8 * バーの幅）
            chart1.Titles.Add("数理基礎科目");
            // データを追加
            for (int i = 0; i < labels.Length; i++)
            {
                DataPoint dataPoint = chart1.Series["取得単位数"].Points.Add(values_suuri[i]);
                dataPoint.AxisLabel = labels[i];
                dataPoint.Label = values_suuri[i].ToString();
                dataPoint.LabelForeColor = System.Drawing.Color.Black;
            }
            // グラフに軸ラベルを表示する設定
            chart1.ChartAreas[0].AxisX.Interval = 1;
            // グラフの詳細値表示位置を設定
            chart1.Series["取得単位数"]["LabelStyle"] = "Right";


            // 言語科目のグラフの種類を指定
            chart2.Series.Clear();
            chart2.Series.Add("取得単位数");
            chart2.Series["取得単位数"].ChartType = SeriesChartType.Column;
            chart2.Series["取得単位数"]["PointWidth"] = "0.5"; // 0.8は間隔の比率を表す（0.8 * バーの幅）
            chart2.Titles.Add("言語");
            // データを追加
            for (int i = 0; i < labels.Length; i++)
            {
                DataPoint dataPoint = chart2.Series["取得単位数"].Points.Add(values_genngo[i]);
                dataPoint.AxisLabel = labels[i];
                dataPoint.Label = values_genngo[i].ToString();
                dataPoint.LabelForeColor = System.Drawing.Color.Black;
            }
            // グラフに軸ラベルを表示する設定
            chart2.ChartAreas[0].AxisX.Interval = 1;
            // グラフの詳細値表示位置を設定
            chart2.Series["取得単位数"]["LabelStyle"] = "Right";


            // 人文社会系教養科目のグラフの種類を指定
            chart3.Series.Clear();
            chart3.Series.Add("取得単位数");
            chart3.Series["取得単位数"].ChartType = SeriesChartType.Column;
            chart3.Series["取得単位数"]["PointWidth"] = "0.5"; // 0.8は間隔の比率を表す（0.8 * バーの幅）
            chart3.Titles.Add("人文社会系教養");
            // データを追加
            for (int i = 0; i < labels.Length; i++)
            {
                DataPoint dataPoint = chart3.Series["取得単位数"].Points.Add(values_zinnbunn[i]);
                dataPoint.AxisLabel = labels[i];
                dataPoint.Label = values_zinnbunn[i].ToString();
                dataPoint.LabelForeColor = System.Drawing.Color.Black;
            }
            // グラフに軸ラベルを表示する設定
            chart3.ChartAreas[0].AxisX.Interval = 1;
            // グラフの詳細値表示位置を設定
            chart3.Series["取得単位数"]["LabelStyle"] = "Right";


            // 体育科目のグラフの種類を指定
            chart4.Series.Clear();
            chart4.Series.Add("取得単位数");
            chart4.Series["取得単位数"].ChartType = SeriesChartType.Column;
            chart4.Series["取得単位数"]["PointWidth"] = "0.5"; // 0.8は間隔の比率を表す（0.8 * バーの幅）
            chart4.Titles.Add("体育");
            // データを追加
            for (int i = 0; i < labels.Length; i++)
            {
                DataPoint dataPoint = chart4.Series["取得単位数"].Points.Add(values_taiiku[i]);
                dataPoint.AxisLabel = labels[i];
                dataPoint.Label = values_taiiku[i].ToString();
                dataPoint.LabelForeColor = System.Drawing.Color.Black;
            }
            // グラフに軸ラベルを表示する設定
            chart4.ChartAreas[0].AxisX.Interval = 1;
            // グラフの詳細値表示位置を設定
            chart4.Series["取得単位数"]["LabelStyle"] = "Right";

            // 専門科目のグラフの種類を指定
            chart5.Series.Clear();
            chart5.Series.Add("取得単位数");
            chart5.Series["取得単位数"].ChartType = SeriesChartType.Column;
            chart5.Series["取得単位数"]["PointWidth"] = "0.5"; // 0.8は間隔の比率を表す（0.8 * バーの幅）
            chart5.Titles.Add("専門");
            // データを追加
            for (int i = 0; i < labels.Length; i++)
            {
                DataPoint dataPoint = chart5.Series["取得単位数"].Points.Add(values_sennmonn[i]);
                dataPoint.AxisLabel = labels[i];
                dataPoint.Label = values_sennmonn[i].ToString();
                dataPoint.LabelForeColor = System.Drawing.Color.Black;
            }
            // グラフに軸ラベルを表示する設定
            chart5.ChartAreas[0].AxisX.Interval = 1;
            // グラフの詳細値表示位置を設定
            chart5.Series["取得単位数"]["LabelStyle"] = "Right";
        }


    }
}
