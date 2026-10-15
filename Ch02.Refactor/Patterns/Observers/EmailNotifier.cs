using EduHub.Ch02.Domain;
using EduHub.Ch02.Notifications;
using EduHub.Ch02.Repositories;

namespace EduHub.Ch02.Patterns.Observers;

/// <summary>Gửi email cho mọi thành viên CLB khi có sự kiện mới.</summary>
public class EmailNotifier : IEventObserver
{
    private readonly IMemberRepository _members;
    private readonly INotificationService _notifier;

    public EmailNotifier(IMemberRepository members, INotificationService notifier)
    {
        _members = members;
        _notifier = notifier;
    }

    public void OnEventCreated(Event ev, Club club)
    {
        // TODO (Observer): Lấy danh sách thành viên thuộc CLB từ _members và gửi email thông báo qua _notifier
        throw new NotImplementedException();
    }
}
