using GlobalTicke.TicketManagement.Domain.Entities;

namespace GlobalTicke.TicketManagement.Application.Contracts.Persistence;

public interface IOrderRepository:IAsyncRepository<Order>
{
}
