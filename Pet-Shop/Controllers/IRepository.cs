namespace Pet_Shop.Controllers
{
    internal interface IRepository<T>
    {
        void SaveChanges();
    }
}