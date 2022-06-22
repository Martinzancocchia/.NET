using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.MVC.Models
{
    public class Character
    {
         public int id { get; set; }
        public string name { get; set; }    

        public string status { get; set; }

        public string species { get; set; }
    }

    public class RymResponse
    {
        public List<Character> results { get; set; }


    }
}