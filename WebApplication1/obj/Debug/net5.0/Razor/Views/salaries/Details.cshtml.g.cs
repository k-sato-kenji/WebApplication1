#pragma checksum "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa2fda5a1681f9ada3486b97843388cab5dc9f2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_salaries_Details), @"mvc.1.0.view", @"/Views/salaries/Details.cshtml")]
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
#line 1 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa2fda5a1681f9ada3486b97843388cab5dc9f2b", @"/Views/salaries/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_salaries_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.salary>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>salary</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.beneficiary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayFor(model => model.beneficiary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.paymenttype));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayFor(model => model.paymenttype));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.paymentdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayFor(model => model.paymentdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.paymentamount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayFor(model => model.paymentamount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.travelexpence));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayFor(model => model.travelexpence));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.healthinsurancepremium));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayFor(model => model.healthinsurancepremium));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.welfarepension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayFor(model => model.welfarepension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.employmentinsurancepremium));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayFor(model => model.employmentinsurancepremium));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.incometax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayFor(model => model.incometax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.residenttax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayFor(model => model.residenttax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.totalpaymentamount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayFor(model => model.totalpaymentamount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.overtimeallowance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayFor(model => model.overtimeallowance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.midnightallowance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayFor(model => model.midnightallowance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.holidayallowance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayFor(model => model.holidayallowance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.remarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
       Write(Html.DisplayFor(model => model.remarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa2fda5a1681f9ada3486b97843388cab5dc9f2b14697", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "C:\Users\owner\Desktop\C#特訓\オブジェクト指向\Web\WebApplication1\WebApplication1\Views\salaries\Details.cshtml"
                           WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa2fda5a1681f9ada3486b97843388cab5dc9f2b16864", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.salary> Html { get; private set; }
    }
}
#pragma warning restore 1591
