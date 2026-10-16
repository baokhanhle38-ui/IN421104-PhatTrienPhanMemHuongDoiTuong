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
        var club = Club.Create(name, description);
        _clubs.Add(club);
        _logger.Info($"Club created: {name}");
        _notifier.Send(presidentEmail, $"Club '{name}' has been created successfully.");
        return club;
    }

    public Member AddMember(Guid clubId, string memberName, string email)
    {
        var club = _clubs.GetById(clubId) ?? throw new InvalidOperationException("Club not found");
        var existingMembers = _members.GetByClub(clubId);
        if (!club.HasRoom(existingMembers.Count))
            throw new InvalidOperationException("Club is full (max 50 members)");

        var member = new Member
        {
            Id = Guid.NewGuid(),
            Name = memberName,
            Email = email,
            ClubId = clubId
        };
        _members.Add(member);
        _logger.Info($"Member {memberName} joined {club.Name}");
        _notifier.Send(email, $"Welcome {memberName} to {club.Name}!");
        return member;
    }
}
