#pragma checksum "C:\TFS\Demos\DemoIdentityServer\DemoClient\Views\Admin\Secure.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "826ded2a3a7f39ca16be8baf23990f01ca199534"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Secure), @"mvc.1.0.view", @"/Views/Admin/Secure.cshtml")]
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
#line 1 "C:\TFS\Demos\DemoIdentityServer\DemoClient\Views\_ViewImports.cshtml"
using DemoClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\TFS\Demos\DemoIdentityServer\DemoClient\Views\_ViewImports.cshtml"
using DemoClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"826ded2a3a7f39ca16be8baf23990f01ca199534", @"/Views/Admin/Secure.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1de3b656d46759d43b4cc0e594e1643d4d4e69f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Secure : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\TFS\Demos\DemoIdentityServer\DemoClient\Views\Admin\Secure.cshtml"
  
    ViewData["Title"] = "Secure";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 4 "C:\TFS\Demos\DemoIdentityServer\DemoClient\Views\Admin\Secure.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h3>User claims</h3>\r\n<dl>\r\n");
#nullable restore
#line 7 "C:\TFS\Demos\DemoIdentityServer\DemoClient\Views\Admin\Secure.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt>");
#nullable restore
#line 9 "C:\TFS\Demos\DemoIdentityServer\DemoClient\Views\Admin\Secure.cshtml"
       Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd>");
#nullable restore
#line 10 "C:\TFS\Demos\DemoIdentityServer\DemoClient\Views\Admin\Secure.cshtml"
       Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 11 "C:\TFS\Demos\DemoIdentityServer\DemoClient\Views\Admin\Secure.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591