using GlobalTicke.TicketManagement.Domain.Common;

namespace GlobalTicke.TicketManagement.Domain.Entities;

public class Category:AuditableEntity
{
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; }=string.Empty;
    public ICollection<Event>? Events { get; set;}
        

}
