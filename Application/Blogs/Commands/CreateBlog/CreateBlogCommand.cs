﻿using Application.Blogs.Queries.GetBlogs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Commands.CreateBlog
{
	public class CreateBlogCommand : IRequest<BlogBM>
	{
		public int Id { get; set; }	
		public string Description { get; set; }
		public string CreatedDate { get; set; }
		public string Author { get; set; }
		public string ImageUrl { get; set; }

	}
}
