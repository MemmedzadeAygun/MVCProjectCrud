using ComuterStoreProject.Entities;
using System.ComponentModel.DataAnnotations;

namespace ComuterStoreProject.ViewModel
{
    public class ComputerViewModel
    {
        public ComputerViewModel()
        {
            
        }
        public int Id { get; set; }

        [Required(ErrorMessage ="Marka name is required")]
        [StringLength(50, ErrorMessage="Marka name cannot exceed 50 characters.")]
        public string MarkaName { get; set; }

        [Required(ErrorMessage = "Model name is required")]
        [StringLength(50, ErrorMessage = "Model name cannot exceed 50 characters.")]
        public string ModelName { get; set; }

        [Required(ErrorMessage ="InStock is required")]
        public int inStock { get; set; }

        [Required(ErrorMessage = "Size is required")]
        [StringLength(20, ErrorMessage = "Size cannot exceed 20 characters.")]
        public string Size { get; set; }
        public int DetailsId { get; set; }
        public Detail Details { get; set; }
    }
}
