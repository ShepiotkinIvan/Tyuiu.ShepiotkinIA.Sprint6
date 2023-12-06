using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShepiotkinIA.Sprint6.Task5.V29.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint6.Task5.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\FedorShluhin\source\repos\Tyuiu.ShepiotkinIA.Sprint6\Tyuiu.ShepiotkinIA.Sprint6.Task5.V29\bin\Debug\InPutFileTask5V29.txt";
        private void buttonInfo_SIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-2 Щепёткин Иван Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_SIA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonDone_SIA_Click(object sender, EventArgs e)
        {
            dataGridViewNums_SIA.ColumnCount = 2;
            dataGridViewNums_SIA.Columns[0].Width = 20;
            dataGridViewNums_SIA.Columns[1].Width = 50;

            this.chartDiag_SIA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_SIA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_SIA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_SIA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_SIA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
    }
}
