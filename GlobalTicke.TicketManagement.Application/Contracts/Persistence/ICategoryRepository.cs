using GlobalTicke.TicketManagement.Domain.Entities;

namespace GlobalTicke.TicketManagement.Application.Contracts.Persistence;

public interface ICategoryRepository:IAsyncRepository<Category>
{
}
