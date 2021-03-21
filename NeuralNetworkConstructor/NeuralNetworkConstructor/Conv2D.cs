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
    public partial class Conv2D : Form
    {
        public Conv2D()
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
                        sw.WriteLine($"\tConv2D({textBox3.Text}, ({dataGridView1[0, 0].Value},{dataGridView1[1, 0].Value}), padding='same', activation='relu'),");
                    }
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
            e.Row.Cells["X"].Value = "3";
            e.Row.Cells["Y"].Value = "3";
        }
    }   
}
