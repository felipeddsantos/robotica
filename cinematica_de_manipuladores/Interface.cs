/*

Robótica - Cinemática de Manipuladores (Programa Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CinematicaDeManipuladores{

    public partial class Interface : Form{

        DataTable dt = new DataTable();

        double x1 = 0, y1 = 0, x2 = 0, y2 = 0, x = 0, y = 0, teta1 = 0, teta2 = 0;
        double r1 = 0, r2 = 0, rad = Math.PI / 180;

        public Interface(){

            InitializeComponent();

            dt.Columns.Add("X_Value", typeof(double));
            dt.Columns.Add("Y_Value", typeof(double));
        }

        private void B_Elos_Click(object sender, EventArgs e){

            try{

                r1 = Math.Sqrt(Math.Pow(double.Parse(tb_r1.Text), 2));
                r2 = Math.Sqrt(Math.Pow(double.Parse(tb_r2.Text), 2));

                dt.Rows.Clear();
                dt.Rows.Add(0, 0);
                dt.Rows.Add(r1 * Math.Cos(30 * Math.PI / 180), r1 * Math.Sin(30 * Math.PI / 180));
                dt.Rows.Add(r2 * Math.Cos(45 * Math.PI / 180) + r1 * Math.Cos(30 * Math.PI / 180), r2 * Math.Sin(45 * Math.PI / 180) + r1 * Math.Sin(30 * Math.PI / 180));

                chart_xy.DataSource = dt;
                chart_xy.Series["Plano XY"].XValueMember = "X_Value";
                chart_xy.Series["Plano XY"].YValueMembers = "Y_Value";
                chart_xy.Series["Plano XY"].ChartType = SeriesChartType.Line;
                chart_xy.Series["Plano XY"].BorderWidth = 5;
                chart_xy.ChartAreas[0].AxisX.Maximum = r2 * Math.Cos(45 * Math.PI / 180) + r1 * Math.Cos(30 * Math.PI / 180) + 2;
                chart_xy.ChartAreas[0].AxisX.Minimum = chart_xy.ChartAreas[0].AxisY.Minimum = -2;
                chart_xy.ChartAreas[0].AxisY.Maximum = r2 * Math.Sin(45 * Math.PI / 180) + r1 * Math.Sin(30 * Math.PI / 180) + 2;
                chart_xy.ChartAreas[0].AxisY.LabelStyle.Format = "";
            }

            catch(Exception){

                MessageBox.Show("Insira valores de r1 e r2 válidos");
            }
        }

        private void Bt_transformar_Click(object sender, EventArgs e){

            if(rb_direct.Checked){

                try{

                    teta1 = double.Parse(tb_teta1.Text);
                    teta2 = double.Parse(tb_teta2.Text);

                    x1 = r1 * Math.Cos(teta1 * rad);
                    y1 = r1 * Math.Sin(teta1 * rad);
                    x2 = x1 + r2 * Math.Cos((teta1 + teta2) * rad);
                    y2 = y1 + r2 * Math.Sin((teta1 + teta2) * rad);

                    dt.Clear();

                    dt.Rows.Add(0, 0);
                    dt.Rows.Add(x1, y1);
                    dt.Rows.Add(x2, y2);

                    chart_xy.DataSource = dt;
                    chart_xy.Series["Plano XY"].XValueMember = "X_Value";
                    chart_xy.Series["Plano XY"].YValueMembers = "Y_Value";
                    chart_xy.Series["Plano XY"].ChartType = SeriesChartType.Line;
                    chart_xy.Series["Plano XY"].BorderWidth = 5;
                    chart_xy.ChartAreas[0].AxisX.Maximum = r2 * Math.Cos(45 * Math.PI / 180) + r1 * Math.Cos(30 * Math.PI / 180) + 2;
                    chart_xy.ChartAreas[0].AxisX.Minimum = chart_xy.ChartAreas[0].AxisY.Minimum = -2;
                    chart_xy.ChartAreas[0].AxisY.Maximum = r2 * Math.Sin(45 * Math.PI / 180) + r1 * Math.Sin(30 * Math.PI / 180) + 2;
                    chart_xy.ChartAreas[0].AxisY.LabelStyle.Format = "";

                    tb_x.Text = Math.Round(x2, 3).ToString();
                    tb_y.Text = Math.Round(y2, 3).ToString();
                }

                catch(Exception){

                    MessageBox.Show("Insira valores de θ1 e θ2 válidos");
                }
            }

            else if(rb_inverse.Checked){

                try{

                    x = double.Parse(tb_x.Text);
                    y = double.Parse(tb_y.Text);

                    teta2 = Math.Acos((x * x + y * y - r1 * r1 - r2 * r2) / (2 * r1 * r2));
                    teta1 = Math.Atan((y * (r1 + r2 * Math.Cos(teta2)) - x * r2 * Math.Sin(teta2)) / (x * (r1 + r2 * Math.Cos(teta2)) + y * r2 * Math.Sin(teta2)));
                    x1 = r1 * Math.Cos(teta1);
                    y1 = r1 * Math.Sin(teta1);
                    x2 = x1 + r2 * Math.Cos((teta1 + teta2));
                    y2 = y1 + r2 * Math.Sin((teta1 + teta2));

                    dt.Clear();

                    dt.Rows.Add(0, 0);
                    dt.Rows.Add(x1, y1);
                    dt.Rows.Add(x2, y2);

                    chart_xy.DataSource = dt;
                    chart_xy.Series["Plano XY"].XValueMember = "X_Value";
                    chart_xy.Series["Plano XY"].YValueMembers = "Y_Value";
                    chart_xy.Series["Plano XY"].ChartType = SeriesChartType.Line;
                    chart_xy.Series["Plano XY"].BorderWidth = 5;
                    chart_xy.ChartAreas[0].AxisX.Maximum = r2 * Math.Cos(45 * Math.PI / 180) + r1 * Math.Cos(30 * Math.PI / 180) + 2;
                    chart_xy.ChartAreas[0].AxisX.Minimum = chart_xy.ChartAreas[0].AxisY.Minimum = -2;
                    chart_xy.ChartAreas[0].AxisY.Maximum = r2 * Math.Sin(45 * Math.PI / 180) + r1 * Math.Sin(30 * Math.PI / 180) + 2;
                    chart_xy.ChartAreas[0].AxisY.LabelStyle.Format = "";

                    tb_teta1.Text = Math.Round(teta1 / rad, 3).ToString();
                    tb_teta2.Text = Math.Round(teta2 / rad, 3).ToString();
                }

                catch (Exception){

                    MessageBox.Show("Insira valores de x e y válidos");
                }
            }

            else

                MessageBox.Show("Marque uma opção válida");
        }
    }
}
