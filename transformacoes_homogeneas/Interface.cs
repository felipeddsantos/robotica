/*

Robótica - Transformações Homogêneas (Programa Principal)
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

namespace TransformacoesHomogeneas{

    public partial class Interface : Form{
    
        public Interface(){

            InitializeComponent();
        }

        double[,] itransform = new double[4, 4];
        double[,] ftransform = new double[4, 4];
        double[] ipoint = new double[4];
        double[] fpoint = new double[4];
        double sum = 0;
        int flag = 0;
        
        private void Bt_transformar_Click(object sender, EventArgs e){

            chart_xy.Series["Gráfico XY"].Points.AddXY(0.1, 0.1);
            chart_xy.Series["Gráfico XY"].Points.AddXY(0.2, 0.1);
            chart_xy.Series["Gráfico XY"].Points.AddXY(0.3, 0.1);
            chart_xy.Series["Gráfico XY"].Points.AddXY(0.4, 0.1);
            chart_xy.Series["Gráfico XY"].Points.AddXY(0.5, 0.1);
            chart_xy.Series["Gráfico XY"].Points.AddXY(0.6, 0.1);
        }

        private void Bt_reiniciar_Click(object sender, EventArgs e){

            for(int i = 0; i <= 3; i++){

                for(int j = 0; j <= 3; j++){

                    if(i == j)

                        itransform[i, j] = 1;

                    else

                        itransform[i, j] = 0;
                }
            }

            ipoint[0] = ipoint[1] = ipoint[2] = flag = 0;
            ipoint[3] = 1;

            lb_pfinal.Text = "(0, 0, 0)";

            t11.Text = t12.Text = t13.Text = t14.Text = t21.Text = t22.Text = t23.Text = t24.Text = t31.Text = t32.Text =
            t33.Text = t34.Text = t41.Text = t42.Text = t43.Text = t44.Text = "0";
            
            tb_angulo.Text = tb_trans_x.Text = tb_trans_y.Text = tb_trans_z.Text = tb_pinicial_x.Text = tb_pinicial_y.Text = 
            tb_pinicial_z.Text = " ";

            rd_rot_x.Checked = rd_rot_y.Checked = rd_rot_z.Checked = false;

            chart_xy.Series["Gráfico XY"].Points.Clear();
            chart_xz.Series["Gráfico XZ"].Points.Clear();  
        }
    }
}
