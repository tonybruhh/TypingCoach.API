namespace TypingCoach.Core.Models.Abstractions
{
    public class Base
    {
        public Guid Id { get; }

        public string Name { get; } = string.Empty;

        public string Description { get; } = string.Empty;

        public DateTime CreatedOn { get; }

        public DateTime UpdatedOn { get; }
    }
}
