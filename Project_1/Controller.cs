using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_1.model;

namespace Project_1
{
    class Controller
    {
        public Dane adminDane = new Dane();
        public List<string[]> LoadData(string absolutePathFile)
        {
            List<string[]> rowsList = new List<string[]>();

           
            string[] lines = File.ReadAllLines(absolutePathFile);



            foreach (string line in lines)
            {

                string[] values = line.Split(',');
                string codDpto = values[0];
                char initial1stWord = codDpto[0];

                if (codDpto.Length == 2)
                {
                    Municipality newMun = new Municipality(codDpto, values[1], values[2], values[3], values[4]);
                    rowsList.Add(values);
                    adminDane.AddMunicipality(newMun);
                   
                }

                

            }

            return rowsList;
        }
    }
}
