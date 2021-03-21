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
    public partial class Main : Form
    {
        public int button_location;
        public Main()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            int button1Left = button1.Left;
            

        }


        private void button1_Click(object sender, EventArgs e)
        {

            groupBox1.Show();
        }

        
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            Linear linear = new Linear();
            Conv2D conv2D = new Conv2D();
            MaxPulling max_pulling = new MaxPulling();
            DropOut drop_out = new DropOut();
            Visual visual = new Visual();
            if (radioButton.Checked == true)
            {
                foreach (Form f in Application.OpenForms)
                    if (f.GetType() != typeof(Main))
                        f.Hide();
                switch (radioButton.Text)
                {
                    case "Dence":
                        Data.dence += 1;
                        linear.Show();
                        //visual.addImage("linear");
                        //visual.Show();
                        this.Hide();
                        break;
                    case "Conv2D":
                        conv2D.Show();
                        this.Hide();
                        break;
                    case "Max Pulling":
                        max_pulling.Show();
                        this.Hide();
                        break;
                    case "Drop out":
                        drop_out.Show();
                        this.Hide();
                        break;
                }
            }      
            
            
        }
        

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //File.Create("C:/Users/ivlad/source/repos/NeuralNetworkConstructor/NeuralNetworkConstructor/bin/Debug/neurall.py");
            //File.AppendAllText(@"C:\Users\ivlad\source\repos\NeuralNetworkConstructor\NeuralNetworkConstructor\bin\Debug\neurall.py", File.ReadAllText(@"C:\Users\ivlad\source\repos\NeuralNetworkConstructor\NeuralNetworkConstructor\bin\Debug\NN.txt"));
        }

        private void button2_Click(object sender, EventArgs e)
        { 

            ModelSettings modelSettings = new ModelSettings();
            modelSettings.Show();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
