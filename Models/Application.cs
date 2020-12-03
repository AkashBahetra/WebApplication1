using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Application
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }

    }
}
