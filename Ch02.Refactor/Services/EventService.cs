using EduHub.Ch02.Domain;
using EduHub.Ch02.Patterns.Observers;
using EduHub.Ch02.Repositories;

namespace EduHub.Ch02.Services;

/// <summary>Nghiệp vụ sự kiện + đóng vai Subject của Observer.</summary>
public class EventService : IEventService
{
    private readonly IClubRepository _clubs;
    private readonly IMemberRepository _members;
    private readonly IEventRepository _events;
    private readonly List<IEventObserver> _observers = new();

    public EventService(IClubRepository clubs, IMemberRepository members, IEventRepository events)
    {
        _clubs = clubs;
        _members = members;
        _events = events;
    }

    public void Subscribe(IEventObserver observer)
    {
        if (observer != null && !_observers.Contains(observer))
        {
            _observers.Add(observer);
        }
    }

    public void Unsubscribe(IEventObserver observer)
    {
        _observers.Remove(observer);
    }

    public Event CreateEvent(Guid clubId, string title, DateTime date)
    {
        var club = _clubs.GetById(clubId) ?? throw new InvalidOperationException($"Club with ID {clubId} was not found.");
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be empty or whitespace.", nameof(title));

        var ev = new Event
        {
            Id = Guid.NewGuid(),
            ClubId = clubId,
            Title = title,
            Date = date
        };

        _events.Add(ev);

        foreach (var observer in _observers)
        {
            observer.OnEventCreated(ev, club);
        }

        return ev;
    }

    public void Register(Guid eventId, Guid memberId)
    {
        var ev = _events.GetById(eventId) ?? throw new InvalidOperationException($"Event with ID {eventId} was not found.");
        var member = _members.GetById(memberId) ?? throw new InvalidOperationException($"Member with ID {memberId} was not found.");
        if (member.ClubId != ev.ClubId)
            throw new InvalidOperationException("Member does not belong to the club hosting this event.");

        ev.Register(memberId);
    }

    public void CheckIn(Guid eventId, Guid memberId)
    {
        var ev = _events.GetById(eventId) ?? throw new InvalidOperationException($"Event with ID {eventId} was not found.");
        ev.CheckIn(memberId);
    }
}
