﻿//------------------------------------------------------------------------------
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

public class _Page_Views_Shared__LayoutUser_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page_Views_Shared__LayoutUser_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\buiha\AppData\Local\Temp\31019042F66F715AAA201D8E2132C751303B\2\24_news\24_news\Views\Shared\_LayoutUser.cshtml"
                       __o = Html.ActionLink("Đăng nhập", "Dangnhap", "User");


#line default
#line hidden

#line 2 "C:\Users\buiha\AppData\Local\Temp\31019042F66F715AAA201D8E2132C751303B\2\24_news\24_news\Views\Shared\_LayoutUser.cshtml"
                       __o = Html.ActionLink("Đăng ký", "Dangky", "User");


#line default
#line hidden

#line 3 "C:\Users\buiha\AppData\Local\Temp\31019042F66F715AAA201D8E2132C751303B\2\24_news\24_news\Views\Shared\_LayoutUser.cshtml"
   __o = RenderBody();


#line default
#line hidden
}
}
}
