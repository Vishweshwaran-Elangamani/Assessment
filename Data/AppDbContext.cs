using Microsoft.EntityFrameworkCore;
using PlaylistService.Model;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PlaylistService.Model;
using System.Collections.Generic;

//using Microsoft.EntityFrameworkCore;
//using PlaylistService.Model;
//using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using PlaylistService.Model;
using System.Collections.Generic;


namespace PlaylistServices.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PlaylistItem> PlaylistItems { get; set; }
    }
}
