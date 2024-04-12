using TypingCoach.Core.Models.BaseModels;

namespace TypingCoach.Core.Models
{
    public class TypingResult : BaseModel
    {
        private TypingResult(Text text, Dictionary dictionary)
        {
            Text = text;
            Dictionary = dictionary;
        }

        public DateTime StartTime { get; } = DateTime.UtcNow;

        public DateTime EndTime { get; set; }

        public Text Text { get; }

        public Dictionary Dictionary { get; }
    }
}
