using ComuterStoreProject.Entities;
using ComuterStoreProject.ViewModel;

namespace ComuterStoreProject.Repositories
{
    public interface IComputerRepository
    {
        Task<Computer> GetByIdAsync(int id);
        Task<List<Computer>> GetAllAsync();
        Task AddAsync(ComputerViewModel computer);
        Task UpdateAsync(Computer computer);
        Task DeleteAsync(int id);
        Task<List<Detail>> GetAllDetails();
    }
}
