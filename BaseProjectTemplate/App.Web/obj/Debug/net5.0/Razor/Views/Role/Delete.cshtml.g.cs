#pragma checksum "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "28dc0f55614c7ab50325b0572ddd07b935e820a522f7ddbee5e099cef3aead6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Delete), @"mvc.1.0.view", @"/Views/Role/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"28dc0f55614c7ab50325b0572ddd07b935e820a522f7ddbee5e099cef3aead6a", @"/Views/Role/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a6f7cc5fdcb1c97ac19ee881779b23c9bb030abb37ef9227ed8f862ec329cbbd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Role_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.Web.ViewModels.Role.RoleDeleteVM>
    #nullable disable
    {
        private global::AspNetCore.Views_Role_Delete.__Generated__ListRoleViewComponentTagHelper __ListRoleViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bs4-autocomplete/css/bs4-autocomplete.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BackToList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/role/delete-role.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::App.Web.Common.TagHelpers.AppLabelTagHelper __App_Web_Common_TagHelpers_AppLabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
  
	ViewData["Title"] = $"Xác nhận xóa vai trò [{Model.Name}]";

#line default
#line hidden
#nullable disable
            DefineSection("head", async() => {
                WriteLiteral(" \r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28dc0f55614c7ab50325b0572ddd07b935e820a522f7ddbee5e099cef3aead6a8646", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28dc0f55614c7ab50325b0572ddd07b935e820a522f7ddbee5e099cef3aead6a9906", async() => {
                WriteLiteral("\r\n\t<div class=\"row\">\r\n\r\n\t\t<div class=\"col-md-4 col-xl-3\">\r\n\t\t\t<h5>Thông tin vai trò</h5>\r\n\t\t\t<p class=\"small mb-1\">Tạo lúc ");
#nullable restore
#line 15 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
                                     Write(Model.CreatedDate.ToDMYHM());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\t\t\t<p class=\"small mb-2\">Cập nhật lần cuối lúc ");
#nullable restore
#line 16 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
                                                   Write(Model.UpdatedDate.ToDMYHM());

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28dc0f55614c7ab50325b0572ddd07b935e820a522f7ddbee5e099cef3aead6a11034", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 17 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28dc0f55614c7ab50325b0572ddd07b935e820a522f7ddbee5e099cef3aead6a12799", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 18 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t<div class=\"form-group\">\r\n\t\t\t\t<label>Tên vai trò</label>\r\n\t\t\t\t<input class=\"form-control\" readonly");
                BeginWriteAttribute("value", " value=\"", 670, "\"", 689, 1);
#nullable restore
#line 21 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
WriteAttributeValue("", 678, Model.Name, 678, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t</div>\r\n\t\t\t<div class=\"form-group\">\r\n\t\t\t\t<label>Mô tả</label>\r\n\t\t\t\t<input class=\"form-control\" readonly");
                BeginWriteAttribute("value", " value=\"", 801, "\"", 820, 1);
#nullable restore
#line 25 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
WriteAttributeValue("", 809, Model.Desc, 809, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t</div>\r\n\t\t\t<div class=\"form-group\">\r\n\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28dc0f55614c7ab50325b0572ddd07b935e820a522f7ddbee5e099cef3aead6a15702", async() => {
                    WriteLiteral("Vai trò thay thế");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
                __App_Web_Common_TagHelpers_AppLabelTagHelper = CreateTagHelper<global::App.Web.Common.TagHelpers.AppLabelTagHelper>();
                __tagHelperExecutionContext.Add(__App_Web_Common_TagHelpers_AppLabelTagHelper);
#nullable restore
#line 28 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NewId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __App_Web_Common_TagHelpers_AppLabelTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For;
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28dc0f55614c7ab50325b0572ddd07b935e820a522f7ddbee5e099cef3aead6a17678", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:list-role", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28dc0f55614c7ab50325b0572ddd07b935e820a522f7ddbee5e099cef3aead6a17981", async() => {
                    }
                    );
                    __ListRoleViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Role_Delete.__Generated__ListRoleViewComponentTagHelper>();
                    __tagHelperExecutionContext.Add(__ListRoleViewComponentTagHelper);
#nullable restore
#line 30 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
__ListRoleViewComponentTagHelper.seletetedId = null;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("seleteted-id", __ListRoleViewComponentTagHelper.seletetedId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
__ListRoleViewComponentTagHelper.excludeIds = new int[] { Model.Id };

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("exclude-ids", __ListRoleViewComponentTagHelper.excludeIds, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 29 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NewId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28dc0f55614c7ab50325b0572ddd07b935e820a522f7ddbee5e099cef3aead6a21378", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 32 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NewId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t\t<div class=\"col-md-8 col-xl-9\">\r\n\t\t\t<h5>Có ");
#nullable restore
#line 37 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
              Write(Model.AppUsers.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(" tài khoản bị ảnh hưởng</h5>\r\n\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 39 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
                 for (int i = 0; i < Model.AppUsers.Count; i++)
				{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t<div class=\"col-md-6 col-lg-4 col-xl-3\">\r\n\t\t\t\t\t\t<p class=\"hover:text-primary text-bold\">");
#nullable restore
#line 42 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
                                                            Write(i+1);

#line default
#line hidden
#nullable disable
                WriteLiteral(". ");
#nullable restore
#line 42 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
                                                                   Write(Model.AppUsers[i].Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 44 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
				}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\r\n\t\t<div class=\"col-12 text-center\">\r\n\t\t\t<button type=\"button\" class=\"btn btn-danger px-4 js-delete-confirm\" data-mode=\"submit\">\r\n\t\t\t\t<i class=\"fa fa-trash mr-2\"></i> Xóa vai trò này\r\n\t\t\t</button>\r\n\t\t</div>\r\n\t</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28dc0f55614c7ab50325b0572ddd07b935e820a522f7ddbee5e099cef3aead6a26303", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28dc0f55614c7ab50325b0572ddd07b935e820a522f7ddbee5e099cef3aead6a27544", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 59 "C:\Users\Henry-Pham\Documents\GitHub\dotNET_BaseProjectTemplate\BaseProjectTemplate\App.Web\Views\Role\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.Web.ViewModels.Role.RoleDeleteVM> Html { get; private set; } = default!;
        #nullable disable
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:list-role")]
        public class __Generated__ListRoleViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__ListRoleViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.Int32? seletetedId { get; set; }
            public System.Collections.Generic.IEnumerable<System.Int32> excludeIds { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("ListRole", ProcessInvokeAsyncArgs(__context));
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
            private Dictionary<string, object> ProcessInvokeAsyncArgs(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context)
            {
                Dictionary<string, object> args = new Dictionary<string, object>();
                if (__context.AllAttributes.ContainsName("seleteted-id"))
                {
                    args[nameof(seletetedId)] = seletetedId;
                }
                if (__context.AllAttributes.ContainsName("exclude-ids"))
                {
                    args[nameof(excludeIds)] = excludeIds;
                }
                return args;
            }
        }
    }
}
#pragma warning restore 1591