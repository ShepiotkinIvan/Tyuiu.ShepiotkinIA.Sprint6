
namespace Tyuiu.ShepiotkinIA.Sprint6.Task2.V3
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SIA = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_SIA = new System.Windows.Forms.GroupBox();
            this.groupBoxVar_SIA = new System.Windows.Forms.GroupBox();
            this.buttonInfo_SIA = new System.Windows.Forms.Button();
            this.buttonDone_SIA = new System.Windows.Forms.Button();
            this.textBoxTask_SIA = new System.Windows.Forms.TextBox();
            this.textBoxVarStart_SIA = new System.Windows.Forms.TextBox();
            this.textBoxVarStop_SIA = new System.Windows.Forms.TextBox();
            this.labelVarStart_SIA = new System.Windows.Forms.Label();
            this.labelVarStop_SIA = new System.Windows.Forms.Label();
            this.dataGridViewFunction_SIA = new System.Windows.Forms.DataGridView();
            this.labelFunction_SIA = new System.Windows.Forms.Label();
            this.chartFunction_SIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Column1_SIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_SIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_SIA.SuspendLayout();
            this.groupBoxResult_SIA.SuspendLayout();
            this.groupBoxVar_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SIA
            // 
            this.groupBoxTask_SIA.Controls.Add(this.textBoxTask_SIA);
            this.groupBoxTask_SIA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SIA.Name = "groupBoxTask_SIA";
            this.groupBoxTask_SIA.Size = new System.Drawing.Size(562, 326);
            this.groupBoxTask_SIA.TabIndex = 0;
            this.groupBoxTask_SIA.TabStop = false;
            this.groupBoxTask_SIA.Text = "Условие";
            // 
            // groupBoxResult_SIA
            // 
            this.groupBoxResult_SIA.Controls.Add(this.chartFunction_SIA);
            this.groupBoxResult_SIA.Controls.Add(this.labelFunction_SIA);
            this.groupBoxResult_SIA.Controls.Add(this.dataGridViewFunction_SIA);
            this.groupBoxResult_SIA.Location = new System.Drawing.Point(580, 12);
            this.groupBoxResult_SIA.Name = "groupBoxResult_SIA";
            this.groupBoxResult_SIA.Size = new System.Drawing.Size(684, 426);
            this.groupBoxResult_SIA.TabIndex = 1;
            this.groupBoxResult_SIA.TabStop = false;
            this.groupBoxResult_SIA.Text = "Вывод данных";
            // 
            // groupBoxVar_SIA
            // 
            this.groupBoxVar_SIA.Controls.Add(this.labelVarStop_SIA);
            this.groupBoxVar_SIA.Controls.Add(this.labelVarStart_SIA);
            this.groupBoxVar_SIA.Controls.Add(this.textBoxVarStop_SIA);
            this.groupBoxVar_SIA.Controls.Add(this.textBoxVarStart_SIA);
            this.groupBoxVar_SIA.Location = new System.Drawing.Point(12, 344);
            this.groupBoxVar_SIA.Name = "groupBoxVar_SIA";
            this.groupBoxVar_SIA.Size = new System.Drawing.Size(293, 94);
            this.groupBoxVar_SIA.TabIndex = 2;
            this.groupBoxVar_SIA.TabStop = false;
            this.groupBoxVar_SIA.Text = "Ввод данных";
            // 
            // buttonInfo_SIA
            // 
            this.buttonInfo_SIA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonInfo_SIA.Location = new System.Drawing.Point(311, 349);
            this.buttonInfo_SIA.Name = "buttonInfo_SIA";
            this.buttonInfo_SIA.Size = new System.Drawing.Size(97, 89);
            this.buttonInfo_SIA.TabIndex = 3;
            this.buttonInfo_SIA.Text = "Справка";
            this.buttonInfo_SIA.UseVisualStyleBackColor = false;
            this.buttonInfo_SIA.Click += new System.EventHandler(this.buttonInfo_SIA_Click);
            // 
            // buttonDone_SIA
            // 
            this.buttonDone_SIA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SIA.Location = new System.Drawing.Point(413, 349);
            this.buttonDone_SIA.Name = "buttonDone_SIA";
            this.buttonDone_SIA.Size = new System.Drawing.Size(160, 89);
            this.buttonDone_SIA.TabIndex = 4;
            this.buttonDone_SIA.Text = "Выполнить";
            this.buttonDone_SIA.UseVisualStyleBackColor = false;
            this.buttonDone_SIA.Click += new System.EventHandler(this.buttonDone_SIA_Click);
            this.buttonDone_SIA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SIA_MouseDown);
            this.buttonDone_SIA.MouseEnter += new System.EventHandler(this.buttonDone_SIA_MouseEnter);
            this.buttonDone_SIA.MouseLeave += new System.EventHandler(this.buttonDone_SIA_MouseLeave);
            // 
            // textBoxTask_SIA
            // 
            this.textBoxTask_SIA.Location = new System.Drawing.Point(6, 15);
            this.textBoxTask_SIA.Multiline = true;
            this.textBoxTask_SIA.Name = "textBoxTask_SIA";
            this.textBoxTask_SIA.ReadOnly = true;
            this.textBoxTask_SIA.Size = new System.Drawing.Size(550, 305);
            this.textBoxTask_SIA.TabIndex = 0;
            this.textBoxTask_SIA.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в DataGr" +
    "idView и построить график функции.";
            // 
            // textBoxVarStart_SIA
            // 
            this.textBoxVarStart_SIA.Location = new System.Drawing.Point(6, 40);
            this.textBoxVarStart_SIA.Name = "textBoxVarStart_SIA";
            this.textBoxVarStart_SIA.Size = new System.Drawing.Size(132, 20);
            this.textBoxVarStart_SIA.TabIndex = 0;
            this.textBoxVarStart_SIA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarStart_SIA_KeyPress);
            // 
            // textBoxVarStop_SIA
            // 
            this.textBoxVarStop_SIA.Location = new System.Drawing.Point(155, 40);
            this.textBoxVarStop_SIA.Name = "textBoxVarStop_SIA";
            this.textBoxVarStop_SIA.Size = new System.Drawing.Size(132, 20);
            this.textBoxVarStop_SIA.TabIndex = 1;
            this.textBoxVarStop_SIA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarStop_SIA_KeyPress);
            // 
            // labelVarStart_SIA
            // 
            this.labelVarStart_SIA.AutoSize = true;
            this.labelVarStart_SIA.Location = new System.Drawing.Point(7, 20);
            this.labelVarStart_SIA.Name = "labelVarStart_SIA";
            this.labelVarStart_SIA.Size = new System.Drawing.Size(67, 13);
            this.labelVarStart_SIA.TabIndex = 2;
            this.labelVarStart_SIA.Text = "Старт шага:";
            // 
            // labelVarStop_SIA
            // 
            this.labelVarStop_SIA.AutoSize = true;
            this.labelVarStop_SIA.Location = new System.Drawing.Point(155, 20);
            this.labelVarStop_SIA.Name = "labelVarStop_SIA";
            this.labelVarStop_SIA.Size = new System.Drawing.Size(69, 13);
            this.labelVarStop_SIA.TabIndex = 3;
            this.labelVarStop_SIA.Text = "Конец шага:";
            // 
            // dataGridViewFunction_SIA
            // 
            this.dataGridViewFunction_SIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_SIA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1_SIA,
            this.Column2_SIA});
            this.dataGridViewFunction_SIA.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewFunction_SIA.Name = "dataGridViewFunction_SIA";
            this.dataGridViewFunction_SIA.RowHeadersVisible = false;
            this.dataGridViewFunction_SIA.Size = new System.Drawing.Size(223, 384);
            this.dataGridViewFunction_SIA.TabIndex = 0;
            // 
            // labelFunction_SIA
            // 
            this.labelFunction_SIA.AutoSize = true;
            this.labelFunction_SIA.Location = new System.Drawing.Point(6, 20);
            this.labelFunction_SIA.Name = "labelFunction_SIA";
            this.labelFunction_SIA.Size = new System.Drawing.Size(62, 13);
            this.labelFunction_SIA.TabIndex = 1;
            this.labelFunction_SIA.Text = "Результат:";
            // 
            // chartFunction_SIA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SIA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_SIA.Legends.Add(legend1);
            this.chartFunction_SIA.Location = new System.Drawing.Point(235, 36);
            this.chartFunction_SIA.Name = "chartFunction_SIA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SIA.Series.Add(series1);
            this.chartFunction_SIA.Size = new System.Drawing.Size(443, 384);
            this.chartFunction_SIA.TabIndex = 2;
            this.chartFunction_SIA.Text = "chart1";
            // 
            // Column1_SIA
            // 
            this.Column1_SIA.HeaderText = "X";
            this.Column1_SIA.Name = "Column1_SIA";
            this.Column1_SIA.Width = 110;
            // 
            // Column2_SIA
            // 
            this.Column2_SIA.HeaderText = "F(X)";
            this.Column2_SIA.Name = "Column2_SIA";
            this.Column2_SIA.Width = 110;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 450);
            this.Controls.Add(this.buttonDone_SIA);
            this.Controls.Add(this.buttonInfo_SIA);
            this.Controls.Add(this.groupBoxVar_SIA);
            this.Controls.Add(this.groupBoxResult_SIA);
            this.Controls.Add(this.groupBoxTask_SIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 3 | Щепёткин И. А.";
            this.groupBoxTask_SIA.ResumeLayout(false);
            this.groupBoxTask_SIA.PerformLayout();
            this.groupBoxResult_SIA.ResumeLayout(false);
            this.groupBoxResult_SIA.PerformLayout();
            this.groupBoxVar_SIA.ResumeLayout(false);
            this.groupBoxVar_SIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SIA;
        private System.Windows.Forms.TextBox textBoxTask_SIA;
        private System.Windows.Forms.GroupBox groupBoxResult_SIA;
        private System.Windows.Forms.GroupBox groupBoxVar_SIA;
        private System.Windows.Forms.Button buttonInfo_SIA;
        private System.Windows.Forms.Button buttonDone_SIA;
        private System.Windows.Forms.TextBox textBoxVarStop_SIA;
        private System.Windows.Forms.TextBox textBoxVarStart_SIA;
        private System.Windows.Forms.Label labelVarStop_SIA;
        private System.Windows.Forms.Label labelVarStart_SIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SIA;
        private System.Windows.Forms.Label labelFunction_SIA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_SIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2_SIA;
    }
}

