using _24_news.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _24_news.Models;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using PagedList;
using PagedList.Mvc;

namespace _24_news.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        dbQLTinTucDataContext db = new dbQLTinTucDataContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Dangky()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangky(FormCollection collection, NGUOIDUNG nd)
        {
            var hoten = collection["HotenND"];
            var tendn = collection["TenDN"];
            var matkhau = collection["Matkhau"];
            var matkhaunhaplai = collection["Matkhaunhaplai"];
            var email = collection["Email"];
            var dienthoai = collection["Dienthoai"];
            var ngaysinh = String.Format("{0:dd/MM/yyyy}", collection["Ngaysinh"]);
            if (String.IsNullOrEmpty(hoten))
            {
                ViewData["Loi1"] = "Họ tên người dùng không được để trống";
            }
            else if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi2"] = "Tên đăng nhập không được để trống";
            }  
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi3"] = "Mật khẩu không được để trống";
            }
            else if (String.IsNullOrEmpty (matkhaunhaplai))
            {
                ViewData["Loi4"] = "Mật khẩu nhập lại không được để trống";
            }
            if (String.IsNullOrEmpty(email))
            {
                ViewData["Loi5"] = "Email không được để trống";
            }
            if (String.IsNullOrEmpty(dienthoai))
            {
                ViewData["Loi6"] = "Số điện thoại không được bỏ trống";
            }
            else
            {
                nd.HoTen = hoten;
                nd.TaiKhoan = tendn;
                nd.MatKhau = matkhau;
                nd.Email = email;
                nd.DienThoaiND = dienthoai;
                nd.NgaySinh = DateTime.Parse(ngaysinh);
                db.NGUOIDUNGs.InsertOnSubmit(nd);
                db.SubmitChanges();
                return RedirectToAction("Dangnhap");
            }
            return this.Dangky();
        }
        [HttpGet]
        public ActionResult Dangnhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangnhap(FormCollection collection)
        {
            var tendn = collection["TenDN"];
            var matkhau = collection["Matkhau"];
            if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Tên đăng nhập không được bỏ trống";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Mật khẩu không được bỏ trống";
            }
            else
            {
                NGUOIDUNG nd = db.NGUOIDUNGs.SingleOrDefault(n => n.TaiKhoan == tendn && n.MatKhau == matkhau);
                if (nd != null)
                {
                    ViewBag.ThongBao = "Chúc mừng đăng nhập thành công";
                    Session["Taikhoan"] = nd;
                    return RedirectToAction("Index", "Home");
                }
                else
                    ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            return View();
        }
        public ActionResult TinTuc(int ?page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 7;
            return View(db.TINTUCs.ToList().OrderBy(n => n.MaTinTuc).ToPagedList(pageNumber, pageSize));   
        }
        [HttpGet]
        public ActionResult ThemTinTuc()
        {
            ViewBag.MaCD = new SelectList(db.CHUDEs.ToList().OrderBy(n => n.TenChuDe), "MaCD", "TenChuDe");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemTinTuc(TINTUC tintuc, HttpPostedFileBase fileupload)
        {
            ViewBag.MaCD = new SelectList(db.CHUDEs.ToList().OrderBy(n => n.TenChuDe), "MaCD", "TenChuDe");
            if (fileupload == null)
            {
                ViewBag.ThongBao = "Vui lòng chọn ảnh bìa";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var fileName = Path.GetFileName(fileupload.FileName);
                    var path = Path.Combine(Server.MapPath("~/Images/anhBiaTinTuc/"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        ViewBag.ThongBao = "Hình ảnh đã tồn tại";
                    }
                    else
                    {
                        fileupload.SaveAs(path);
                    }
                    tintuc.AnhBia = fileName;
                    db.TINTUCs.InsertOnSubmit(tintuc);
                    db.SubmitChanges();
                }
                return RedirectToAction("TinTuc");
            }
        }
        [HttpGet]
        public ActionResult XoaTinTuc(int id)
        {
            TINTUC tintuc = db.TINTUCs.SingleOrDefault(n => n.MaTinTuc == id);
            ViewBag.MaTinTuc = tintuc.MaTinTuc;
            if (tintuc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(tintuc);
        }
        [HttpPost, ActionName("XoaTinTuc")]
        public ActionResult XacNhanXoa(int id)
        {
            TINTUC tintuc = db.TINTUCs.SingleOrDefault(n => n.MaTinTuc == id);
            ViewBag.MaTinTuc = tintuc.MaTinTuc;
            if (tintuc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.TINTUCs.DeleteOnSubmit(tintuc);
            db.SubmitChanges();
            return RedirectToAction("TinTuc");
        }
        public ActionResult ChiTietTinTuc(int id)
        {
            TINTUC tintuc = db.TINTUCs.SingleOrDefault(n => n.MaTinTuc == id);
            ViewBag.MaTinTuc = tintuc.MaTinTuc;
            if (tintuc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(tintuc);
        }
        [HttpGet]
        public ActionResult SuaTinTuc(int id)
        {
            TINTUC tintuc = db.TINTUCs.SingleOrDefault(n => n.MaTinTuc == id);
            if (tintuc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ViewBag.MaCD = new SelectList(db.CHUDEs.ToList().OrderBy(n => n.TenChuDe), "MaCD", "TenChuDe");
            return View(tintuc);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SuaTinTuc(TINTUC tintuc, HttpPostedFileBase fileupload)
        {
            ViewBag.MaCD = new SelectList(db.CHUDEs.ToList().OrderBy(n => n.TenChuDe), "MaCD", "TenChuDe");
            if (fileupload == null)
            {
                ViewBag.ThongBao = "Vui lòng chọn ảnh bìa";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var fileName = Path.GetFileName(fileupload.FileName);
                    var path = Path.Combine(Server.MapPath("~/Images/anhBiaTinTuc/"), fileName);
                    if (System.IO.File.Exists(path))
                        ViewBag.ThongBao = "Hình ảnh đã tồn tại";
                    else
                    {
                        fileupload.SaveAs(path);
                    }
                    tintuc.AnhBia = fileName;
                    UpdateModel(tintuc);
                    db.SubmitChanges();
                }
                return RedirectToAction("TinTuc");
            }
        }
    }
}