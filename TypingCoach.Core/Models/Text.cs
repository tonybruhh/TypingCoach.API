using TypingCoach.Core.Models.BaseModels;

namespace TypingCoach.Core.Models
{
    public class Text
    {
        public string Value { get; } = string.Empty;
        
        public Culture Culture { get; }

        public List<Dictionary> Dictionaries { get; }

        public List<TypingResult> TypingResults { get; }
    }
}
