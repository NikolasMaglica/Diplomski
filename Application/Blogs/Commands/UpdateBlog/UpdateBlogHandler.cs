using Domain.Entities;
using Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Commands.UpdateBlog
{
	public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand, int>
	{
		private readonly IBlogRepository _blogRepository;

		public UpdateBlogCommandHandler(IBlogRepository blogRepository)
		{
			_blogRepository = blogRepository;
		}
		public async Task<int> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
		{
			var UdateblogEntity = new Blog()
			{
				Id = request.Id,
				Desctiption = request.Description,
				CreatedDate = request.CreatedDate,
				Author = request.Author,
				ImageUrl=request.ImageUrl
			};

			return await _blogRepository.UpdateAsync(request.Id, UdateblogEntity);
		}
	}
}
