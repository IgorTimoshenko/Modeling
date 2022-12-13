namespace Model
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KolvoIt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.simulate = new System.Windows.Forms.Button();
            this.stepModel = new System.Windows.Forms.TextBox();
            this.acceleration = new System.Windows.Forms.TextBox();
            this.way = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultTable = new System.Windows.Forms.DataGridView();
            this.accelerat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartRes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.KolvoIt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.simulate);
            this.panel1.Controls.Add(this.stepModel);
            this.panel1.Controls.Add(this.acceleration);
            this.panel1.Controls.Add(this.way);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 305);
            this.panel1.TabIndex = 0;
            // 
            // KolvoIt
            // 
            this.KolvoIt.Location = new System.Drawing.Point(163, 159);
            this.KolvoIt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KolvoIt.Name = "KolvoIt";
            this.KolvoIt.Size = new System.Drawing.Size(132, 22);
            this.KolvoIt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кол-во иттераций:";
            // 
            // simulate
            // 
            this.simulate.Location = new System.Drawing.Point(60, 224);
            this.simulate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simulate.Name = "simulate";
            this.simulate.Size = new System.Drawing.Size(172, 46);
            this.simulate.TabIndex = 7;
            this.simulate.Text = "Моделировать";
            this.simulate.UseVisualStyleBackColor = true;
            this.simulate.Click += new System.EventHandler(this.simulate_Click);
            // 
            // stepModel
            // 
            this.stepModel.Location = new System.Drawing.Point(163, 123);
            this.stepModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stepModel.Name = "stepModel";
            this.stepModel.Size = new System.Drawing.Size(132, 22);
            this.stepModel.TabIndex = 6;
            // 
            // acceleration
            // 
            this.acceleration.Location = new System.Drawing.Point(163, 85);
            this.acceleration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.acceleration.Name = "acceleration";
            this.acceleration.Size = new System.Drawing.Size(132, 22);
            this.acceleration.TabIndex = 5;
            // 
            // way
            // 
            this.way.Location = new System.Drawing.Point(163, 46);
            this.way.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.way.Name = "way";
            this.way.Size = new System.Drawing.Size(132, 22);
            this.way.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Шаг моделирования:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ускорение a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пройденный путь s:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Входные параметры:";
            // 
            // resultTable
            // 
            this.resultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accelerat,
            this.t});
            this.resultTable.Location = new System.Drawing.Point(372, 15);
            this.resultTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultTable.Name = "resultTable";
            this.resultTable.Size = new System.Drawing.Size(327, 363);
            this.resultTable.TabIndex = 2;
            // 
            // accelerat
            // 
            this.accelerat.HeaderText = "Ускорение";
            this.accelerat.Name = "accelerat";
            // 
            // t
            // 
            this.t.HeaderText = "Время";
            this.t.Name = "t";
            // 
            // chartRes
            // 
            chartArea1.AxisX.Title = "Время";
            chartArea1.AxisY.Title = "Ускорение";
            chartArea1.Name = "ChartArea1";
            this.chartRes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRes.Legends.Add(legend1);
            this.chartRes.Location = new System.Drawing.Point(728, 15);
            this.chartRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartRes.Name = "chartRes";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Время";
            this.chartRes.Series.Add(series1);
            this.chartRes.Size = new System.Drawing.Size(572, 363);
            this.chartRes.TabIndex = 4;
            this.chartRes.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "Title1";
            title1.Text = "Грифик зависимости времени от ускорения";
            this.chartRes.Titles.Add(title1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 405);
            this.Controls.Add(this.chartRes);
            this.Controls.Add(this.resultTable);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button simulate;
        private System.Windows.Forms.TextBox stepModel;
        private System.Windows.Forms.TextBox acceleration;
        private System.Windows.Forms.TextBox way;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox KolvoIt;
        private System.Windows.Forms.DataGridView resultTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn accelerat;
        private System.Windows.Forms.DataGridViewTextBoxColumn t;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

