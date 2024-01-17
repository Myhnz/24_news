using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_news.Controllers
{
    public class ActionController : Controller
    {
        // Action để hiển thị form quên mật khẩu 
        // GET: Action
        public ActionResult ForgotPassword()
        {
            return View();
        }
        // Action để xử lý quên mật khẩu
        [HttpPost]
        public ActionResult ForgotPassword(string email)
        {
            // Kiểm tra xem email có tồn tại trong hệ thống hay không
            // Nếu có, gửi email xác nhận
            // Gọi phương thức để gửi email xác nhận
            // Redirect hoặc hiển thị thông báo tùy thuộc vào
        }
    }
    public IActionResult ForgotPassword(string email)
    {
        // Kiểm tra và lấy thông tin người dùng từ cơ sở dữ liệu

        // Tạo token và lưu vào cơ sở dữ liệu

        // Gửi email xác nhận
        var confirmationLink = Url.Action("ResetPassword", "Account", new { userId = userId, token = token }, protocol: HttpContext.Request.Scheme);
        var emailBody = $"Click the link to reset your password: {confirmationLink}";

        // Gọi phương thức gửi email
        return SendEmail(email, "Password Reset", emailBody);
    }

}