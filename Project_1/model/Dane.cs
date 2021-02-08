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

        public List<string[]> MunicipiosPorDepartamento()
        {
            List<string[]> datos = new List<string[]>();
            string actual = "ANTIOQUIA";
            int amountMunPerDep = 0;
            foreach (Municipality mun in Municipalities)
            {
                //int codeDepartment = Convert.ToInt32(mun.CodeDepartment);
                
                if (mun.NameDepartment.Equals(actual))
                {
                    amountMunPerDep++;
                }
                else
                {
                
                        string amount = amountMunPerDep + "";
                        string[] dato = { amount, mun.NameDepartment };
                        datos.Add(dato);
                        amountMunPerDep = 1;
                        actual = mun.NameDepartment;
                    
                   
                }
            }
                return datos;
        }





       
    }
}