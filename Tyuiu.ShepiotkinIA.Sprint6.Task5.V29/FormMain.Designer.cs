
namespace Tyuiu.ShepiotkinIA.Sprint6.Task5.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_SIA = new System.Windows.Forms.Panel();
            this.panelLeft_SIA = new System.Windows.Forms.Panel();
            this.panelFill_SIA = new System.Windows.Forms.Panel();
            this.buttonInfo_SIA = new System.Windows.Forms.Button();
            this.buttonOpen_SIA = new System.Windows.Forms.Button();
            this.buttonDone_SIA = new System.Windows.Forms.Button();
            this.groupBoxTask_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SIA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SIA = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_SIA = new System.Windows.Forms.DataGridView();
            this.chartDiag_SIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_SIA.SuspendLayout();
            this.panelLeft_SIA.SuspendLayout();
            this.panelFill_SIA.SuspendLayout();
            this.groupBoxTask_SIA.SuspendLayout();
            this.groupBoxResult_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_SIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_SIA
            // 
            this.panelTop_SIA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTop_SIA.Controls.Add(this.buttonOpen_SIA);
            this.panelTop_SIA.Controls.Add(this.groupBoxTask_SIA);
            this.panelTop_SIA.Controls.Add(this.buttonDone_SIA);
            this.panelTop_SIA.Controls.Add(this.buttonInfo_SIA);
            this.panelTop_SIA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_SIA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_SIA.Name = "panelTop_SIA";
            this.panelTop_SIA.Size = new System.Drawing.Size(842, 92);
            this.panelTop_SIA.TabIndex = 0;
            // 
            // panelLeft_SIA
            // 
            this.panelLeft_SIA.Controls.Add(this.groupBoxResult_SIA);
            this.panelLeft_SIA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_SIA.Location = new System.Drawing.Point(0, 92);
            this.panelLeft_SIA.Name = "panelLeft_SIA";
            this.panelLeft_SIA.Size = new System.Drawing.Size(163, 460);
            this.panelLeft_SIA.TabIndex = 0;
            // 
            // panelFill_SIA
            // 
            this.panelFill_SIA.Controls.Add(this.chartDiag_SIA);
            this.panelFill_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_SIA.Location = new System.Drawing.Point(163, 92);
            this.panelFill_SIA.Name = "panelFill_SIA";
            this.panelFill_SIA.Size = new System.Drawing.Size(679, 460);
            this.panelFill_SIA.TabIndex = 0;
            // 
            // buttonInfo_SIA
            // 
            this.buttonInfo_SIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_SIA.BackColor = System.Drawing.Color.LightBlue;
            this.buttonInfo_SIA.Location = new System.Drawing.Point(718, 9);
            this.buttonInfo_SIA.Name = "buttonInfo_SIA";
            this.buttonInfo_SIA.Size = new System.Drawing.Size(109, 73);
            this.buttonInfo_SIA.TabIndex = 0;
            this.buttonInfo_SIA.Text = "Справка";
            this.buttonInfo_SIA.UseVisualStyleBackColor = false;
            this.buttonInfo_SIA.Click += new System.EventHandler(this.buttonInfo_SIA_Click);
            // 
            // buttonOpen_SIA
            // 
            this.buttonOpen_SIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen_SIA.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOpen_SIA.Location = new System.Drawing.Point(562, 9);
            this.buttonOpen_SIA.Name = "buttonOpen_SIA";
            this.buttonOpen_SIA.Size = new System.Drawing.Size(123, 73);
            this.buttonOpen_SIA.TabIndex = 0;
            this.buttonOpen_SIA.Text = "Открыть файл";
            this.buttonOpen_SIA.UseVisualStyleBackColor = false;
            this.buttonOpen_SIA.Click += new System.EventHandler(this.buttonOpen_SIA_Click);
            // 
            // buttonDone_SIA
            // 
            this.buttonDone_SIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_SIA.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDone_SIA.Location = new System.Drawing.Point(427, 9);
            this.buttonDone_SIA.Name = "buttonDone_SIA";
            this.buttonDone_SIA.Size = new System.Drawing.Size(123, 73);
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
            this.groupBoxTask_SIA.Size = new System.Drawing.Size(404, 82);
            this.groupBoxTask_SIA.TabIndex = 1;
            this.groupBoxTask_SIA.TabStop = false;
            this.groupBoxTask_SIA.Text = "Условие";
            // 
            // textBoxTask_SIA
            // 
            this.textBoxTask_SIA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxTask_SIA.Location = new System.Drawing.Point(7, 16);
            this.textBoxTask_SIA.Multiline = true;
            this.textBoxTask_SIA.Name = "textBoxTask_SIA";
            this.textBoxTask_SIA.ReadOnly = true;
            this.textBoxTask_SIA.Size = new System.Drawing.Size(389, 56);
            this.textBoxTask_SIA.TabIndex = 0;
            this.textBoxTask_SIA.Text = "Прочитать данные из файла InPutFileTask5V29.txt. Вывести в dataGridView. Вывести " +
    "все числа, больше или равные 10.";
            // 
            // groupBoxResult_SIA
            // 
            this.groupBoxResult_SIA.Controls.Add(this.dataGridViewNums_SIA);
            this.groupBoxResult_SIA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxResult_SIA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_SIA.Name = "groupBoxResult_SIA";
            this.groupBoxResult_SIA.Size = new System.Drawing.Size(163, 460);
            this.groupBoxResult_SIA.TabIndex = 0;
            this.groupBoxResult_SIA.TabStop = false;
            this.groupBoxResult_SIA.Text = "Вывод данных:";
            // 
            // dataGridViewNums_SIA
            // 
            this.dataGridViewNums_SIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_SIA.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewNums_SIA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNums_SIA.Name = "dataGridViewNums_SIA";
            this.dataGridViewNums_SIA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewNums_SIA.Size = new System.Drawing.Size(160, 441);
            this.dataGridViewNums_SIA.TabIndex = 0;
            // 
            // chartDiag_SIA
            // 
            chartArea4.Name = "ChartArea1";
            this.chartDiag_SIA.ChartAreas.Add(chartArea4);
            this.chartDiag_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartDiag_SIA.Legends.Add(legend4);
            this.chartDiag_SIA.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_SIA.Name = "chartDiag_SIA";
            series4.ChartArea = "ChartArea1";
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDiag_SIA.Series.Add(series4);
            this.chartDiag_SIA.Size = new System.Drawing.Size(679, 460);
            this.chartDiag_SIA.TabIndex = 0;
            this.chartDiag_SIA.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 552);
            this.Controls.Add(this.panelFill_SIA);
            this.Controls.Add(this.panelLeft_SIA);
            this.Controls.Add(this.panelTop_SIA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 29 | Щепёткин И. А.";
            this.panelTop_SIA.ResumeLayout(false);
            this.panelLeft_SIA.ResumeLayout(false);
            this.panelFill_SIA.ResumeLayout(false);
            this.groupBoxTask_SIA.ResumeLayout(false);
            this.groupBoxTask_SIA.PerformLayout();
            this.groupBoxResult_SIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_SIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_SIA;
        private System.Windows.Forms.GroupBox groupBoxTask_SIA;
        private System.Windows.Forms.Button buttonDone_SIA;
        private System.Windows.Forms.Button buttonOpen_SIA;
        private System.Windows.Forms.Button buttonInfo_SIA;
        private System.Windows.Forms.Panel panelLeft_SIA;
        private System.Windows.Forms.Panel panelFill_SIA;
        private System.Windows.Forms.TextBox textBoxTask_SIA;
        private System.Windows.Forms.GroupBox groupBoxResult_SIA;
        private System.Windows.Forms.DataGridView dataGridViewNums_SIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SIA;
    }
}

