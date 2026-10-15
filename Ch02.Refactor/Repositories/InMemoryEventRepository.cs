using EduHub.Ch02.Domain;

namespace EduHub.Ch02.Repositories;

public class InMemoryEventRepository : IEventRepository
{
    private readonly List<Event> _store = new();

    public IReadOnlyList<Event> GetByClub(Guid clubId)
    {
        // TODO: Trả về danh sách sự kiện có ClubId tương ứng
        throw new NotImplementedException();
    }

    public Event? GetById(Guid id)
    {
        // TODO: Tìm sự kiện theo Id
        throw new NotImplementedException();
    }

    public void Add(Event ev)
    {
        // TODO: Thêm sự kiện vào _store
        throw new NotImplementedException();
    }
}
