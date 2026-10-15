namespace EduHub.Ch02.Patterns.Strategies;

public class ConsoleReportStrategy : IReportStrategy
{
    public string Name => "Console";

    public string Render(IReadOnlyList<ClubStat> stats)
    {
        // TODO (Strategy): Format danh sách stats thành chuỗi dạng text hiển thị console
        throw new NotImplementedException();
    }
}
