using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetworkConstructor
{
    public partial class ModelSettings : Form
    {
        public ModelSettings()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);

            radioButton4.CheckedChanged += new EventHandler(radioButtons1_CheckedChanged);
            radioButton5.CheckedChanged += new EventHandler(radioButtons1_CheckedChanged);
            radioButton6.CheckedChanged += new EventHandler(radioButtons1_CheckedChanged);
        }
        
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            
            if (radioButton.Checked == true)
            {
                switch (radioButton.Text)
                {
                    case "binary cross entropy":
                        Data.loss = "binary_crossentropy";
                        break;
                    case "categorical crossentropy":
                        Data.loss = "categorical_crossentropy";
                        break;
                    case "categorical hinge":
                        Data.loss = "categorical_hinge";
                        break;
                }
                
            }


        }
        private void radioButtons1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton.Checked == true)
            {
                switch (radioButton.Text)
                {
                    case "Adam":
                        Data.optimizer = "adam";
                        break;
                    case "Nadam":
                        Data.optimizer = "nadam";
                        break;
                    case "SGD":
                        Data.optimizer = "sgd";
                        break;
                }

            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (StreamWriter sw = new StreamWriter("neural.py", true, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine($"])\nmodel.compile(optimizer = '{Data.optimizer}',\nloss = '{Data.loss}',\nmetrics =['accuracy'])");
                    sw.WriteLine($"batch_size = {textBox1.Text}");
                    sw.WriteLine($"epochs = {textBox2.Text}");
                    sw.WriteLine($"input_shape  = ({dataGridView1[0, 0].Value},{dataGridView1[1, 0].Value},{dataGridView1[2, 0].Value})");
                    sw.WriteLine($"target_size  = ({dataGridView1[0, 0].Value},{dataGridView1[1, 0].Value})");
                    Console.WriteLine($"input_shape  = ({dataGridView1[0, 1].Value},{dataGridView1[1, 1].Value},{dataGridView1[2, 1].Value})");
                    Console.WriteLine($"target_size  = ({dataGridView1[0, 1].Value},{dataGridView1[1, 1].Value})");
                    

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            using (StreamWriter sw = new StreamWriter("neural.py", true, System.Text.Encoding.UTF8))
            {
                using (StreamReader sr = new StreamReader("NeuralNetwork/FinishNN.txt"))
                {
                    sw.WriteLine(sr.ReadToEnd());
                }
            }
            Process.Start("neural.py");
        }

        private void ModelSettings_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["X"].Value = "200";
            e.Row.Cells["Y"].Value = "200";
            e.Row.Cells["Z"].Value = "3";
        }
    }
}
