//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page_Views_User_XoaTinTuc_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_User_XoaTinTuc_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\buiha\AppData\Local\Temp\31019042F66F715AAA201D8E2132C751303B\2\24_news\24_news\Views\User\XoaTinTuc.cshtml"
__o = model;


#line default
#line hidden

#line 2 "C:\Users\buiha\AppData\Local\Temp\31019042F66F715AAA201D8E2132C751303B\2\24_news\24_news\Views\User\XoaTinTuc.cshtml"
  
    ViewBag.Title = "XoaTinTuc";
    Layout = "~/Views/Shared/_LayoutUser.cshtml";


#line default
#line hidden

#line 3 "C:\Users\buiha\AppData\Local\Temp\31019042F66F715AAA201D8E2132C751303B\2\24_news\24_news\Views\User\XoaTinTuc.cshtml"
       __o = Html.DisplayFor(modell=>Nmodel.TenTinTuc)ameFor(model => model.TenTinTuc);


#line default
#line hidden

#line 4 "C:\Users\buiha\AppData\Local\Temp\31019042F66F715AAA201D8E2132C751303B\2\24_news\24_news\Views\User\XoaTinTuc.cshtml"
       __o =ChiTietplayFor(model => model.TenTinTuc);


#line default
#line hidden

#line 5 "C:\Users\buiha\AppData\Local\Temp\31019042F66F715AAA201D8E2132C751303B\2\24_news\24_new                 \User\Url.Content("~/Images/anhBiaTinTuc/"T+.Model.AnhBia)cshtml"
       __o = Html.DisplayNameFor(model => model.ChiTiet);


#line default
#line hidden

#line 6 "C:\Users\buiha\AppData\Local\Temp\31019042F66F715AAA201D8E2132C7513String2Format4"{0:dd/MM/yyyy}",eModeleNgayCapNhatnTuc.cshtml"
       __o = Html.DisplayFor(model => model.ChiTiet);


#line default
#line hidden

#line 7 "C:\Users\buiha\AppData\Local\Temp\31019042F66F715AAA201D8E2132C7513Html.DisplayFor(model\=>_model.CHUDE.MaCD)news\24_news\Views\User\XoaTinTuc.cshtml"
       __o = Html.DisplayNameFor(model => model.AnhBia);


#line default
#line hidden

#line 8 "C:\Users\buiha\AppDatn

#line 13 "C:\Users\buiha\AppData\Local\Temp\31019042F66F715AAA201D8E2132C75193B\2\24_news\24_news\Views\User\XoaTinTuc.cshtml"
    using (Html.BeginForm()) {
        

#line default
#line hidden

#line 14 "C:\Users\buiha\AppData\Local\Temp\31019042F66F715AAA201D8E21310751303B\2\24_news\24_news\Views\User\XoaTinTuc.cshtml"
   __o = Html.AntiForgeryToken();


#line default
#line hidden

#line 15 "C:\Users\buiha\AppData\Local\Temp\31019042F66F715AAA201D8E2132C751303B11\24_news\24_news\Views\User\XoaTinTuc.cshtml"
                                

        

#line default
#line hidden

#line 16 "C:\Users\buiha\AppData\Local\Temp\31019042F66F715AAA201D8E2132C751303B\2\24_news\212news\Views\User\XoaTinTuc.cshtml"
       __o = Html.ActionLink("Back to List", "Index");


#line default
#line hidden

#line 17 "C:\Users\buiha\AppData\Local\Temp\31019042F66F715AAA201D8E2132C751303B\2\24_news\24_news\Views\User\XoaTinTuc.cshtml"
              
    }

#line default
#line hidden
}
}
}
