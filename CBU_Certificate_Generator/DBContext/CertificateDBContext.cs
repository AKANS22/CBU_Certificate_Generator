using CBU_Certificate_Generator.Entities;
using Microsoft.EntityFrameworkCore;

namespace CBU_Certificate_Generator.DBContext
{
    public class CertificateDBContext : DbContext
    {
        public CertificateDBContext(DbContextOptions options) : base(options)
        {
            
        }
       public DbSet <CertificateTemplate> certificateTemplates { get; set; }
    }
}
