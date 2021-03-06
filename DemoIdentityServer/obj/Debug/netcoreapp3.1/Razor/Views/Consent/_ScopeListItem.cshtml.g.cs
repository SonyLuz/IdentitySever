#pragma checksum "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1f0b54c6e2920beb4698f4828c7d40178062886"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent__ScopeListItem), @"mvc.1.0.view", @"/Views/Consent/_ScopeListItem.cshtml")]
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
#line 1 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\_ViewImports.cshtml"
using DemoIdentityServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\_ViewImports.cshtml"
using DemoIdentityServer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1f0b54c6e2920beb4698f4828c7d40178062886", @"/Views/Consent/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fecb0430cc7e9f6795eb96628d14bdd1105604f", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DemoIdentityServer.Models.Consent.ScopeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<li class=\"list-group-item\">\r\n    <label>\r\n        <input class=\"consent-scopecheck\"\r\n               type=\"checkbox\"\r\n               name=\"ScopesConsented\"");
            BeginWriteAttribute("id", "\r\n               id=\"", 214, "\"", 253, 2);
            WriteAttributeValue("", 235, "scopes_", 235, 7, true);
#nullable restore
#line 8 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 242, Model.Name, 242, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n               value=\"", 254, "\"", 289, 1);
#nullable restore
#line 9 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 278, Model.Name, 278, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", "\r\n               checked=\"", 290, "\"", 330, 1);
#nullable restore
#line 10 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 316, Model.Checked, 316, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("disabled", "\r\n               disabled=\"", 331, "\"", 373, 1);
#nullable restore
#line 11 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 358, Model.Required, 358, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 12 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\"\r\n                   name=\"ScopesConsented\"");
            BeginWriteAttribute("value", "\r\n                   value=\"", 495, "\"", 534, 1);
#nullable restore
#line 16 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 523, Model.Name, 523, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 17 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong>");
#nullable restore
#line 18 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n");
#nullable restore
#line 19 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\r\n");
#nullable restore
#line 22 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </label>\r\n");
#nullable restore
#line 24 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span><em>(required)</em></span>\r\n");
#nullable restore
#line 27 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"consent-description\">\r\n            <label");
            BeginWriteAttribute("for", " for=\"", 922, "\"", 946, 2);
            WriteAttributeValue("", 928, "scopes_", 928, 7, true);
#nullable restore
#line 31 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
WriteAttributeValue("", 935, Model.Name, 935, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
                                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n        </div>\r\n");
#nullable restore
#line 33 "C:\TFS\Demos\DemoIdentityServer\DemoIdentityServer\Views\Consent\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DemoIdentityServer.Models.Consent.ScopeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
