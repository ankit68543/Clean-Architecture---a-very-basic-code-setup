using CleanArch.Domain.Core.Commands;

namespace CleanArch.Domain.Commands
{
    public abstract class CourseCommand : Command<bool>
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string ImageUrl { get; protected set; }
    }
}
