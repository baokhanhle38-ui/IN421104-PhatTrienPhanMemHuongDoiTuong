namespace EduHub.Ch02.Patterns.Strategies;

public class CsvReportStrategy : IReportStrategy
{
    public string Name => "CSV";

    public string Render(IReadOnlyList<ClubStat> stats)
    {
        // TODO (Strategy): Format danh sách stats thành chuỗi CSV (dòng header và các dòng dữ liệu)
        throw new NotImplementedException();
    }
}
