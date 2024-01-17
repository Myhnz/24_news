using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_news.Controllers
{
    public class EmailController : Controller
    {
        private readonly IConfiguration _configuration;

        public EmailController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult SendEmail(string toAddress, string subject, string body)
        {
            try
            {
                using (var smtpClient = new SmtpClient())
                {
                    // Đọc thông tin cấu hình từ file cấu hình
                    var smtpSettings = _configuration.GetSection("SmtpSettings");
                    smtpClient.Host = smtpSettings["SmtpServer"];
                    smtpClient.Port = int.Parse(smtpSettings["SmtpPort"]);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(smtpSettings["SmtpUsername"], smtpSettings["SmtpPassword"]);
                    smtpClient.EnableSsl = true;

                    // Tạo đối tượng MailMessage
                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress("your-email@example.com"),
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = true
                    };

                    // Thêm địa chỉ email nhận vào danh sách nhận
                    mailMessage.To.Add(toAddress);

                    // Gửi Email
                    smtpClient.Send(mailMessage);

                    return Content("Email sent successfully!");
                }
            }
            catch (Exception ex)
            {
                return Content($"Error sending email: {ex.Message}");
            }
        }
    }
}