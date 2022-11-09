using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class PetsViewModel
    {
        [DisplayName("Id")]
        public object id { get; set; }
        public Category category { get; set; }
        [DisplayName("Nombre Mascota")]
        public string name { get; set; }
        public List<string> photoUrls { get; set; }
        public List<Tag> tags { get; set; }
        [DisplayName("Estado")]
        public string status { get; set; }
    }

    public class Tag
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}