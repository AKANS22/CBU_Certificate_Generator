using System.ComponentModel.DataAnnotations;

namespace CBU_Certificate_Generator.Entities
{
    public class CertificateTemplate
    {
        public string CourseName { get; set; }
        [Key]
        public string TemplateId { get; set; }
    }
}
