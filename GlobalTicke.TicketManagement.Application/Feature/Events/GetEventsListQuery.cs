using MediatR;

namespace GlobalTicke.TicketManagement.Application.Feature.Events;

public class GetEventsListQuery:IRequest<List<EventListVm>>
{
}
