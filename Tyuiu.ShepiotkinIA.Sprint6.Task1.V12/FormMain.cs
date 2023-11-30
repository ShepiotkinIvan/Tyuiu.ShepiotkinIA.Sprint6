using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShepiotkinIA.Sprint6.Task1.V12.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint6.Task1.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxVarStart_SIA_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxVarStop_SIA_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonInfo_SIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-2 Щепёткин Иван Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_SIA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startValue = Convert.ToInt32(textBoxVarStart_SIA.Text);
                int stopValue = Convert.ToInt32(textBoxVarStop_SIA.Text);

                string strLine;
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_SIA.Text = "";

                textBoxResult_SIA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_SIA.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_SIA.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5}    |  {1, 6:f2}   |", startValue, valueArray[i]);
                    textBoxResult_SIA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_SIA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
