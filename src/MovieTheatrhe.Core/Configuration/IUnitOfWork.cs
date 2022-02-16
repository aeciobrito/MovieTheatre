using MovieTheatre.Core.Repositories.Interfaces;

namespace MovieTheatre.Core.Configuration
{
    public interface IUnitOfWork
    {
        IFoodRepository FoodRepository { get; }
        Task CompleteAsync();
        void Dispose();
    }
}
