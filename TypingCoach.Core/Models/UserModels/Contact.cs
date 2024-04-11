using TypingCoach.Core.Models.BaseModels;

namespace TypingCoach.Core.Models.UserModels
{
    public class Contact : BaseModel
    {
        public string FirstName { get; }

        public string LastName { get; }

        public string Email { get; }

        public string PhoneNumber { get; }

        public DateTime BirthDay { get; }

        public User User { get; }
    }
}
