using TypingCoach.Core.Models.Abstractions;

namespace TypingCoach.Core.Models
{
    public class TypingResult : Base
    {
        public DateTime StartTime { get; }

        public DateTime EndTime { get; set; }

        public Text Text { get; }

        public Dictionary Dictionary { get; }
    }
}
