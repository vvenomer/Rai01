#pragma checksum "C:\Users\pblajer\source\repos\Rai01\Rai01\Views\Friends\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7177ecd775461489ac665c66053a9cbc811ac397"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friends_Index), @"mvc.1.0.view", @"/Views/Friends/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Friends/Index.cshtml", typeof(AspNetCore.Views_Friends_Index))]
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
#line 1 "C:\Users\pblajer\source\repos\Rai01\Rai01\Views\_ViewImports.cshtml"
using Rai01;

#line default
#line hidden
#line 2 "C:\Users\pblajer\source\repos\Rai01\Rai01\Views\_ViewImports.cshtml"
using Rai01.Models;

#line default
#line hidden
#line 3 "C:\Users\pblajer\source\repos\Rai01\Rai01\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7177ecd775461489ac665c66053a9cbc811ac397", @"/Views/Friends/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"156d864741e501fb0cc32ed51b6136af311849a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Friends_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Import", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "C:\Users\pblajer\source\repos\Rai01\Rai01\Views\Friends\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(41, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(48, 17, false);
#line 5 "C:\Users\pblajer\source\repos\Rai01\Rai01\Views\Friends\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(65, 149, true);
            WriteLiteral("</h2>\r\n\r\n<input id=\"friend_login\" onkeyup=\"AddFriend(event)\" />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(215, 20, false);
#line 12 "C:\Users\pblajer\source\repos\Rai01\Rai01\Views\Friends\Index.cshtml"
           Write(Localizer["Friends"]);

#line default
#line hidden
            EndContext();
            BeginContext(235, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(291, 20, false);
#line 15 "C:\Users\pblajer\source\repos\Rai01\Rai01\Views\Friends\Index.cshtml"
           Write(Localizer["Actions"]);

#line default
#line hidden
            EndContext();
            BeginContext(311, 105, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody id=\"friends_list\">\r\n    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(416, 372, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cbfec0d658f4afaa9f1ccb326c8f130", async() => {
                BeginContext(472, 80, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label for=\"file\" class=\"control-label\">");
                EndContext();
                BeginContext(553, 24, false);
#line 24 "C:\Users\pblajer\source\repos\Rai01\Rai01\Views\Friends\Index.cshtml"
                                           Write(Localizer["FriendsList"]);

#line default
#line hidden
                EndContext();
                BeginContext(577, 161, true);
                WriteLiteral("</label>\r\n        <input id=\"file\" name=\"file\" type=\"file\" accept=\"application/json\" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <button type=\"submit\">");
                EndContext();
                BeginContext(739, 19, false);
#line 28 "C:\Users\pblajer\source\repos\Rai01\Rai01\Views\Friends\Index.cshtml"
                         Write(Localizer["Import"]);

#line default
#line hidden
                EndContext();
                BeginContext(758, 23, true);
                WriteLiteral("</button>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(788, 27, true);
            WriteLiteral("\r\n<a href=\"Friends/Export\">");
            EndContext();
            BeginContext(816, 19, false);
#line 31 "C:\Users\pblajer\source\repos\Rai01\Rai01\Views\Friends\Index.cshtml"
                    Write(Localizer["Export"]);

#line default
#line hidden
            EndContext();
            BeginContext(835, 886, true);
            WriteLiteral(@"Export friend list</a>

<script>
    function SendAJAX(httpMethod, url) {
        var ajax = new XMLHttpRequest();
        var promise = new Promise(onResponse =>
            ajax.onreadystatechange = function () {
                if (this.readyState == 4 && this.status == 200) {
                    onResponse(this.responseText);
                }
            });
        ajax.open(httpMethod, url, true);
        ajax.send();
        return promise;
    }
    async function AddFriend(e) {
        if (e.keyCode === 13) {
            var login = document.getElementById(""friend_login"").value;
            var result = await SendAJAX(""POST"", ""Friends/Add/"" + login);
            if (JSON.parse(result)) {
                //alert(""Successfully added friend "" + login + ""!"");
                UpdateList();
            }
            else {
                alert(""");
            EndContext();
            BeginContext(1722, 20, false);
#line 55 "C:\Users\pblajer\source\repos\Rai01\Rai01\Views\Friends\Index.cshtml"
                  Write(Localizer["FailAdd"]);

#line default
#line hidden
            EndContext();
            BeginContext(1742, 370, true);
            WriteLiteral(@" "" + login + ""!"");
            }
        }
    }
    async function DeleteFriend(e) {
        var login = e.target.dataset.login;
        var result = await SendAJAX(""POST"", ""Friends/Del/"" + login);
        if (result) {
            //alert(""Successfully deleted friend "" + login + ""!"");
            UpdateList();
        }
        else {
            alert(""");
            EndContext();
            BeginContext(2113, 23, false);
#line 67 "C:\Users\pblajer\source\repos\Rai01\Rai01\Views\Friends\Index.cshtml"
              Write(Localizer["FailDelete"]);

#line default
#line hidden
            EndContext();
            BeginContext(2136, 376, true);
            WriteLiteral(@" "" + login + ""!"");
        }
    }
    async function UpdateList() {
        var listJson = await SendAJAX(""GET"", ""Friends/List"");
        list = JSON.parse(listJson);
        var htmlResult = """";
        for (var i = 0; i < list.length; i++)
            htmlResult += ""<tr><td>"" + list[i] + ""</td><td><a onclick=\""DeleteFriend(event)\"" data-login=\"""" + list[i] + ""\"">");
            EndContext();
            BeginContext(2513, 19, false);
#line 75 "C:\Users\pblajer\source\repos\Rai01\Rai01\Views\Friends\Index.cshtml"
                                                                                                                        Write(Localizer["Delete"]);

#line default
#line hidden
            EndContext();
            BeginContext(2532, 126, true);
            WriteLiteral("</a></td></tr>\";\r\n        document.getElementById(\"friends_list\").innerHTML = htmlResult;\r\n    }\r\n    UpdateList();\r\n</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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
