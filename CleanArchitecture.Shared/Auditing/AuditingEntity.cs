using System;

namespace CleanArchitecture.Shared.Auditing
{
    public class AuditingEntity : BaseEntity, IAuditable, IDeletable
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
