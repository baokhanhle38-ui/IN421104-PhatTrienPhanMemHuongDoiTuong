using EduHub.Ch02.Domain;

namespace EduHub.Ch02.Repositories;

public class InMemoryMemberRepository : IMemberRepository
{
    private readonly List<Member> _store = new();

    public IReadOnlyList<Member> GetByClub(Guid clubId)
    {
        // TODO: Trả về danh sách thành viên có ClubId tương ứng
        throw new NotImplementedException();
    }

    public Member? GetById(Guid id)
    {
        // TODO: Tìm thành viên theo Id
        throw new NotImplementedException();
    }

    public void Add(Member member)
    {
        // TODO: Thêm thành viên vào _store
        throw new NotImplementedException();
    }
}
