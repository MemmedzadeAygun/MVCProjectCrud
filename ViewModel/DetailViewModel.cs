using ComuterStoreProject.Entities;
using System.ComponentModel.DataAnnotations;

namespace ComuterStoreProject.ViewModel
{
    public class DetailViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Price is required")]
        public int Price { get; set; }
        public ICollection<Computer> Computers { get; set; }
    }
}
