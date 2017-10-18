using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BPO.Web.Models
{
    public class Project : EntityBase
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
    }
}
