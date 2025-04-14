using Application.Blogs.Queries.GetBlogs;
using AutoMapper;
using Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Blogs.Queries.GetBlogById
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, BlogBM>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;   
        public GetBlogByIdQueryHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper=mapper;
        }
        public async Task<BlogBM> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
           var blog= await _blogRepository.GetByIdAsync(request.BlogId);
            return _mapper.Map<BlogBM>(blog);
        }
    }
}
