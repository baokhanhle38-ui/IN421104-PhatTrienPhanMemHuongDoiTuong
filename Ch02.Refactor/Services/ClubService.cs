using EduHub.Ch02.Domain;
using EduHub.Ch02.Logging;
using EduHub.Ch02.Notifications;
using EduHub.Ch02.Repositories;

namespace EduHub.Ch02.Services;

/// <summary>Nghiệp vụ CLB. Mọi phụ thuộc đều là interface, nhận qua constructor (DIP).</summary>
public class ClubService : IClubService
{
    private readonly IClubRepository _clubs;
    private readonly IMemberRepository _members;
    private readonly INotificationService _notifier;
    private readonly IAppLogger _logger;

    public ClubService(IClubRepository clubs, IMemberRepository members,
        INotificationService notifier, IAppLogger logger)
    {
        _clubs = clubs;
        _members = members;
        _notifier = notifier;
        _logger = logger;
    }

    public Club CreateClub(string name, string description, string presidentEmail)
    {
        // TODO:
        // 1. Gọi Club.Create(name, description) để validate và tạo CLB
        // 2. Thêm club vào _clubs
        // 3. Ghi log thông báo club được tạo qua _logger
        // 4. Gửi thông báo đến presidentEmail qua _notifier
        // 5. Trả về club vừa tạo
        throw new NotImplementedException();
    }

    public Member AddMember(Guid clubId, string memberName, string email)
    {
        // TODO:
        // 1. Lấy club theo clubId từ _clubs (nếu không thấy ném InvalidOperationException("Club not found"))
        // 2. Kiểm tra club.HasRoom với số lượng thành viên hiện có từ _members.GetByClub(clubId).Count
        //    (nếu không đủ chỗ ném InvalidOperationException)
        // 3. Tạo Member mới và thêm vào _members
        // 4. Ghi log thành viên tham gia qua _logger
        // 5. Gửi thông báo chào mừng qua _notifier
        // 6. Trả về member vừa tạo
        throw new NotImplementedException();
    }
}
