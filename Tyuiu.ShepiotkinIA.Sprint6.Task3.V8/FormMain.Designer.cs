
namespace Tyuiu.ShepiotkinIA.Sprint6.Task3.V8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_SIA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SIA = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_SIA = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_SIA = new System.Windows.Forms.GroupBox();
            this.labelResult_SIA = new System.Windows.Forms.Label();
            this.textBoxResult_SIA = new System.Windows.Forms.TextBox();
            this.buttonInfo_SIA = new System.Windows.Forms.Button();
            this.buttonDone_SIA = new System.Windows.Forms.Button();
            this.groupBoxTask_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SIA)).BeginInit();
            this.groupBoxResult_SIA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SIA
            // 
            this.groupBoxTask_SIA.Controls.Add(this.textBoxTask_SIA);
            this.groupBoxTask_SIA.Controls.Add(this.dataGridViewMatrix_SIA);
            this.groupBoxTask_SIA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SIA.Name = "groupBoxTask_SIA";
            this.groupBoxTask_SIA.Size = new System.Drawing.Size(723, 386);
            this.groupBoxTask_SIA.TabIndex = 0;
            this.groupBoxTask_SIA.TabStop = false;
            this.groupBoxTask_SIA.Text = "Условие";
            // 
            // textBoxTask_SIA
            // 
            this.textBoxTask_SIA.Location = new System.Drawing.Point(7, 36);
            this.textBoxTask_SIA.Multiline = true;
            this.textBoxTask_SIA.Name = "textBoxTask_SIA";
            this.textBoxTask_SIA.ReadOnly = true;
            this.textBoxTask_SIA.Size = new System.Drawing.Size(383, 318);
            this.textBoxTask_SIA.TabIndex = 1;
            this.textBoxTask_SIA.Text = resources.GetString("textBoxTask_SIA.Text");
            // 
            // dataGridViewMatrix_SIA
            // 
            this.dataGridViewMatrix_SIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SIA.Location = new System.Drawing.Point(396, 36);
            this.dataGridViewMatrix_SIA.Name = "dataGridViewMatrix_SIA";
            this.dataGridViewMatrix_SIA.Size = new System.Drawing.Size(321, 318);
            this.dataGridViewMatrix_SIA.TabIndex = 0;
            // 
            // groupBoxResult_SIA
            // 
            this.groupBoxResult_SIA.Controls.Add(this.labelResult_SIA);
            this.groupBoxResult_SIA.Controls.Add(this.textBoxResult_SIA);
            this.groupBoxResult_SIA.Location = new System.Drawing.Point(741, 12);
            this.groupBoxResult_SIA.Name = "groupBoxResult_SIA";
            this.groupBoxResult_SIA.Size = new System.Drawing.Size(275, 113);
            this.groupBoxResult_SIA.TabIndex = 1;
            this.groupBoxResult_SIA.TabStop = false;
            this.groupBoxResult_SIA.Text = "Вывод данных";
            // 
            // labelResult_SIA
            // 
            this.labelResult_SIA.AutoSize = true;
            this.labelResult_SIA.Location = new System.Drawing.Point(3, 34);
            this.labelResult_SIA.Name = "labelResult_SIA";
            this.labelResult_SIA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_SIA.TabIndex = 1;
            this.labelResult_SIA.Text = "Результат:";
            // 
            // textBoxResult_SIA
            // 
            this.textBoxResult_SIA.Location = new System.Drawing.Point(6, 50);
            this.textBoxResult_SIA.Name = "textBoxResult_SIA";
            this.textBoxResult_SIA.ReadOnly = true;
            this.textBoxResult_SIA.Size = new System.Drawing.Size(263, 20);
            this.textBoxResult_SIA.TabIndex = 0;
            this.textBoxResult_SIA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxResult_SIA_KeyPress);
            // 
            // buttonInfo_SIA
            // 
            this.buttonInfo_SIA.Location = new System.Drawing.Point(755, 352);
            this.buttonInfo_SIA.Name = "buttonInfo_SIA";
            this.buttonInfo_SIA.Size = new System.Drawing.Size(88, 46);
            this.buttonInfo_SIA.TabIndex = 2;
            this.buttonInfo_SIA.Text = "?";
            this.buttonInfo_SIA.UseVisualStyleBackColor = true;
            this.buttonInfo_SIA.Click += new System.EventHandler(this.buttonInfo_SIA_Click);
            // 
            // buttonDone_SIA
            // 
            this.buttonDone_SIA.Location = new System.Drawing.Point(849, 352);
            this.buttonDone_SIA.Name = "buttonDone_SIA";
            this.buttonDone_SIA.Size = new System.Drawing.Size(167, 45);
            this.buttonDone_SIA.TabIndex = 3;
            this.buttonDone_SIA.Text = "Выполнить";
            this.buttonDone_SIA.UseVisualStyleBackColor = true;
            this.buttonDone_SIA.Click += new System.EventHandler(this.buttonDone_SIA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 410);
            this.Controls.Add(this.buttonDone_SIA);
            this.Controls.Add(this.buttonInfo_SIA);
            this.Controls.Add(this.groupBoxResult_SIA);
            this.Controls.Add(this.groupBoxTask_SIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 8 | Щепёткин И. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_SIA.ResumeLayout(false);
            this.groupBoxTask_SIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SIA)).EndInit();
            this.groupBoxResult_SIA.ResumeLayout(false);
            this.groupBoxResult_SIA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SIA;
        private System.Windows.Forms.TextBox textBoxTask_SIA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SIA;
        private System.Windows.Forms.GroupBox groupBoxResult_SIA;
        private System.Windows.Forms.Label labelResult_SIA;
        private System.Windows.Forms.TextBox textBoxResult_SIA;
        private System.Windows.Forms.Button buttonInfo_SIA;
        private System.Windows.Forms.Button buttonDone_SIA;
    }
}

