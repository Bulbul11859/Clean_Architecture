
using AutoMapper;
using GlobalTicke.TicketManagement.Application.Contracts.Persistence;
using GlobalTicke.TicketManagement.Domain.Entities;
using MediatR;

namespace GlobalTicke.TicketManagement.Application.Feature.Events;

public class GetEventsListQueryHandler : IRequestHandler<GetEventsListQuery, List<EventListVm>>
{
    private readonly IAsyncRepository<Event> _eventRepository;
    private readonly IMapper _mapper;

    public GetEventsListQueryHandler(IMapper mapper,IAsyncRepository<Event> eventRepository)
    {
        _mapper = mapper;
        _eventRepository = eventRepository; 
    }
    public async Task<List<EventListVm>> Handle(GetEventsListQuery request, CancellationToken cancellationToken)
    {
        var allEvents = (await _eventRepository.GetAllAsync()).OrderBy(x=>x.Date); 
        return _mapper.Map<List<EventListVm>>(allEvents); 
    }
}
