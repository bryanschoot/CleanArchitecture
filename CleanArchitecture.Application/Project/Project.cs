using CleanArchitecture.Shared.Auditing;

namespace CleanArchitecture.Application.Project
{
    class Project : AuditingEntity
    {
        public Project(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
    }
}
