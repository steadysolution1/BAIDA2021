using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BAIDA2021.ClassProject
{
    public class Carton_type
    {

        public int id { get; set; }
        public string Type { get; set; }
        public int  Spec_Number { get; set; }

        public ICollection<Specification> Specification { get; set; }

    }
}