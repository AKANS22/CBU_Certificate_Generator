using Amazon.S3;
using CBU_Certificate_Generator.Entities;
using CBU_Certificate_Generator.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBU_Certificate_Generator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemplateControllers : ControllerBase
    {
        private readonly ICertificateService certificateService;
       
        public TemplateControllers( ICertificateService certificateService)
        {
            this.certificateService = certificateService;
        }

        [HttpGet("get-template-by-id/{templateId}")]
        public async Task<IActionResult> GetTemplateById(string templateId)
        {
            try
            {
                var Template = await certificateService.GetTemplateById(templateId);
                return Ok(Template);
            }
            catch (Exception e)
            {

                throw;
            }
        }
        [HttpGet("get-all-template")]
        public async Task<IActionResult> GetAllTemplate()
        {
            try
            {
                var allCertificate = await certificateService.GetAllTemplate();
                return Ok(allCertificate);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        [HttpPost("add-template/{templateId}")]
        public async Task<IActionResult> AddTemplate(CertificateTemplate templateId)
        {
            try
            {
                await certificateService.AddTemplate(templateId);
                return Ok();
            }
            catch (Exception e)
            {

                throw;
            }
        }

        [HttpDelete("delete-template-by-id/{templateId}")]
        public async Task<IActionResult> DeleteTemplateById(string templateId)
        {
            try
            {
                var remove = await certificateService.DeleteTemplateById(templateId);
                return Ok(remove);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        [HttpPut("update-template/{templateId}")]
        public async Task<IActionResult> UpdateTemplate (CertificateTemplate certificate, string templateId)
        {
            try
            {
                var change = await certificateService.UpdateTemplate(certificate,templateId);
                return Ok(change);
            }
            catch (Exception e)
            {

                throw;
            }
        }

    }
}
