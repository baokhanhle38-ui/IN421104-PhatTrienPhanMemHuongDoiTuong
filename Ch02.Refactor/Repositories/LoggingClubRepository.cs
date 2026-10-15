using EduHub.Ch02.Domain;
using EduHub.Ch02.Logging;

namespace EduHub.Ch02.Repositories;

/// <summary>
/// DECORATOR: bọc một IClubRepository để ghi log mỗi lần truy cập,
/// không phải sửa InMemoryClubRepository.
/// </summary>
public class LoggingClubRepository : IClubRepository
{
    private readonly IClubRepository _inner;
    private readonly IAppLogger _logger;

    public LoggingClubRepository(IClubRepository inner, IAppLogger logger)
    {
        _inner = inner;
        _logger = logger;
    }

    public IReadOnlyList<Club> GetAll()
    {
        // TODO (Decorator): Ghi log thông báo qua _logger, sau đó gọi _inner.GetAll() và trả về kết quả
        throw new NotImplementedException();
    }

    public Club? GetById(Guid id)
    {
        // TODO (Decorator): Ghi log thông báo qua _logger, sau đó gọi _inner.GetById(id) và trả về kết quả
        throw new NotImplementedException();
    }

    public void Add(Club club)
    {
        // TODO (Decorator): Ghi log thông báo qua _logger, sau đó gọi _inner.Add(club)
        throw new NotImplementedException();
    }
}
