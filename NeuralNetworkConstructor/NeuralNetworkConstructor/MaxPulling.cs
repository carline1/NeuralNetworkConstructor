using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetworkConstructor
{
    public partial class MaxPulling : Form
    {
        public MaxPulling()
        {
            InitializeComponent();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1[0, 0].Value != null & dataGridView1[1, 0].Value != null)
            {
                Main form = new Main();
                try
                {
                    using (StreamWriter sw = new StreamWriter("neural.py", true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine($"\tMaxPooling2D(({dataGridView1[0, 0].Value},{dataGridView1[1, 0].Value}), strides=2),");
                    }
                    Console.WriteLine("Запись выполнена");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                form.Show();
            }
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["X"].Value = "2";
            e.Row.Cells["Y"].Value = "2";
        }
    }
}
