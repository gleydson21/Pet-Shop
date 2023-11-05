namespace Pet_Shop.Models.Interfaces
{
    internal interface IRepository<T>
    {
        void SaveChanges();
    }
}