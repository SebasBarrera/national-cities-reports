using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form2 : Form
    {
        List<string[]> dataInfo = new List<string[]>();
        public Form2(List<string[]> info)
        {
            dataInfo = info;
            InitializeComponent();
            chart1.Titles.Add("Gráfico circular generado con base en la cantidad de municipios por departamento");
            chart1.Series["s1"].IsValueShownAsLabel = true;
            int othersCounter = 0;
            foreach(string[] i in dataInfo)
            {
                int mun = Convert.ToInt32(i[0]); 
                if (mun >= 31)
                {
                    chart1.Series["s1"].Points.AddXY(i[1], mun);
                }
                else
                {
                    othersCounter += mun;
                }
            }
            chart1.Series["s1"].Points.AddXY("others", othersCounter);
            //chart1.Series["s1"].Points.AddXY("DEPARTAMENTO", "MUNICIPIOS");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
