using TypingCoach.Core.Models.BaseModels;
namespace TypingCoach.Core.Models.UserModels
{
    public class User : BaseModel
    {
        public string UserName { get; }

        public string PasswordHash { get; }

        public Contact Contact { get; }

        public List<TypingResult> Results { get; }
    }
}
