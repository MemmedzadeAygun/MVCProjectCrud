
using ComuterStoreProject.Entities;
using ComuterStoreProject.ViewModel;

namespace ComuterStoreProject.Repositories
{
    public interface ICompDetailRepository
    {
        Task<Detail> GetByIdAsync(int id);
        Task<List<Detail>> GetAllAsync();
        Task AddAsync(DetailViewModel detail);
        Task UpdateAsync(Detail details);
        Task DeleteAsync(int id);
    }
}
