using System;

namespace CleanArchitecture.Shared.Auditing
{
    public interface IDeletable
    {
        DateTime DeletedAt { get; set; }
    }
}
