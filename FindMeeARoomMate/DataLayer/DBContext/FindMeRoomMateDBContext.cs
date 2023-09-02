using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMeeARoomMate.DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace FindMeeARoomMate.DataLayer.DBContext
{
    public class FindMeRoomMateDBContext : DbContext
    {
        public FindMeRoomMateDBContext()
        { }
        public FindMeRoomMateDBContext(DbContextOptions<FindMeRoomMateDBContext> options) :
    base(options)
        { }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=WINDOWS-4PGG12B; Initial Catalog=FindMeRoomMateDatabase;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Dormitory> Dormitories { get; set; }
        public DbSet<DormitoryStudent> DormitoryStudents { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Application> Applications { get; set; }

    }
}
    