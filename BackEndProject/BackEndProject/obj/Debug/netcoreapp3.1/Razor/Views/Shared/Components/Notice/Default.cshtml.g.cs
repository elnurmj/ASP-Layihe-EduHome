#pragma checksum "C:\Users\ASUS\Desktop\backendproject-main\BackEndProject\BackEndProject\Views\Shared\Components\Notice\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35411105cd7f91c3322522bc211da4db8a8858f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Notice_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Notice/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\backendproject-main\BackEndProject\BackEndProject\Views\_ViewImports.cshtml"
using BackEndProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\backendproject-main\BackEndProject\BackEndProject\Views\_ViewImports.cshtml"
using BackEndProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\backendproject-main\BackEndProject\BackEndProject\Views\_ViewImports.cshtml"
using BackEndProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\backendproject-main\BackEndProject\BackEndProject\Views\_ViewImports.cshtml"
using BackEndProject.Utilities.Pagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\backendproject-main\BackEndProject\BackEndProject\Views\_ViewImports.cshtml"
using BackEndProject.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35411105cd7f91c3322522bc211da4db8a8858f5", @"/Views/Shared/Components/Notice/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f3e25a66037410b4c9c85a3e85740dce598831b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Notice_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NoticedEvent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\backendproject-main\BackEndProject\BackEndProject\Views\Shared\Components\Notice\Default.cshtml"
 foreach (var noticedEvent in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"single-notice-left mb-23 pb-20\">\n        <h4>");
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\backendproject-main\BackEndProject\BackEndProject\Views\Shared\Components\Notice\Default.cshtml"
       Write(noticedEvent.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        <p>");
#nullable restore
#line 7 "C:\Users\ASUS\Desktop\backendproject-main\BackEndProject\BackEndProject\Views\Shared\Components\Notice\Default.cshtml"
      Write(noticedEvent.EvenetDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n    </div>\n");
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\backendproject-main\BackEndProject\BackEndProject\Views\Shared\Components\Notice\Default.cshtml"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NoticedEvent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
