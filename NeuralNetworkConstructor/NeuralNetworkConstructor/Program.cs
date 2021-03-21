using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNetworkConstructor
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string currentPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Console.WriteLine(currentPath);
            if (!Directory.Exists(Path.Combine(currentPath, "dirs")))
                Directory.CreateDirectory(Path.Combine(currentPath, "dirs"));

            DirectoryInfo drInfo = new DirectoryInfo("dirs");
            if (drInfo.Exists)
            {
                drInfo.CreateSubdirectory(Data.train);
                drInfo.CreateSubdirectory(Data.val);
                drInfo.CreateSubdirectory(Data.test);
            }
        
            using (StreamWriter sw = new StreamWriter("neural.py", false, System.Text.Encoding.UTF8))
            {
                using (StreamReader sr = new StreamReader("NeuralNetwork/StartNN.txt"))
                {
                    sw.WriteLine(sr.ReadToEnd());
                }
            }
            Application.Run(new Main());
        }
    }
}
