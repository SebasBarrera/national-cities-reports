using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Project_1.model
{
    class Dane
    {
        private ArrayList municipalities = new ArrayList();

        public Dane()
        {

        }

        public loadData(string absPath)
        {
            string[] lines = File.ReadAllLines(absPath);



            foreach (String line in lines)
            {

                string[] values = line.Split(',');

                string codDpto = values[0];
                string codMpio = values[1];
                string dpto = values[2];
                string mpio = values[3];
                string type = values[4];


                municipalities.add(new Municipality(codDpto, codMpio, dpto, mpio, type));
            }
        }

        public ArrayList<Municipality> municipalities
        {
            get; set;
        }

        public Arraylist<Municipality> selectedByChar(char x)
        {
             Municipality selected = new ArrayList();
            foreach (Municipality i in municipalities)
            {
                if (municipalities[i].charAt(0).Equals(x)
                {
                    selected.add(municipalities[i]);
                }
            }

            return selected;
        }
    }
}