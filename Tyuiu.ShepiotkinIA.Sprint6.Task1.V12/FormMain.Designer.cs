
namespace Tyuiu.ShepiotkinIA.Sprint6.Task1.V12
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
            this.groupBoxResult_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxResult_SIA = new System.Windows.Forms.TextBox();
            this.labelResult_SIA = new System.Windows.Forms.Label();
            this.groupBoxTask_SIA = new System.Windows.Forms.GroupBox();
            this.groupBoxVar_SIA = new System.Windows.Forms.GroupBox();
            this.buttonDone_SIA = new System.Windows.Forms.Button();
            this.buttonInfo_SIA = new System.Windows.Forms.Button();
            this.textBoxTask_SIA = new System.Windows.Forms.TextBox();
            this.textBoxVarStop_SIA = new System.Windows.Forms.TextBox();
            this.textBoxVarStart_SIA = new System.Windows.Forms.TextBox();
            this.labelStart_SIA = new System.Windows.Forms.Label();
            this.labelStop_SIA = new System.Windows.Forms.Label();
            this.groupBoxResult_SIA.SuspendLayout();
            this.groupBoxTask_SIA.SuspendLayout();
            this.groupBoxVar_SIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxResult_SIA
            // 
            this.groupBoxResult_SIA.Controls.Add(this.labelResult_SIA);
            this.groupBoxResult_SIA.Controls.Add(this.textBoxResult_SIA);
            this.groupBoxResult_SIA.Location = new System.Drawing.Point(498, 12);
            this.groupBoxResult_SIA.Name = "groupBoxResult_SIA";
            this.groupBoxResult_SIA.Size = new System.Drawing.Size(290, 426);
            this.groupBoxResult_SIA.TabIndex = 0;
            this.groupBoxResult_SIA.TabStop = false;
            this.groupBoxResult_SIA.Text = "Вывод данных";
            // 
            // textBoxResult_SIA
            // 
            this.textBoxResult_SIA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SIA.Location = new System.Drawing.Point(6, 32);
            this.textBoxResult_SIA.Multiline = true;
            this.textBoxResult_SIA.Name = "textBoxResult_SIA";
            this.textBoxResult_SIA.ReadOnly = true;
            this.textBoxResult_SIA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SIA.Size = new System.Drawing.Size(278, 388);
            this.textBoxResult_SIA.TabIndex = 0;
            // 
            // labelResult_SIA
            // 
            this.labelResult_SIA.AutoSize = true;
            this.labelResult_SIA.Location = new System.Drawing.Point(6, 16);
            this.labelResult_SIA.Name = "labelResult_SIA";
            this.labelResult_SIA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_SIA.TabIndex = 1;
            this.labelResult_SIA.Text = "Результат:";
            // 
            // groupBoxTask_SIA
            // 
            this.groupBoxTask_SIA.Controls.Add(this.textBoxTask_SIA);
            this.groupBoxTask_SIA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SIA.Name = "groupBoxTask_SIA";
            this.groupBoxTask_SIA.Size = new System.Drawing.Size(480, 336);
            this.groupBoxTask_SIA.TabIndex = 1;
            this.groupBoxTask_SIA.TabStop = false;
            this.groupBoxTask_SIA.Text = "Условие";
            // 
            // groupBoxVar_SIA
            // 
            this.groupBoxVar_SIA.Controls.Add(this.labelStop_SIA);
            this.groupBoxVar_SIA.Controls.Add(this.labelStart_SIA);
            this.groupBoxVar_SIA.Controls.Add(this.textBoxVarStart_SIA);
            this.groupBoxVar_SIA.Controls.Add(this.textBoxVarStop_SIA);
            this.groupBoxVar_SIA.Location = new System.Drawing.Point(12, 354);
            this.groupBoxVar_SIA.Name = "groupBoxVar_SIA";
            this.groupBoxVar_SIA.Size = new System.Drawing.Size(275, 84);
            this.groupBoxVar_SIA.TabIndex = 2;
            this.groupBoxVar_SIA.TabStop = false;
            this.groupBoxVar_SIA.Text = "Ввод данных";
            // 
            // buttonDone_SIA
            // 
            this.buttonDone_SIA.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDone_SIA.Location = new System.Drawing.Point(381, 362);
            this.buttonDone_SIA.Name = "buttonDone_SIA";
            this.buttonDone_SIA.Size = new System.Drawing.Size(111, 74);
            this.buttonDone_SIA.TabIndex = 3;
            this.buttonDone_SIA.Text = "Выполнить";
            this.buttonDone_SIA.UseVisualStyleBackColor = false;
            this.buttonDone_SIA.Click += new System.EventHandler(this.buttonDone_SIA_Click);
            // 
            // buttonInfo_SIA
            // 
            this.buttonInfo_SIA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonInfo_SIA.Location = new System.Drawing.Point(293, 362);
            this.buttonInfo_SIA.Name = "buttonInfo_SIA";
            this.buttonInfo_SIA.Size = new System.Drawing.Size(82, 74);
            this.buttonInfo_SIA.TabIndex = 4;
            this.buttonInfo_SIA.Text = "Справка";
            this.buttonInfo_SIA.UseVisualStyleBackColor = false;
            this.buttonInfo_SIA.Click += new System.EventHandler(this.buttonInfo_SIA_Click);
            // 
            // textBoxTask_SIA
            // 
            this.textBoxTask_SIA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SIA.Multiline = true;
            this.textBoxTask_SIA.Name = "textBoxTask_SIA";
            this.textBoxTask_SIA.ReadOnly = true;
            this.textBoxTask_SIA.Size = new System.Drawing.Size(468, 311);
            this.textBoxTask_SIA.TabIndex = 0;
            this.textBoxTask_SIA.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в виде т" +
    "аблицы.";
            // 
            // textBoxVarStop_SIA
            // 
            this.textBoxVarStop_SIA.Location = new System.Drawing.Point(143, 46);
            this.textBoxVarStop_SIA.Name = "textBoxVarStop_SIA";
            this.textBoxVarStop_SIA.Size = new System.Drawing.Size(126, 20);
            this.textBoxVarStop_SIA.TabIndex = 0;
            this.textBoxVarStop_SIA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarStop_SIA_KeyPress);
            // 
            // textBoxVarStart_SIA
            // 
            this.textBoxVarStart_SIA.Location = new System.Drawing.Point(6, 46);
            this.textBoxVarStart_SIA.Name = "textBoxVarStart_SIA";
            this.textBoxVarStart_SIA.Size = new System.Drawing.Size(126, 20);
            this.textBoxVarStart_SIA.TabIndex = 1;
            this.textBoxVarStart_SIA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarStart_SIA_KeyPress);
            // 
            // labelStart_SIA
            // 
            this.labelStart_SIA.AutoSize = true;
            this.labelStart_SIA.Location = new System.Drawing.Point(6, 30);
            this.labelStart_SIA.Name = "labelStart_SIA";
            this.labelStart_SIA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_SIA.TabIndex = 2;
            this.labelStart_SIA.Text = "Старт шага:";
            // 
            // labelStop_SIA
            // 
            this.labelStop_SIA.AutoSize = true;
            this.labelStop_SIA.Location = new System.Drawing.Point(140, 30);
            this.labelStop_SIA.Name = "labelStop_SIA";
            this.labelStop_SIA.Size = new System.Drawing.Size(69, 13);
            this.labelStop_SIA.TabIndex = 3;
            this.labelStop_SIA.Text = "Конец шага:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInfo_SIA);
            this.Controls.Add(this.buttonDone_SIA);
            this.Controls.Add(this.groupBoxVar_SIA);
            this.Controls.Add(this.groupBoxTask_SIA);
            this.Controls.Add(this.groupBoxResult_SIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxResult_SIA.ResumeLayout(false);
            this.groupBoxResult_SIA.PerformLayout();
            this.groupBoxTask_SIA.ResumeLayout(false);
            this.groupBoxTask_SIA.PerformLayout();
            this.groupBoxVar_SIA.ResumeLayout(false);
            this.groupBoxVar_SIA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxResult_SIA;
        private System.Windows.Forms.Label labelResult_SIA;
        private System.Windows.Forms.TextBox textBoxResult_SIA;
        private System.Windows.Forms.GroupBox groupBoxTask_SIA;
        private System.Windows.Forms.TextBox textBoxTask_SIA;
        private System.Windows.Forms.GroupBox groupBoxVar_SIA;
        private System.Windows.Forms.Label labelStop_SIA;
        private System.Windows.Forms.Label labelStart_SIA;
        private System.Windows.Forms.TextBox textBoxVarStart_SIA;
        private System.Windows.Forms.TextBox textBoxVarStop_SIA;
        private System.Windows.Forms.Button buttonDone_SIA;
        private System.Windows.Forms.Button buttonInfo_SIA;
    }
}

