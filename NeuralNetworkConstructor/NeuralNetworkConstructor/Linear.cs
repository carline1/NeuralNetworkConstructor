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
    public partial class Linear : Form
    {
      

        public Linear()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Main form = new Main();
                try
                {
                    using (StreamWriter sw = new StreamWriter("neural.py", true, System.Text.Encoding.UTF8))
                    {
                        if(Data.dence == 1)
                        {
                            sw.WriteLine($"\tFlatten(),");
                        }
                        sw.WriteLine($"\tDense({textBox1.Text}, activation='relu'),");
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

        private void StreamWriter(string v1, object path, bool v2, object append)
        {
            throw new NotImplementedException();
        }
    }
}
