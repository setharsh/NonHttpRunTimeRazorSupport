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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Welcome/HtmlBody.cshtml")]
    public partial class HtmlBody : System.Web.Mvc.WebViewPage<EmailDemoTemplates.Models.WelcomeModel>
    {
        public HtmlBody()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Welcome\HtmlBody.cshtml"
  
    Layout = "~/Views/Shared/HtmlLayout.cshtml";

            
            #line default
            #line hidden
WriteLiteral("\r\n<p>Hello ");

            
            #line 5 "..\..\Views\Welcome\HtmlBody.cshtml"
    Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n\r\n<p>Welcome to our website.</p>\r\n<p>Here\'s a list of things that we\'re exc" +
"ited about:</p>\r\n<ul>\r\n    <li>This is nice nice</li>\r\n    <li>This is particula" +
"rly nice</li>\r\n    <li>This is also nice</li>\r\n</ul>\r\n<p>From everybody</p>\r\n");

        }
    }
}
#pragma warning restore 1591
