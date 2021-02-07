 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.model
{
    class Municipality{


        

        public Municipality(string codeDepartment, string codeMunicipality, string nameDepartment, string nameMunicipality, string type){
            this.CodeDepartment = codeDepartment;
            this.CodeMunicipality = codeMunicipality;
            this.NameDepartment = nameDepartment;
            this.NameMunicipality = nameMunicipality;
            this.Type = Type;
        }

        public string CodeDepartment
        { get; set; }

        public string CodeMunicipality
        { get; set; }

        public string NameDepartment
        { get; set; }

        public string NameMunicipality
        { get; set; }

        public string Type
        { get; set; }

    } //end of class
}
