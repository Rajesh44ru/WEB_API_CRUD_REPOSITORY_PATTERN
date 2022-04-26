using Microsoft.EntityFrameworkCore;

namespace repository_pattern_project.Models.Data
{
    public class PrescriptionDataContext:DbContext
{
        public PrescriptionDataContext(DbContextOptions<PrescriptionDataContext> options) : base(options)
        {

        }

        public DbSet<Prescription> Prescriptions { get; set; }


    }
}
