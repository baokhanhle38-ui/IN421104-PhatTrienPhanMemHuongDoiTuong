using EduHub.Ch02.Patterns.Strategies;
using EduHub.Ch02.Repositories;

namespace EduHub.Ch02.Services;

/// <summary>Chỉ thống kê dữ liệu; việc định dạng giao cho IReportStrategy (OCP).</summary>
public class ReportService : IReportService
{
    private readonly IClubRepository _clubs;
    private readonly IMemberRepository _members;
    private readonly IEventRepository _events;

    public ReportService(IClubRepository clubs, IMemberRepository members, IEventRepository events)
    {
        _clubs = clubs;
        _members = members;
        _events = events;
    }

    public string Generate(IReportStrategy strategy)
    {
        var stats = new List<ClubStat>();

        foreach (var club in _clubs.GetAll())
        {
            var members = _members.GetByClub(club.Id);
            var events = _events.GetByClub(club.Id);
            int totalRegistered = events.Sum(e => e.RegisteredMemberIds.Count);
            int totalCheckedIn = events.Sum(e => e.CheckedInMemberIds.Count);

            stats.Add(new ClubStat(
                club.Name,
                members.Count,
                events.Count,
                totalRegistered,
                totalCheckedIn
            ));
        }

        return strategy.Render(stats);
    }
}
