using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agency.Models
{
    public class Team
    {
        public int Id { get; set; }       
        public string Name { get; set; }  
        public string NameOfJob { get; set; }   
        public string Image { get; set; }
    }
}