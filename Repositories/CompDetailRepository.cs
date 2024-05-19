using ComuterStoreProject.Context;
using ComuterStoreProject.Entities;
using ComuterStoreProject.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace ComuterStoreProject.Repositories
{
    public class CompDetailRepository : ICompDetailRepository
    {
        private readonly AppDbContext _context;
        public CompDetailRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(DetailViewModel detail)
        {

            var newDetail = new Detail()
            {
                Price=detail.Price
            };
            await _context.Details.AddAsync(newDetail);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            Detail details=await _context.Details.FindAsync(id);
            _context.Details.Remove(details);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Detail>> GetAllAsync()
        {
            return await _context.Details.ToListAsync();
        }

        public async Task<Detail> GetByIdAsync(int id)
        {
            return await _context.Details.FindAsync(id);
        }

        public async Task UpdateAsync(Detail details)
        {
            var detail = await _context.Details.FindAsync(details.Id);
            detail.Price = details.Price;

            _context.Details.Update(detail);
            await _context.SaveChangesAsync();
        }
    }
}
