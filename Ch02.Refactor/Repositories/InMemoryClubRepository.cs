using EduHub.Ch02.Domain;

namespace EduHub.Ch02.Repositories;

/// <summary>Repository lưu trong bộ nhớ. Sau này đổi sang DB chỉ cần class mới.</summary>
public class InMemoryClubRepository : IClubRepository
{
    private readonly List<Club> _store = new();

    public IReadOnlyList<Club> GetAll()
    {
        // TODO: Trả về toàn bộ danh sách CLB trong _store (dưới dạng IReadOnlyList)
        throw new NotImplementedException();
    }

    public Club? GetById(Guid id)
    {
        // TODO: Tìm CLB có Id tương ứng trong _store
        throw new NotImplementedException();
    }

    public void Add(Club club)
    {
        // TODO: Thêm CLB vào _store
        throw new NotImplementedException();
    }
}
