using Domain.Entities;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BlogRepository : IBlogRepository
    {
        public Task<Blog> CreateAsync(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Task<Blog> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Blog>> GetAllBlogsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Blog> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Blog> UpdateAsync(int id, Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
