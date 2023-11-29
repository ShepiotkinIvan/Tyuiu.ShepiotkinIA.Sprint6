using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShepiotkinIA.Sprint6.Task0.V24.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint6.Task0.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_SIA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_SIA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_SIA.Text)));
            }
            catch
            {
                MessageBox.Show("Вы ввели неверные данные!", "Уведомление об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBoxVarX_SIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonInfo_SIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-23-2 Щепёткин Иван Андреевич", "Сообщение");
        }
    }
}
