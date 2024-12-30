using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Data.Concrete.EntityFramework.Contexts;
using ProgrammersBlog.Data.Concrete.EntityFramework.Repositories;

namespace ProgrammersBlog.Data.Concrete
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ProgrammersBlogContext _context;
        private EfCategoryRepository _categoryRepository;
        public UnitOfWork(ProgrammersBlogContext context)
        {
            _context = context;
        }

      
        public ICategoryRepository Categories => _categoryRepository ?? new EfCategoryRepository(_context);
       
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
