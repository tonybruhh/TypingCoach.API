using System.Diagnostics.SymbolStore;
using System.Globalization;
using TypingCoach.Core.Models.BaseModels;

namespace TypingCoach.Core.Models
{
    public class Dictionary : BaseModel
    {
        public Culture Culture { get; }

        public List<Text> Texts { get; }

        public List<TypingResult> TypingResults { get; }
    }
}
