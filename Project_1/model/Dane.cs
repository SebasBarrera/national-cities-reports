using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_1.model
{
    class Dane
    {
        List<Municipality> Municipalities = new List<Municipality>();

        public void AddMunicipality(Municipality mun)
        {
            Municipalities.Add(mun);

        }

        public List<string[]> FilteredList(string initial)
        {
            List<string[]> rowsDvg = new List<string[]>();
            char initialChar = initial[0];

            foreach (Municipality mun in Municipalities)
            {
                string depName = mun.NameDepartment;
                if (depName[0].Equals(initialChar))
                    
                {
                    string[] line = {mun.CodeDepartment, mun.CodeMunicipality, mun.NameDepartment, mun.NameMunicipality, mun.Type };
                    rowsDvg.Add(line);
                }
            }



            return rowsDvg;
        }





       
    }
}