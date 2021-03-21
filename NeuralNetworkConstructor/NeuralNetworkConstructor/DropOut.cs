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
    public partial class DropOut : Form
    {
        public DropOut()
        {
            InitializeComponent();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Main form = new Main();
                try
                {
                    using (StreamWriter sw = new StreamWriter("neural.py", true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine($"\tDropout({textBox4.Text}),");
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
    }
}
