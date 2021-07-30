using CleanArchitecture.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Database
{
    public class Context : DbContext, IUnitOfWork
    {
        public const string DEFAULT_SCHEMA = "context";

        public Context(DbContextOptions options) : base(options)
        {
        }
    }
}
