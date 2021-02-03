using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BAIDA2021.ClassProject.warehouses
{
    public class Measurement
    {



        public int id { get; set; }

        public string grammage { get; set; }

        public string Thickness { get; set; }

        public string Top_Bright { get; set; }

        public int idSpec { get; set; }

        public Specification Specification { get; set; }



    }
}