#pragma checksum "C:\Users\Student\source\repos\RestfulAPI_Ajax\prjAjaxHW\prjAjaxHW\Views\Homework\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "199514d214f46287327dfd244fbbc280909ed8ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Homework_Register), @"mvc.1.0.view", @"/Views/Homework/Register.cshtml")]
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
#line 1 "C:\Users\Student\source\repos\RestfulAPI_Ajax\prjAjaxHW\prjAjaxHW\Views\_ViewImports.cshtml"
using prjAjaxHW;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\source\repos\RestfulAPI_Ajax\prjAjaxHW\prjAjaxHW\Views\_ViewImports.cshtml"
using prjAjaxHW.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"199514d214f46287327dfd244fbbc280909ed8ac", @"/Views/Homework/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d539f95fc664e4a179b612c0a5c0bd8701c5da", @"/Views/_ViewImports.cshtml")]
    public class Views_Homework_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("userInfo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Student\source\repos\RestfulAPI_Ajax\prjAjaxHW\prjAjaxHW\Views\Homework\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Register</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-3\">\r\n    </div>\r\n    <div class=\"col-6\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "199514d214f46287327dfd244fbbc280909ed8ac4660", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"            <div class=""form-group"">
                <label for=""InputName"">姓名</label>
                <input type=""text"" class=""form-control"" id=""InputName"" name=""Name"">
                <small id=""idcheck"" class=""form-text text-muted""></small>
            </div>
            <div class=""form-group"">
                <label for=""InputEmail"">電子郵件</label>
                <input type=""email"" class=""form-control"" id=""InputEmail"" name=""Email"">
            </div>
            <div class=""form-group"">
                <label for=""InputAge"">年紀</label>
                <input type=""number"" class=""form-control"" id=""InputAge"" name=""Age"">
            </div>
            <div class=""form-group"">
                <label for=""InputFile"">選擇檔案</label>
                <input type=""file"" class=""form-control"" id=""InputFile"" name=""File1"">
            </div>
            <button type=""submit"" id=""btns"" class=""btn btn-primary"">送出</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 11 "C:\Users\Student\source\repos\RestfulAPI_Ajax\prjAjaxHW\prjAjaxHW\Views\Homework\Register.cshtml"
AddHtmlAttributeValue("", 230, Url.Content("~/Home/Register"), 230, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"col-3\">\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-3\"></div>\r\n    <div id=\"div1\" class=\"col-6\">123</div>\r\n    <div class=\"col-3\"></div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    const iname = document.querySelector(""#InputName"");
    const btn = document.querySelector(""#btns"");
        const divmsg = document.querySelector(""#div1"")
        const idmsg = document.querySelector(""#idcheck"");

    btn.addEventListener(""click"", evt => {
        
        evt.preventDefault();
        const formdata = new FormData(document.userInfo);
        fetch(document.userInfo.action, {
            method: ""POST"",
            body: formdata,
        })
            .then(response => response.text())
            .then(data => divmsg.textContent = data);
    })

    iname.addEventListener(""blur"", evt => {
        const xhr = new XMLHttpRequest();
        xhr.addEventListener(""load"", () => {
            const data = xhr.responseText;
            idmsg.textContent = data;
        })
        const url = """);
#nullable restore
#line 66 "C:\Users\Student\source\repos\RestfulAPI_Ajax\prjAjaxHW\prjAjaxHW\Views\Homework\Register.cshtml"
                Write(Url.Content("~/Homework/CheckName"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n        const params = `?Name=${iname.value}`;\r\n        xhr.open(\"GET\", url+params);\r\n        xhr.send();\r\n    })\r\n\r\n    </script>\r\n");
            }
            );
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
