using Application.Blogs.Queries.GetBlogs;
using AutoMapper;
using Domain.Entities;
using Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Commands.CreateBlog
{
	public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, BlogVm>
	{
		private readonly IBlogRepository _blogRepository;
		private readonly IMapper _mapper;

		public CreateBlogCommandHandler(IBlogRepository blogRepository, IMapper mapper)
		{
			_blogRepository = blogRepository;
			_mapper = mapper;
		}
		public async Task<BlogBM> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
		{
			var blogEnity = new Blog() { Desctiption = request.Description, CreatedDate = request.CreatedDate, Author = request.Author };
			var Result = await _blogRepository.CreateAsync(blogEnity);
			return _mapper.Map<BlogBM>(Result);
		}
	}
}
