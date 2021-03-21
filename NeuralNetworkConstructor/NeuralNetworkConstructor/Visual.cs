using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetworkConstructor
{
    public partial class Visual : Form
    {
        public Visual()
        {
            InitializeComponent();
        }
        PictureBox img = new PictureBox();
        public void addImage(string type)
        {
            void MoveTo(int newX, int newY) 
            {
                img.Location = new Point(newX, newY);
            }
            switch (type)
            {
                case "linear":

                    img.Image = Image.FromFile("C:/Users/ivlad/source/repos/NeuralNetworkConstructor/NeuralNetworkConstructor/bin/Debug/linear.png");
                    img.SizeMode = PictureBoxSizeMode.StretchImage;

                    break;
            }
        }
    }
}
