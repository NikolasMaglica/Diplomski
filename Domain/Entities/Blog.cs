using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public string Desctiption { get; set; }
        public string CreatedDate { get; set; }
        public string Author { get; set; }
        public string ImageUrl { get; set; }
    }
}
