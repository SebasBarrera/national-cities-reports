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
          //arreglar

            string[] lines = File.ReadAllLines("./data/dataset.csv");

            foreach (String line in lines) {
            
                string[] values = line.Split(',');

                string codDpto = values[0];
                string codMpio = values[1];
                string dpto = values[2];
                string mpio = values[3];
                string type = values[4];
            }
        }
    }
}
