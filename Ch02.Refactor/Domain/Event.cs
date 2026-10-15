namespace EduHub.Ch02.Domain;

/// <summary>Sự kiện của CLB, kèm danh sách đăng ký và check-in.</summary>
public class Event
{
    public Guid Id { get; set; }
    public Guid ClubId {get;set;}
    public required string Title {get;set;}
    public DateTime Date {get;set;}

    public HashSet<Guid> RegisteredMemberIds{ get; set;} = new();
    public HashSet<Guid> CheckedInMemberIds{ get; set;}= new();
    
    //<summary> Đăng ký </summary>
    public bool Register(Guid menberId)=> RegisteredMemberIds.Add(menberid);
    
    //<summary> check-in </summary>
    public void CheckIn(Guid menberID)
    {
        if (!RegisteredMemberIDs.Contains(memberId))
         throw new InvaliOpenrationException("Member has not registered for this event.");
         CheckedInMemberIds.Add(memberId);
    }
    ///<summary> Tỉ lệ check-in trên tham số đăng ký </summary>
    public double AttendanceRate =>
        RegisteredMemberIds.Count == 0 ?0 : (double) CheckedInMemberIds.Count / RegisteredMemberIds.Count;

}
