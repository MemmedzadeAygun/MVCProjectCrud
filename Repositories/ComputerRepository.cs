using ComuterStoreProject.Context;
using ComuterStoreProject.Entities;
using ComuterStoreProject.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace ComuterStoreProject.Repositories
{
    public class ComputerRepository : IComputerRepository
    {
        private readonly AppDbContext _context;
        public ComputerRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(ComputerViewModel computer)
        {
            var newComputer = new Computer()
            {
                MarkaName= computer.MarkaName,
                ModelName=computer.ModelName,
                inStock=computer.inStock,
                Size=computer.Size,
                DetailsId=computer.DetailsId
            };
            await _context.Computers.AddAsync(newComputer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            Computer computer = await _context.Computers.FindAsync(id);
            _context.Computers.Remove(computer);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Computer>> GetAllAsync()
        {
            return await _context.Computers.ToListAsync();
        }

        public async Task<List<Detail>> GetAllDetails()
        {
            return await _context.Details.ToListAsync();
        }

        public async Task<Computer> GetByIdAsync(int id)
        {
            return await _context.Computers.FindAsync(id);
        }

        public async Task UpdateAsync(Computer computer)
        {
            var computers = await _context.Computers.FindAsync(computer.Id);
            computer.MarkaName = computers.MarkaName;

            _context.Computers.Update(computer);
            await _context.SaveChangesAsync();
        }
    }
}
