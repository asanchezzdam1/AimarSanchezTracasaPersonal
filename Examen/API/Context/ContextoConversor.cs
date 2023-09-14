using Microsoft.EntityFrameworkCore;
using Entidades;

namespace Context
{
    public class ContextoConversor : DbContext
    {
        public ContextoConversor(DbContextOptions<ContextoConversor> opciones) : base(opciones)
        {
        }        
        public DbSet<Usuario> usuarios { get; set; }
    }
}