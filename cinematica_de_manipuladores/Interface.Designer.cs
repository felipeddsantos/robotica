/*

Robótica - Cinemática de Manipuladores (Interface Gráfica)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace CinematicaDeManipuladores{

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
            this.chart_xy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.tb_teta2 = new System.Windows.Forms.TextBox();
            this.tb_teta1 = new System.Windows.Forms.TextBox();
            this.bt_transformar = new System.Windows.Forms.Button();
            this.tb_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_direct = new System.Windows.Forms.RadioButton();
            this.rb_inverse = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_r2 = new System.Windows.Forms.TextBox();
            this.tb_r1 = new System.Windows.Forms.TextBox();
            this.b_Elos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_xy)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_xy
            // 
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.None;
            chartArea1.Area3DStyle.Inclination = 60;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 300;
            chartArea1.Area3DStyle.Rotation = 45;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            chartArea1.BorderWidth = 6;
            chartArea1.CursorX.AutoScroll = false;
            chartArea1.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.Transparent;
            chartArea1.CursorY.AutoScroll = false;
            chartArea1.CursorY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.CursorY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Black;
            this.chart_xy.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_xy.Legends.Add(legend1);
            this.chart_xy.Location = new System.Drawing.Point(215, 26);
            this.chart_xy.Name = "chart_xy";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.CustomProperties = "IsXAxisQuantitative=True";
            series1.Legend = "Legend1";
            series1.MarkerSize = 50;
            series1.Name = "Plano XY";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart_xy.Series.Add(series1);
            this.chart_xy.Size = new System.Drawing.Size(573, 397);
            this.chart_xy.TabIndex = 0;
            this.chart_xy.Text = "chart1";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(64, 26);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(105, 24);
            this.label26.TabIndex = 33;
            this.label26.Text = "Parâmetros";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(12, 173);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(19, 16);
            this.label28.TabIndex = 40;
            this.label28.Text = "X:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(56, 120);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(70, 16);
            this.label29.TabIndex = 39;
            this.label29.Text = "Ângulo θ2:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(56, 86);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 16);
            this.label.TabIndex = 38;
            this.label.Text = "Ângulo θ1:";
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(37, 173);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(58, 20);
            this.tb_x.TabIndex = 37;
            // 
            // tb_teta2
            // 
            this.tb_teta2.Location = new System.Drawing.Point(132, 120);
            this.tb_teta2.Name = "tb_teta2";
            this.tb_teta2.Size = new System.Drawing.Size(58, 20);
            this.tb_teta2.TabIndex = 36;
            // 
            // tb_teta1
            // 
            this.tb_teta1.Location = new System.Drawing.Point(132, 86);
            this.tb_teta1.Name = "tb_teta1";
            this.tb_teta1.Size = new System.Drawing.Size(58, 20);
            this.tb_teta1.TabIndex = 35;
            // 
            // bt_transformar
            // 
            this.bt_transformar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_transformar.Location = new System.Drawing.Point(58, 387);
            this.bt_transformar.Name = "bt_transformar";
            this.bt_transformar.Size = new System.Drawing.Size(111, 51);
            this.bt_transformar.TabIndex = 42;
            this.bt_transformar.Text = "Aplicar rotação";
            this.bt_transformar.UseVisualStyleBackColor = true;
            this.bt_transformar.Click += new System.EventHandler(this.Bt_transformar_Click);
            // 
            // tb_y
            // 
            this.tb_y.Location = new System.Drawing.Point(38, 205);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(57, 20);
            this.tb_y.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Y:";
            // 
            // rb_direct
            // 
            this.rb_direct.AutoSize = true;
            this.rb_direct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_direct.Location = new System.Drawing.Point(59, 263);
            this.rb_direct.Name = "rb_direct";
            this.rb_direct.Size = new System.Drawing.Size(132, 20);
            this.rb_direct.TabIndex = 46;
            this.rb_direct.TabStop = true;
            this.rb_direct.Text = "Cinemática direta";
            this.rb_direct.UseVisualStyleBackColor = true;
            // 
            // rb_inverse
            // 
            this.rb_inverse.AutoSize = true;
            this.rb_inverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inverse.Location = new System.Drawing.Point(59, 289);
            this.rb_inverse.Name = "rb_inverse";
            this.rb_inverse.Size = new System.Drawing.Size(140, 20);
            this.rb_inverse.TabIndex = 47;
            this.rb_inverse.TabStop = true;
            this.rb_inverse.Text = "Cinemática inversa";
            this.rb_inverse.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "r2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "r1:";
            // 
            // tb_r2
            // 
            this.tb_r2.Location = new System.Drawing.Point(153, 207);
            this.tb_r2.Name = "tb_r2";
            this.tb_r2.Size = new System.Drawing.Size(58, 20);
            this.tb_r2.TabIndex = 49;
            // 
            // tb_r1
            // 
            this.tb_r1.Location = new System.Drawing.Point(153, 173);
            this.tb_r1.Name = "tb_r1";
            this.tb_r1.Size = new System.Drawing.Size(58, 20);
            this.tb_r1.TabIndex = 48;
            // 
            // b_Elos
            // 
            this.b_Elos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Elos.Location = new System.Drawing.Point(58, 330);
            this.b_Elos.Name = "b_Elos";
            this.b_Elos.Size = new System.Drawing.Size(111, 51);
            this.b_Elos.TabIndex = 52;
            this.b_Elos.Text = "Formar Elos";
            this.b_Elos.UseVisualStyleBackColor = true;
            this.b_Elos.Click += new System.EventHandler(this.B_Elos_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_Elos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_r2);
            this.Controls.Add(this.tb_r1);
            this.Controls.Add(this.rb_inverse);
            this.Controls.Add(this.rb_direct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_y);
            this.Controls.Add(this.bt_transformar);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tb_x);
            this.Controls.Add(this.tb_teta2);
            this.Controls.Add(this.tb_teta1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.chart_xy);
            this.Name = "Interface";
            this.Text = "Simulador de sistema robótico";
            ((System.ComponentModel.ISupportInitialize)(this.chart_xy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_xy;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.TextBox tb_teta2;
        private System.Windows.Forms.TextBox tb_teta1;
        private System.Windows.Forms.Button bt_transformar;
        private System.Windows.Forms.TextBox tb_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_direct;
        private System.Windows.Forms.RadioButton rb_inverse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_r2;
        private System.Windows.Forms.TextBox tb_r1;
        private System.Windows.Forms.Button b_Elos;
    }
}
