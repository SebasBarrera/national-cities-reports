using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_1.model;
using System.IO;

namespace Project_1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Municipality x = new Municipality("1","2","3","4","5");
            Console.WriteLine("holamundo");
            Console.WriteLine(x.Type);

            String[] lines = File.ReadAllLine("./data/dataset.csv");

            foreach (String line in lines) {
            
                String values = line.Split(',');

                String codDpto = values[0];
                String codMpio = values[1];
                String dpto = values[2];
                String mpio = values[3];
                String tipo = values[4];
            }
        }
    }
}
