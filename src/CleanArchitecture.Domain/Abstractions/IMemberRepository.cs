using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Abstractions;

public interface IMemberRepository
{
    Task<IEnumerable<Member>> GetAll();
    Task<Member> GetMemberById(int memberId);
    Task<Member> AddMember(Member member);
    Task<Member> UpdateMember(Member member);
    Task DeleteMember(int memberId);
}
