﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmailDemoTemplates.Views.Welcome
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Welcome/PlainTextBody.cshtml")]
    public partial class PlainTextBody : System.Web.Mvc.WebViewPage<EmailDemoTemplates.Models.WelcomeModel>
    {
        public PlainTextBody()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Welcome\PlainTextBody.cshtml"
  
    Layout = "~/Views/Shared/PlainTextLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\nHello ");

            
            #line 5 "..\..\Views\Welcome\PlainTextBody.cshtml"
 Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\nWelcome to our web site\r\n\r\nFrom Everybody");

        }
    }
}
#pragma warning restore 1591
