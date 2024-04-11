using TypingCoach.Core.Models.Abstractions;
using TypingCoach.Core.Models.UserModels;

namespace TypingCoach.Core.Models.BaseModels
{
    public class BaseModel : Base
    {
        public Contact CreatedBy { get; }

        public Contact UpdatedBy { get; }
    }
}
