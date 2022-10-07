using Core.Entities;

namespace Entities.DTOs
{
    public class UserDetailsDto : IDto
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
    }
}
