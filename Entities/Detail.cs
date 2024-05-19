namespace ComuterStoreProject.Entities
{
    public class Detail
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public ICollection<Computer> Computers { get; set; }
    }
}
