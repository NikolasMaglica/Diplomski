﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Commands.DeleteBLog
{
	public class DeleteBlogCommand : IRequest<int>
	{
		public int Id { get; set; }
	}
}
