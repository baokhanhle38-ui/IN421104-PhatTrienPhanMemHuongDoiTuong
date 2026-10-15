namespace EduHub.Ch02.Notifications;

/// <summary>
/// Cài đặt Factory. Code gọi Create(kênh) và nhận về INotificationService,
/// không cần biết (và không cần new) class cụ thể. Thêm kênh mới = thêm một nhánh ở đây.
/// </summary>
public class NotificationServiceFactory : INotificationServiceFactory
{
    public INotificationService Create(NotificationChannel channel)
    {
        // TODO (Factory): Trả về instance INotificationService tương ứng với từng channel (Email, Sms, Slack)
        // Nếu channel không hợp lệ, ném ArgumentOutOfRangeException
        throw new NotImplementedException();
    }
}
