namespace GlobalTicke.TicketManagement.Application.Contracts.Persistence;


public interface IAsyncRepository<T> where T : class
{
    Task<T> GetByIdAsync(T entity);
    Task<IReadOnlyList<T>> GetAllAsync();   
    Task<T>AddAsync(T entity);   
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);  
}
