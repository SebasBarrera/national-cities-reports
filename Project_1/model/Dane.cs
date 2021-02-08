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

        

   

        //public List<Municipality> selectedByChar(char x)
        //{
        //     Municipality selected = new List();
        //    foreach (Municipality i in municipalities)
        //    {
        //        if (municipalities[i].charAt(0).Equals(x)
        //        {
        //            selected.add(municipalities[i]);
        //        }
        //    }

        //    return selected;
        //}
    }
}