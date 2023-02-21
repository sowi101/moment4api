using Microsoft.EntityFrameworkCore;
using moment4NET.Models;

namespace moment4NET.Data
{
    public class SongListContext : DbContext
    {
        public SongListContext(DbContextOptions<SongListContext> options) : base(options) 
        {
        }

        public DbSet<Song>? Songs { get; set; }

        public DbSet<Genre>? Genres { get; set; }
    }
}
