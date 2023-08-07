using CleanArchMVC.Domain.Entities;
using CleanArchMVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMVC.Application.Repository
{
    public class Class1 : ICategoryRepository
    {
        public Task<Category> CreateAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<Category> DeleteAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
