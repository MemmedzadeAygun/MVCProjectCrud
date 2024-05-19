

namespace ComuterStoreProject.Entities
{
    public class Computer
    {
        public int Id { get; set; }
        public string MarkaName { get; set; }
        public string ModelName { get; set; }
        public int inStock { get; set; }
        public string Size { get; set; }
        public int DetailsId { get; set; }
        public Detail Details { get; set; }
    }
}
