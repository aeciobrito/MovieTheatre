using MovieTheatrhe.Core.Repositories.Interfaces;

namespace MovieTheatrhe.Core.Configuration
{
    public interface IUnitOfWork
    {
        IFoodRepository FoodRepository { get; }
        Task CompleteAsync();
        void Dispose();
    }
}
