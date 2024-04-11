using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingCoach.Core.Models.BaseModels
{
    public class Culture : BaseModel
    {
        public string Language { get; } = "ru-RU";

        public List<Dictionary> Dictionaries { get; }

        public List<Text> Texts { get; }
    }
}
