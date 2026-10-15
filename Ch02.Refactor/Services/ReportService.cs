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
        // TODO (Strategy):
        // 1. Duyệt qua tất cả CLB từ _clubs.GetAll()
        // 2. Với mỗi CLB, lấy số thành viên, số sự kiện, tổng lượt đăng ký và tổng lượt check-in
        // 3. Đóng gói thành danh sách ClubStat
        // 4. Trả về kết quả từ strategy.Render(stats)
        throw new NotImplementedException();
    }
}
