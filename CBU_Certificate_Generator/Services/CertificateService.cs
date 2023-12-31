﻿using Amazon.S3;
using CBU_Certificate_Generator.DBContext;
using CBU_Certificate_Generator.Entities;
using Microsoft.EntityFrameworkCore;

namespace CBU_Certificate_Generator.Services
{
    public interface ICertificateService
    {
        Task<List<CertificateTemplate>> GetAllTemplate();
        Task<CertificateTemplate> GetTemplateById(string templateId);
        Task<CertificateTemplate> AddTemplate(CertificateTemplate templateId);
        Task<bool> DeleteTemplateById(string templateId);
        Task<CertificateTemplate> UpdateTemplate (CertificateTemplate certificate, string templateId);
        
    }

    public class CertificateService : ICertificateService
    {
        
        private readonly CertificateDBContext _certificateTemplate;

        public CertificateService(CertificateDBContext certificateTemplate)
        {
            _certificateTemplate = certificateTemplate;
        }

        public async Task<List<CertificateTemplate>> GetAllTemplate()
        {
          return await _certificateTemplate.certificateTemplates.Select(x => x).ToListAsync();
               
        }

        public async Task<CertificateTemplate> GetTemplateById(string templateId)
        {
            return await _certificateTemplate.certificateTemplates.FirstOrDefaultAsync(x => x.TemplateId == templateId);
            

        }

        public async Task<CertificateTemplate> AddTemplate(CertificateTemplate templateId)
        {
            await _certificateTemplate.certificateTemplates.AddAsync(templateId);

            var check = await  _certificateTemplate.SaveChangesAsync();

            if(check > 0)
            {
                return templateId;
            }
            return null;
        }

        public async Task<bool> DeleteTemplateById(string templateId)
        {
           var certificate = await _certificateTemplate.certificateTemplates.FirstOrDefaultAsync(x => x.TemplateId == templateId);
            if(certificate == null)
            {
                return false;
            }

            _certificateTemplate.certificateTemplates.Remove(certificate);

          var saved =  _certificateTemplate.SaveChanges();
            if(saved > 0)
            {
                return true;
            }
            return false;
     
        }

       public async Task<CertificateTemplate> UpdateTemplate(CertificateTemplate certificate, string templateId)
        {
           var check = await _certificateTemplate.certificateTemplates.FirstOrDefaultAsync(x => x.TemplateId == templateId);

            check.CourseName = string.IsNullOrWhiteSpace(certificate.CourseName)? check.CourseName : certificate.CourseName;
            
            _certificateTemplate.Update(certificate);
            _certificateTemplate.SaveChanges();
            return certificate;
        }

    }
}
