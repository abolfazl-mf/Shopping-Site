#pragma checksum "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Zarinpal\validate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c3c988a3fc047e8abcf691721ef4ba7adc5ad9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zarinpal_validate), @"mvc.1.0.view", @"/Views/Zarinpal/validate.cshtml")]
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
#line 1 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\_ViewImports.cshtml"
using product__easy_learn_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\_ViewImports.cshtml"
using product__easy_learn_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c3c988a3fc047e8abcf691721ef4ba7adc5ad9e", @"/Views/Zarinpal/validate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f734d5610ba08a879da8c4d4c360a4d8f583063", @"/Views/_ViewImports.cshtml")]
    public class Views_Zarinpal_validate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Zarinpal\validate.cshtml"
  
    ViewData["Title"] = "Validate";


#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Zarinpal\validate.cshtml"
 if (ViewBag.Success=true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"text-success\">پرداخت موفق</h1>\r\n    <h2>کد پیگیری:");
#nullable restore
#line 8 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Zarinpal\validate.cshtml"
             Write(ViewBag.refId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 9 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Zarinpal\validate.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"text-danger\">پرداخت ناموفق</h1>\r\n");
#nullable restore
#line 13 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Zarinpal\validate.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
