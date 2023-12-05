
namespace Tyuiu.ShepiotkinIA.Sprint6.Task4.V14
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_SIA = new System.Windows.Forms.Panel();
            this.panelLeft_SIA = new System.Windows.Forms.Panel();
            this.panelFill_SIA = new System.Windows.Forms.Panel();
            this.buttonInfo_SIA = new System.Windows.Forms.Button();
            this.buttonSave_SIA = new System.Windows.Forms.Button();
            this.buttonDone_SIA = new System.Windows.Forms.Button();
            this.groupBoxTask_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SIA = new System.Windows.Forms.TextBox();
            this.groupBoxVar_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxVarStart_SIA = new System.Windows.Forms.TextBox();
            this.textBoxVarStop_SIA = new System.Windows.Forms.TextBox();
            this.labelVarStart_SIA = new System.Windows.Forms.Label();
            this.labelVarStop_SIA = new System.Windows.Forms.Label();
            this.groupBoxResult_SIA = new System.Windows.Forms.GroupBox();
            this.TextBoxResult_SIA = new System.Windows.Forms.TextBox();
            this.chartFunction_SIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_SIA.SuspendLayout();
            this.panelLeft_SIA.SuspendLayout();
            this.panelFill_SIA.SuspendLayout();
            this.groupBoxTask_SIA.SuspendLayout();
            this.groupBoxVar_SIA.SuspendLayout();
            this.groupBoxResult_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_SIA
            // 
            this.panelTop_SIA.BackColor = System.Drawing.Color.Silver;
            this.panelTop_SIA.Controls.Add(this.groupBoxVar_SIA);
            this.panelTop_SIA.Controls.Add(this.groupBoxTask_SIA);
            this.panelTop_SIA.Controls.Add(this.buttonSave_SIA);
            this.panelTop_SIA.Controls.Add(this.buttonDone_SIA);
            this.panelTop_SIA.Controls.Add(this.buttonInfo_SIA);
            this.panelTop_SIA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SIA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SIA.Name = "panelTop_SIA";
            this.panelTop_SIA.Size = new System.Drawing.Size(1183, 85);
            this.panelTop_SIA.TabIndex = 0;
            // 
            // panelLeft_SIA
            // 
            this.panelLeft_SIA.Controls.Add(this.groupBoxResult_SIA);
            this.panelLeft_SIA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SIA.Location = new System.Drawing.Point(0, 85);
            this.panelLeft_SIA.Name = "panelLeft_SIA";
            this.panelLeft_SIA.Size = new System.Drawing.Size(265, 465);
            this.panelLeft_SIA.TabIndex = 0;
            // 
            // panelFill_SIA
            // 
            this.panelFill_SIA.Controls.Add(this.chartFunction_SIA);
            this.panelFill_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_SIA.Location = new System.Drawing.Point(265, 85);
            this.panelFill_SIA.Name = "panelFill_SIA";
            this.panelFill_SIA.Size = new System.Drawing.Size(918, 465);
            this.panelFill_SIA.TabIndex = 0;
            // 
            // buttonInfo_SIA
            // 
            this.buttonInfo_SIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_SIA.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonInfo_SIA.Location = new System.Drawing.Point(1087, 8);
            this.buttonInfo_SIA.Name = "buttonInfo_SIA";
            this.buttonInfo_SIA.Size = new System.Drawing.Size(84, 74);
            this.buttonInfo_SIA.TabIndex = 0;
            this.buttonInfo_SIA.Text = "Справка";
            this.buttonInfo_SIA.UseVisualStyleBackColor = false;
            this.buttonInfo_SIA.Click += new System.EventHandler(this.buttonInfo_SIA_Click);
            // 
            // buttonSave_SIA
            // 
            this.buttonSave_SIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_SIA.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonSave_SIA.Location = new System.Drawing.Point(930, 8);
            this.buttonSave_SIA.Name = "buttonSave_SIA";
            this.buttonSave_SIA.Size = new System.Drawing.Size(107, 74);
            this.buttonSave_SIA.TabIndex = 0;
            this.buttonSave_SIA.Text = "Сохранить";
            this.buttonSave_SIA.UseVisualStyleBackColor = false;
            this.buttonSave_SIA.Click += new System.EventHandler(this.buttonSave_SIA_Click);
            // 
            // buttonDone_SIA
            // 
            this.buttonDone_SIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_SIA.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDone_SIA.Location = new System.Drawing.Point(817, 8);
            this.buttonDone_SIA.Name = "buttonDone_SIA";
            this.buttonDone_SIA.Size = new System.Drawing.Size(107, 74);
            this.buttonDone_SIA.TabIndex = 0;
            this.buttonDone_SIA.Text = "Выполнить";
            this.buttonDone_SIA.UseVisualStyleBackColor = false;
            this.buttonDone_SIA.Click += new System.EventHandler(this.buttonDone_SIA_Click);
            // 
            // groupBoxTask_SIA
            // 
            this.groupBoxTask_SIA.Controls.Add(this.textBoxTask_SIA);
            this.groupBoxTask_SIA.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_SIA.Name = "groupBoxTask_SIA";
            this.groupBoxTask_SIA.Size = new System.Drawing.Size(468, 78);
            this.groupBoxTask_SIA.TabIndex = 1;
            this.groupBoxTask_SIA.TabStop = false;
            this.groupBoxTask_SIA.Text = "Условие";
            // 
            // textBoxTask_SIA
            // 
            this.textBoxTask_SIA.BackColor = System.Drawing.Color.Silver;
            this.textBoxTask_SIA.Location = new System.Drawing.Point(5, 14);
            this.textBoxTask_SIA.Multiline = true;
            this.textBoxTask_SIA.Name = "textBoxTask_SIA";
            this.textBoxTask_SIA.ReadOnly = true;
            this.textBoxTask_SIA.Size = new System.Drawing.Size(458, 57);
            this.textBoxTask_SIA.TabIndex = 0;
            this.textBoxTask_SIA.Text = "Протабулировать функцию sin(x) на заданном диапазоне от -5 до 5.\r\nРезультат вывес" +
    "ти в TextBox, построить график функции и сохранить в файл\r\nOutPutFileTask4V14.tx" +
    "t по нажатию кнопки";
            // 
            // groupBoxVar_SIA
            // 
            this.groupBoxVar_SIA.Controls.Add(this.labelVarStop_SIA);
            this.groupBoxVar_SIA.Controls.Add(this.labelVarStart_SIA);
            this.groupBoxVar_SIA.Controls.Add(this.textBoxVarStart_SIA);
            this.groupBoxVar_SIA.Controls.Add(this.textBoxVarStop_SIA);
            this.groupBoxVar_SIA.Location = new System.Drawing.Point(474, 4);
            this.groupBoxVar_SIA.Name = "groupBoxVar_SIA";
            this.groupBoxVar_SIA.Size = new System.Drawing.Size(337, 78);
            this.groupBoxVar_SIA.TabIndex = 2;
            this.groupBoxVar_SIA.TabStop = false;
            this.groupBoxVar_SIA.Text = "Ввод данных";
            // 
            // textBoxVarStart_SIA
            // 
            this.textBoxVarStart_SIA.Location = new System.Drawing.Point(9, 41);
            this.textBoxVarStart_SIA.Name = "textBoxVarStart_SIA";
            this.textBoxVarStart_SIA.Size = new System.Drawing.Size(152, 20);
            this.textBoxVarStart_SIA.TabIndex = 0;
            // 
            // textBoxVarStop_SIA
            // 
            this.textBoxVarStop_SIA.Location = new System.Drawing.Point(176, 41);
            this.textBoxVarStop_SIA.Name = "textBoxVarStop_SIA";
            this.textBoxVarStop_SIA.Size = new System.Drawing.Size(152, 20);
            this.textBoxVarStop_SIA.TabIndex = 0;
            // 
            // labelVarStart_SIA
            // 
            this.labelVarStart_SIA.AutoSize = true;
            this.labelVarStart_SIA.Location = new System.Drawing.Point(9, 22);
            this.labelVarStart_SIA.Name = "labelVarStart_SIA";
            this.labelVarStart_SIA.Size = new System.Drawing.Size(67, 13);
            this.labelVarStart_SIA.TabIndex = 1;
            this.labelVarStart_SIA.Text = "Старт шага:";
            // 
            // labelVarStop_SIA
            // 
            this.labelVarStop_SIA.AutoSize = true;
            this.labelVarStop_SIA.Location = new System.Drawing.Point(173, 22);
            this.labelVarStop_SIA.Name = "labelVarStop_SIA";
            this.labelVarStop_SIA.Size = new System.Drawing.Size(69, 13);
            this.labelVarStop_SIA.TabIndex = 1;
            this.labelVarStop_SIA.Text = "Конец шага:";
            // 
            // groupBoxResult_SIA
            // 
            this.groupBoxResult_SIA.Controls.Add(this.TextBoxResult_SIA);
            this.groupBoxResult_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_SIA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_SIA.Name = "groupBoxResult_SIA";
            this.groupBoxResult_SIA.Size = new System.Drawing.Size(265, 465);
            this.groupBoxResult_SIA.TabIndex = 0;
            this.groupBoxResult_SIA.TabStop = false;
            this.groupBoxResult_SIA.Text = "Вывод";
            // 
            // TextBoxResult_SIA
            // 
            this.TextBoxResult_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxResult_SIA.Location = new System.Drawing.Point(3, 16);
            this.TextBoxResult_SIA.Multiline = true;
            this.TextBoxResult_SIA.Name = "TextBoxResult_SIA";
            this.TextBoxResult_SIA.ReadOnly = true;
            this.TextBoxResult_SIA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxResult_SIA.Size = new System.Drawing.Size(259, 446);
            this.TextBoxResult_SIA.TabIndex = 0;
            // 
            // chartFunction_SIA
            // 
            chartArea6.Name = "ChartArea1";
            this.chartFunction_SIA.ChartAreas.Add(chartArea6);
            this.chartFunction_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chartFunction_SIA.Legends.Add(legend6);
            this.chartFunction_SIA.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_SIA.Name = "chartFunction_SIA";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            series6.YValuesPerPoint = 6;
            this.chartFunction_SIA.Series.Add(series6);
            this.chartFunction_SIA.Size = new System.Drawing.Size(918, 465);
            this.chartFunction_SIA.TabIndex = 0;
            this.chartFunction_SIA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 550);
            this.Controls.Add(this.panelFill_SIA);
            this.Controls.Add(this.panelLeft_SIA);
            this.Controls.Add(this.panelTop_SIA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 14 | Щепёткин И. А.";
            this.panelTop_SIA.ResumeLayout(false);
            this.panelLeft_SIA.ResumeLayout(false);
            this.panelFill_SIA.ResumeLayout(false);
            this.groupBoxTask_SIA.ResumeLayout(false);
            this.groupBoxTask_SIA.PerformLayout();
            this.groupBoxVar_SIA.ResumeLayout(false);
            this.groupBoxVar_SIA.PerformLayout();
            this.groupBoxResult_SIA.ResumeLayout(false);
            this.groupBoxResult_SIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SIA;
        private System.Windows.Forms.Panel panelLeft_SIA;
        private System.Windows.Forms.Panel panelFill_SIA;
        private System.Windows.Forms.Button buttonSave_SIA;
        private System.Windows.Forms.Button buttonDone_SIA;
        private System.Windows.Forms.Button buttonInfo_SIA;
        private System.Windows.Forms.GroupBox groupBoxTask_SIA;
        private System.Windows.Forms.GroupBox groupBoxVar_SIA;
        private System.Windows.Forms.Label labelVarStop_SIA;
        private System.Windows.Forms.Label labelVarStart_SIA;
        private System.Windows.Forms.TextBox textBoxVarStart_SIA;
        private System.Windows.Forms.TextBox textBoxVarStop_SIA;
        private System.Windows.Forms.TextBox textBoxTask_SIA;
        private System.Windows.Forms.GroupBox groupBoxResult_SIA;
        private System.Windows.Forms.TextBox TextBoxResult_SIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SIA;
    }
}

