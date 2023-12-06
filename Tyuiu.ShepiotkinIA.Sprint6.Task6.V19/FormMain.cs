using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ShepiotkinIA.Sprint6.Task6.V19.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint6.Task6.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilepath;
        private void buttonOpen_SIA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SIA.ShowDialog();
            openFilepath = openFileDialogTask_SIA.FileName;
            textBoxVar_SIA.Text = File.ReadAllText(openFilepath);
            groupBoxVar_SIA.Text = groupBoxVar_SIA.Text + " " + openFileDialogTask_SIA.FileName;
            buttonDone_SIA.Enabled = true;
        }

        private void buttonDone_SIA_Click(object sender, EventArgs e)
        {
            string str = "l";
            textBoxResult_SIA.Text = ds.CollectTextFromFile(str, openFilepath);
        }

        private void buttonHelp_SIA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
