using Application.Common.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Queries.GetBlogs
{
    public class BlogBM:IMapFrom<BlogBM>
    {
        public string Description { get; set; }
        public string CreatedDate { get; set; }
        public string Author { get; set; }
    }
}
