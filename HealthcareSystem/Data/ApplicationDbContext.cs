using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Patient>? Patients { get; set; }
    public DbSet<Appointment>? Appointments { get; set; }
    public DbSet<Billing>? Billings { get; set; }
}
