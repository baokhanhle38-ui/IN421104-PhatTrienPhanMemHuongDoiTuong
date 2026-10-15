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
        // TODO (Observer): Thêm observer vào danh sách _observers
        throw new NotImplementedException();
    }

    public void Unsubscribe(IEventObserver observer)
    {
        // TODO (Observer): Xóa observer khỏi danh sách _observers
        throw new NotImplementedException();
    }

    public Event CreateEvent(Guid clubId, string title, DateTime date)
    {
        // TODO:
        // 1. Kiểm tra club tồn tại trong _clubs (ném InvalidOperationException nếu không thấy)
        // 2. Kiểm tra title không được rỗng hoặc khoảng trắng (ném ArgumentException nếu rỗng)
        // 3. Tạo Event mới và thêm vào _events
        // 4. Báo sự kiện vừa tạo cho tất cả observer trong _observers
        // 5. Trả về Event vừa tạo
        throw new NotImplementedException();
    }

    public void Register(Guid eventId, Guid memberId)
    {
        // TODO:
        // 1. Lấy event theo eventId từ _events (ném InvalidOperationException nếu không thấy)
        // 2. Lấy member theo memberId từ _members (ném InvalidOperationException nếu không thấy)
        // 3. Kiểm tra member.ClubId == event.ClubId (ném InvalidOperationException nếu không cùng CLB)
        // 4. Gọi event.Register(memberId)
        throw new NotImplementedException();
    }

    public void CheckIn(Guid eventId, Guid memberId)
    {
        // TODO:
        // 1. Lấy event theo eventId từ _events (ném InvalidOperationException nếu không thấy)
        // 2. Gọi event.CheckIn(memberId)
        throw new NotImplementedException();
    }
}
