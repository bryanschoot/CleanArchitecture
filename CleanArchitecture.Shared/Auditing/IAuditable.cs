using System;

namespace CleanArchitecture.Shared.Auditing
{
    public interface IAuditable
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
