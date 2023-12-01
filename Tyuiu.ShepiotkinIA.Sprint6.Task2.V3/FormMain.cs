using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShepiotkinIA.Sprint6.Task2.V3.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint6.Task2.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonInfo_SIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-2 Щепёткин Иван Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_SIA_Click(object sender, EventArgs e)
        {
            try
            {
                int StartStep = Convert.ToInt32(textBoxVarStart_SIA.Text);
                int StopStep = Convert.ToInt32(textBoxVarStop_SIA.Text);
                int len = ds.GetMassFunction(StartStep, StopStep).Length;
                double[] result = new double[len];
                result = ds.GetMassFunction(StartStep, StopStep);
                this.chartFunction_SIA.Titles.Add("График функции F(X)= sin(x) / x + 1,2 + cos(x) * 7x - 2");

                this.chartFunction_SIA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SIA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_SIA.Rows.Add(Convert.ToString(StartStep), Convert.ToString(result[i]));
                    this.chartFunction_SIA.Series[0].Points.AddXY(StartStep, result[i]);
                    StartStep++;
                }

            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarStart_SIA_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxVarStop_SIA_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonDone_SIA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SIA.BackColor = Color.Red;
        }

        private void buttonDone_SIA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SIA.BackColor = Color.Green;
        }

        private void buttonDone_SIA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SIA.BackColor = Color.Blue;
        }
    }
}
