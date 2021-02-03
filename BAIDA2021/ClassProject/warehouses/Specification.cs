using BAIDA2021.ClassProject.warehouses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BAIDA2021.ClassProject
{
    public class Specification
    {

        public int id { get; set; }



        [Required]
        public string naemcarton { get; set; }




        public string website { get; set; }



        public string Note { get; set; }



        public string pdfd { get; set; }




        public string wakilmahalt { get; set; }


        public string wakelalami { get; set; }




        public string refec { get; set; }


        public string contry { get; set; }


        public string numpermwasafh { get; set; }



        public string Email { get; set; }


        public string phone_Supplier { get; set; }


        public string company_name { get; set; }


        public string numgemshet { get; set; }





        public int idtypcoton { get; set; }


        public Carton_type Carton_type { get; set; }

        public ICollection<Measurement> Measurement { get; set; }





    }
}