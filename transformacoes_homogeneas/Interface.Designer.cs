/*

Robótica - Transformações Homogêneas (Interface Gráfica)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace TransformacoesHomogeneas{

    partial class Interface{

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }

        private void InitializeComponent(){
        
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_xy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tb_angulo = new System.Windows.Forms.TextBox();
            this.tb_trans_x = new System.Windows.Forms.TextBox();
            this.tb_trans_y = new System.Windows.Forms.TextBox();
            this.tb_trans_z = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rd_rot_x = new System.Windows.Forms.RadioButton();
            this.rd_rot_y = new System.Windows.Forms.RadioButton();
            this.rd_rot_z = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t42 = new System.Windows.Forms.Label();
            this.t43 = new System.Windows.Forms.Label();
            this.t12 = new System.Windows.Forms.Label();
            this.t14 = new System.Windows.Forms.Label();
            this.t13 = new System.Windows.Forms.Label();
            this.t44 = new System.Windows.Forms.Label();
            this.t24 = new System.Windows.Forms.Label();
            this.t32 = new System.Windows.Forms.Label();
            this.t41 = new System.Windows.Forms.Label();
            this.t11 = new System.Windows.Forms.Label();
            this.t22 = new System.Windows.Forms.Label();
            this.t33 = new System.Windows.Forms.Label();
            this.t21 = new System.Windows.Forms.Label();
            this.t23 = new System.Windows.Forms.Label();
            this.t31 = new System.Windows.Forms.Label();
            this.t34 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tb_pinicial_z = new System.Windows.Forms.TextBox();
            this.tb_pinicial_y = new System.Windows.Forms.TextBox();
            this.tb_pinicial_x = new System.Windows.Forms.TextBox();
            this.lb_pfinal = new System.Windows.Forms.Label();
            this.bt_transformar = new System.Windows.Forms.Button();
            this.bt_reiniciar = new System.Windows.Forms.Button();
            this.chart_xz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_xy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_xz)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_xy
            // 
            chartArea1.Area3DStyle.Inclination = 60;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 300;
            chartArea1.Area3DStyle.Rotation = 45;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Black;
            this.chart_xy.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_xy.Legends.Add(legend1);
            this.chart_xy.Location = new System.Drawing.Point(129, 25);
            this.chart_xy.Name = "chart_xy";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.CustomProperties = "IsXAxisQuantitative=True";
            series1.Legend = "Legend1";
            series1.Name = "Gráfico XY";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chart_xy.Series.Add(series1);
            this.chart_xy.Size = new System.Drawing.Size(418, 188);
            this.chart_xy.TabIndex = 0;
            this.chart_xy.Text = "chart1";
            // 
            // tb_angulo
            // 
            this.tb_angulo.Location = new System.Drawing.Point(757, 69);
            this.tb_angulo.Name = "tb_angulo";
            this.tb_angulo.Size = new System.Drawing.Size(37, 20);
            this.tb_angulo.TabIndex = 1;
            // 
            // tb_trans_x
            // 
            this.tb_trans_x.Location = new System.Drawing.Point(609, 70);
            this.tb_trans_x.Name = "tb_trans_x";
            this.tb_trans_x.Size = new System.Drawing.Size(37, 20);
            this.tb_trans_x.TabIndex = 2;
            // 
            // tb_trans_y
            // 
            this.tb_trans_y.Location = new System.Drawing.Point(609, 96);
            this.tb_trans_y.Name = "tb_trans_y";
            this.tb_trans_y.Size = new System.Drawing.Size(37, 20);
            this.tb_trans_y.TabIndex = 3;
            // 
            // tb_trans_z
            // 
            this.tb_trans_z.Location = new System.Drawing.Point(609, 122);
            this.tb_trans_z.Name = "tb_trans_z";
            this.tb_trans_z.Size = new System.Drawing.Size(37, 20);
            this.tb_trans_z.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(696, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rotação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Translação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Eixo X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(555, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eixo Y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(556, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Eixo Z:";
            // 
            // rd_rot_x
            // 
            this.rd_rot_x.AutoSize = true;
            this.rd_rot_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_rot_x.Location = new System.Drawing.Point(741, 100);
            this.rd_rot_x.Name = "rd_rot_x";
            this.rd_rot_x.Size = new System.Drawing.Size(34, 20);
            this.rd_rot_x.TabIndex = 10;
            this.rd_rot_x.TabStop = true;
            this.rd_rot_x.Text = "X";
            this.rd_rot_x.UseVisualStyleBackColor = true;
            // 
            // rd_rot_y
            // 
            this.rd_rot_y.AutoSize = true;
            this.rd_rot_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_rot_y.Location = new System.Drawing.Point(741, 126);
            this.rd_rot_y.Name = "rd_rot_y";
            this.rd_rot_y.Size = new System.Drawing.Size(35, 20);
            this.rd_rot_y.TabIndex = 11;
            this.rd_rot_y.TabStop = true;
            this.rd_rot_y.Text = "Y";
            this.rd_rot_y.UseVisualStyleBackColor = true;
            // 
            // rd_rot_z
            // 
            this.rd_rot_z.AutoSize = true;
            this.rd_rot_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_rot_z.Location = new System.Drawing.Point(741, 152);
            this.rd_rot_z.Name = "rd_rot_z";
            this.rd_rot_z.Size = new System.Drawing.Size(34, 20);
            this.rd_rot_z.TabIndex = 12;
            this.rd_rot_z.TabStop = true;
            this.rd_rot_z.Text = "Z";
            this.rd_rot_z.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(698, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ângulo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(698, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Eixo:";
            // 
            // t42
            // 
            this.t42.AutoSize = true;
            this.t42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t42.Location = new System.Drawing.Point(632, 285);
            this.t42.Name = "t42";
            this.t42.Size = new System.Drawing.Size(18, 20);
            this.t42.TabIndex = 15;
            this.t42.Text = "0";
            // 
            // t43
            // 
            this.t43.AutoSize = true;
            this.t43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t43.Location = new System.Drawing.Point(678, 286);
            this.t43.Name = "t43";
            this.t43.Size = new System.Drawing.Size(18, 20);
            this.t43.TabIndex = 16;
            this.t43.Text = "0";
            // 
            // t12
            // 
            this.t12.AutoSize = true;
            this.t12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t12.Location = new System.Drawing.Point(632, 225);
            this.t12.Name = "t12";
            this.t12.Size = new System.Drawing.Size(18, 20);
            this.t12.TabIndex = 17;
            this.t12.Text = "0";
            // 
            // t14
            // 
            this.t14.AutoSize = true;
            this.t14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t14.Location = new System.Drawing.Point(724, 226);
            this.t14.Name = "t14";
            this.t14.Size = new System.Drawing.Size(18, 20);
            this.t14.TabIndex = 18;
            this.t14.Text = "0";
            // 
            // t13
            // 
            this.t13.AutoSize = true;
            this.t13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t13.Location = new System.Drawing.Point(678, 225);
            this.t13.Name = "t13";
            this.t13.Size = new System.Drawing.Size(18, 20);
            this.t13.TabIndex = 19;
            this.t13.Text = "0";
            // 
            // t44
            // 
            this.t44.AutoSize = true;
            this.t44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t44.Location = new System.Drawing.Point(724, 286);
            this.t44.Name = "t44";
            this.t44.Size = new System.Drawing.Size(18, 20);
            this.t44.TabIndex = 20;
            this.t44.Text = "0";
            // 
            // t24
            // 
            this.t24.AutoSize = true;
            this.t24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t24.Location = new System.Drawing.Point(724, 246);
            this.t24.Name = "t24";
            this.t24.Size = new System.Drawing.Size(18, 20);
            this.t24.TabIndex = 21;
            this.t24.Text = "0";
            // 
            // t32
            // 
            this.t32.AutoSize = true;
            this.t32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t32.Location = new System.Drawing.Point(632, 265);
            this.t32.Name = "t32";
            this.t32.Size = new System.Drawing.Size(18, 20);
            this.t32.TabIndex = 22;
            this.t32.Text = "0";
            // 
            // t41
            // 
            this.t41.AutoSize = true;
            this.t41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t41.Location = new System.Drawing.Point(586, 285);
            this.t41.Name = "t41";
            this.t41.Size = new System.Drawing.Size(18, 20);
            this.t41.TabIndex = 23;
            this.t41.Text = "0";
            // 
            // t11
            // 
            this.t11.AutoSize = true;
            this.t11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t11.Location = new System.Drawing.Point(586, 225);
            this.t11.Name = "t11";
            this.t11.Size = new System.Drawing.Size(18, 20);
            this.t11.TabIndex = 24;
            this.t11.Text = "0";
            // 
            // t22
            // 
            this.t22.AutoSize = true;
            this.t22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t22.Location = new System.Drawing.Point(632, 245);
            this.t22.Name = "t22";
            this.t22.Size = new System.Drawing.Size(18, 20);
            this.t22.TabIndex = 25;
            this.t22.Text = "0";
            // 
            // t33
            // 
            this.t33.AutoSize = true;
            this.t33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t33.Location = new System.Drawing.Point(678, 266);
            this.t33.Name = "t33";
            this.t33.Size = new System.Drawing.Size(18, 20);
            this.t33.TabIndex = 26;
            this.t33.Text = "0";
            // 
            // t21
            // 
            this.t21.AutoSize = true;
            this.t21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t21.Location = new System.Drawing.Point(586, 245);
            this.t21.Name = "t21";
            this.t21.Size = new System.Drawing.Size(18, 20);
            this.t21.TabIndex = 27;
            this.t21.Text = "0";
            // 
            // t23
            // 
            this.t23.AutoSize = true;
            this.t23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t23.Location = new System.Drawing.Point(678, 246);
            this.t23.Name = "t23";
            this.t23.Size = new System.Drawing.Size(18, 20);
            this.t23.TabIndex = 28;
            this.t23.Text = "0";
            // 
            // t31
            // 
            this.t31.AutoSize = true;
            this.t31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t31.Location = new System.Drawing.Point(586, 265);
            this.t31.Name = "t31";
            this.t31.Size = new System.Drawing.Size(18, 20);
            this.t31.TabIndex = 29;
            this.t31.Text = "0";
            // 
            // t34
            // 
            this.t34.AutoSize = true;
            this.t34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t34.Location = new System.Drawing.Point(724, 266);
            this.t34.Name = "t34";
            this.t34.Size = new System.Drawing.Size(18, 20);
            this.t34.TabIndex = 30;
            this.t34.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(553, 188);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(251, 25);
            this.label24.TabIndex = 31;
            this.label24.Text = "Matriz de transformação";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(551, 248);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 20);
            this.label25.TabIndex = 32;
            this.label25.Text = "T = ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(12, 26);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(111, 24);
            this.label26.TabIndex = 33;
            this.label26.Text = "Ponto inicial";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(578, 333);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(105, 20);
            this.label27.TabIndex = 34;
            this.label27.Text = "Ponto final:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(17, 121);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 16);
            this.label28.TabIndex = 40;
            this.label28.Text = "Eixo Z:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(17, 95);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(49, 16);
            this.label29.TabIndex = 39;
            this.label29.Text = "Eixo Y:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(17, 69);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(48, 16);
            this.label30.TabIndex = 38;
            this.label30.Text = "Eixo X:";
            // 
            // tb_pinicial_z
            // 
            this.tb_pinicial_z.Location = new System.Drawing.Point(71, 121);
            this.tb_pinicial_z.Name = "tb_pinicial_z";
            this.tb_pinicial_z.Size = new System.Drawing.Size(37, 20);
            this.tb_pinicial_z.TabIndex = 37;
            // 
            // tb_pinicial_y
            // 
            this.tb_pinicial_y.Location = new System.Drawing.Point(71, 95);
            this.tb_pinicial_y.Name = "tb_pinicial_y";
            this.tb_pinicial_y.Size = new System.Drawing.Size(37, 20);
            this.tb_pinicial_y.TabIndex = 36;
            // 
            // tb_pinicial_x
            // 
            this.tb_pinicial_x.Location = new System.Drawing.Point(71, 69);
            this.tb_pinicial_x.Name = "tb_pinicial_x";
            this.tb_pinicial_x.Size = new System.Drawing.Size(37, 20);
            this.tb_pinicial_x.TabIndex = 35;
            // 
            // lb_pfinal
            // 
            this.lb_pfinal.AutoSize = true;
            this.lb_pfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pfinal.Location = new System.Drawing.Point(689, 333);
            this.lb_pfinal.Name = "lb_pfinal";
            this.lb_pfinal.Size = new System.Drawing.Size(62, 20);
            this.lb_pfinal.TabIndex = 41;
            this.lb_pfinal.Text = "(0, 0, 0)";
            // 
            // bt_transformar
            // 
            this.bt_transformar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_transformar.Location = new System.Drawing.Point(12, 162);
            this.bt_transformar.Name = "bt_transformar";
            this.bt_transformar.Size = new System.Drawing.Size(111, 51);
            this.bt_transformar.TabIndex = 42;
            this.bt_transformar.Text = "Aplicar transformação";
            this.bt_transformar.UseVisualStyleBackColor = true;
            this.bt_transformar.Click += new System.EventHandler(this.Bt_transformar_Click);
            // 
            // bt_reiniciar
            // 
            this.bt_reiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reiniciar.Location = new System.Drawing.Point(12, 225);
            this.bt_reiniciar.Name = "bt_reiniciar";
            this.bt_reiniciar.Size = new System.Drawing.Size(107, 43);
            this.bt_reiniciar.TabIndex = 43;
            this.bt_reiniciar.Text = "Reiniciar";
            this.bt_reiniciar.UseVisualStyleBackColor = true;
            this.bt_reiniciar.Click += new System.EventHandler(this.Bt_reiniciar_Click);
            // 
            // chart_xz
            // 
            chartArea2.Area3DStyle.Inclination = 60;
            chartArea2.Area3DStyle.IsRightAngleAxes = false;
            chartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea2.Area3DStyle.PointDepth = 300;
            chartArea2.Area3DStyle.Rotation = 45;
            chartArea2.Area3DStyle.WallWidth = 0;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Black;
            this.chart_xz.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_xz.Legends.Add(legend2);
            this.chart_xz.Location = new System.Drawing.Point(129, 225);
            this.chart_xz.Name = "chart_xz";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Gráfico XZ";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chart_xz.Series.Add(series2);
            this.chart_xz.Size = new System.Drawing.Size(418, 192);
            this.chart_xz.TabIndex = 44;
            this.chart_xz.Text = "chart1";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart_xz);
            this.Controls.Add(this.bt_reiniciar);
            this.Controls.Add(this.bt_transformar);
            this.Controls.Add(this.lb_pfinal);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.tb_pinicial_z);
            this.Controls.Add(this.tb_pinicial_y);
            this.Controls.Add(this.tb_pinicial_x);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.t34);
            this.Controls.Add(this.t31);
            this.Controls.Add(this.t23);
            this.Controls.Add(this.t21);
            this.Controls.Add(this.t33);
            this.Controls.Add(this.t22);
            this.Controls.Add(this.t11);
            this.Controls.Add(this.t41);
            this.Controls.Add(this.t32);
            this.Controls.Add(this.t24);
            this.Controls.Add(this.t44);
            this.Controls.Add(this.t13);
            this.Controls.Add(this.t14);
            this.Controls.Add(this.t12);
            this.Controls.Add(this.t43);
            this.Controls.Add(this.t42);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rd_rot_z);
            this.Controls.Add(this.rd_rot_y);
            this.Controls.Add(this.rd_rot_x);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_trans_z);
            this.Controls.Add(this.tb_trans_y);
            this.Controls.Add(this.tb_trans_x);
            this.Controls.Add(this.tb_angulo);
            this.Controls.Add(this.chart_xy);
            this.Name = "Interface";
            this.Text = "Transformações homogêneas";
            ((System.ComponentModel.ISupportInitialize)(this.chart_xy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_xz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_xy;
        private System.Windows.Forms.TextBox tb_angulo;
        private System.Windows.Forms.TextBox tb_trans_x;
        private System.Windows.Forms.TextBox tb_trans_y;
        private System.Windows.Forms.TextBox tb_trans_z;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rd_rot_x;
        private System.Windows.Forms.RadioButton rd_rot_y;
        private System.Windows.Forms.RadioButton rd_rot_z;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label t42;
        private System.Windows.Forms.Label t43;
        private System.Windows.Forms.Label t12;
        private System.Windows.Forms.Label t14;
        private System.Windows.Forms.Label t13;
        private System.Windows.Forms.Label t44;
        private System.Windows.Forms.Label t24;
        private System.Windows.Forms.Label t32;
        private System.Windows.Forms.Label t41;
        private System.Windows.Forms.Label t11;
        private System.Windows.Forms.Label t22;
        private System.Windows.Forms.Label t33;
        private System.Windows.Forms.Label t21;
        private System.Windows.Forms.Label t23;
        private System.Windows.Forms.Label t31;
        private System.Windows.Forms.Label t34;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tb_pinicial_z;
        private System.Windows.Forms.TextBox tb_pinicial_y;
        private System.Windows.Forms.TextBox tb_pinicial_x;
        private System.Windows.Forms.Label lb_pfinal;
        private System.Windows.Forms.Button bt_transformar;
        private System.Windows.Forms.Button bt_reiniciar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_xz;
    }
}
