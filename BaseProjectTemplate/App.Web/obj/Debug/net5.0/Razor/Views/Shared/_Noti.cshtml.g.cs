#pragma checksum "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Shared\_Noti.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "92a0101fe1f5ae2792abe954d3b210c0a5db6bbb76bacd6ec0a7a4f6538683ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Noti), @"mvc.1.0.view", @"/Views/Shared/_Noti.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\_ViewImports.cshtml"
using App.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\_ViewImports.cshtml"
using App.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\_ViewImports.cshtml"
using App.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\_ViewImports.cshtml"
using App.Web.WebConfig;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\_ViewImports.cshtml"
using App.Share.Consts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\_ViewImports.cshtml"
using App.Share.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"92a0101fe1f5ae2792abe954d3b210c0a5db6bbb76bacd6ec0a7a4f6538683ee", @"/Views/Shared/_Noti.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a6f7cc5fdcb1c97ac19ee881779b23c9bb030abb37ef9227ed8f862ec329cbbd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Noti : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Shared\_Noti.cshtml"
  
	var typeOfMesg = "";
	var mesg = "";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Shared\_Noti.cshtml"
 if (TempData["Err"] != null)
{
	typeOfMesg = "danger";
	mesg = TempData["Err"].ToString();
}
else if (TempData["Success"] != null)
{
	typeOfMesg = "success";
	mesg = TempData["Success"].ToString();
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Shared\_Noti.cshtml"
 if (!typeOfMesg.IsNullOrEmpty())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div");
            BeginWriteAttribute("class", " class=\"", 303, "\"", 371, 7);
            WriteAttributeValue("", 311, "alert", 311, 5, true);
            WriteAttributeValue(" ", 316, "alert-", 317, 7, true);
#nullable restore
#line 18 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Shared\_Noti.cshtml"
WriteAttributeValue("", 323, typeOfMesg, 323, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 334, "alert-dismissible", 335, 18, true);
            WriteAttributeValue(" ", 352, "js-alert", 353, 9, true);
            WriteAttributeValue(" ", 361, "fade", 362, 5, true);
            WriteAttributeValue(" ", 366, "show", 367, 5, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n\t\t");
#nullable restore
#line 19 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Shared\_Noti.cshtml"
   Write(mesg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n\t\t\t<span aria-hidden=\"true\">&times;</span>\r\n\t\t</button>\r\n\t</div>\r\n");
#nullable restore
#line 24 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Shared\_Noti.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
