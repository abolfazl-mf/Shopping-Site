#pragma checksum "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\course\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "707168a80b8e3b513008a6bb285f8f1af898fa20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_course_Details), @"mvc.1.0.view", @"/Views/course/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"707168a80b8e3b513008a6bb285f8f1af898fa20", @"/Views/course/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f734d5610ba08a879da8c4d4c360a4d8f583063", @"/Views/_ViewImports.cshtml")]
    public class Views_course_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BE.course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-block mt-3 py-2 font-12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("embed-responsive embed-responsive-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\course\Details.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            DefineSection("pre", async() => {
                WriteLiteral(" \r\n    <style>\r\n        #course{\r\n            margin-bottom:3px;\r\n           \r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n\r\n        <div id=\"course\" class=\"col-md-4 mb-3\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 309, "\"", 345, 2);
            WriteAttributeValue("", 315, "/images/course1/", 315, 16, true);
#nullable restore
#line 18 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\course\Details.cshtml"
WriteAttributeValue("", 331, Model.picture, 331, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"HTML\">\r\n            <ul class=\"list-group text-center list-group-flush custom-list-group\">\r\n                <li class=\"list-group-item font-13\">عنوان دوره : ");
#nullable restore
#line 20 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\course\Details.cshtml"
                                                            Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item font-13\">\r\n                    استاد: ");
#nullable restore
#line 22 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\course\Details.cshtml"
                            foreach (var teacher in Model.teacher_Courses)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>");
#nullable restore
#line 24 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\course\Details.cshtml"
                        Write(teacher.teacher.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\course\Details.cshtml"
                                              Write(teacher.teacher.family);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 25 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\course\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\r\n                <li class=\"list-group-item font-13\">زمان : ");
#nullable restore
#line 27 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\course\Details.cshtml"
                                                      Write(Model.totaltime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li class=\"list-group-item font-13\">قیمت دوره : ");
#nullable restore
#line 28 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\course\Details.cshtml"
                                                           Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</li>\r\n            </ul>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "707168a80b8e3b513008a6bb285f8f1af898fa208233", async() => {
                WriteLiteral("<i class=\"fa fa-cart-plus align-middle\"></i> افزودن به سبد خرید");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-courseID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\course\Details.cshtml"
                                                                       WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-courseID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <div class=""col-md-8"">
            <div class=""card mb-3"">
                <div class=""card-header bg-white px-0 course-table"">
                    <ul class=""nav nav-justified pr-0"">
                        <li class=""nav-item""><a href=""#course-info"" class=""nav-link active font-14"" data-toggle=""list"">معرفی دوره</a></li>
                        <li class=""nav-item""><a href=""#comment"" class=""nav-link font-14"" data-toggle=""list"">پرسش و پاسخ دوره</a></li>
                        <li class=""nav-item""><a href=""#teacher-info"" class=""nav-link font-14"" data-toggle=""list"">درباره مدرس</a></li>
                    </ul>
                </div>
                <div class=""card-body"">
                    <div class=""tab-content"">
                        <div class=""tab-pane active"" id=""course-info"">
                            <!-- Start course info -->

                            <h1 class=""mb-3 text-info"">");
#nullable restore
#line 47 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\course\Details.cshtml"
                                                  Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("video", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "707168a80b8e3b513008a6bb285f8f1af898fa2012118", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2238, "~/videos/course/", 2238, 16, true);
#nullable restore
#line 49 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\course\Details.cshtml"
AddHtmlAttributeValue("", 2254, Model.videointro, 2254, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("controls", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            <p class=\"text-justify course-text vazir font-14 my-5\">\r\n                                ");
#nullable restore
#line 52 "D:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\course\Details.cshtml"
                           Write(Model.descript);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>

                            <h6 class=""mb-3 mt-3"">سر فصل ها :</h6>

                            <div class=""mb-2 course-items px-2 py-4 d-flex align-items-center"">
                                <span class=""bg-info count text-center text-white mr-3 font-13"">1</span>
                                <span class=""mr-3 font-13"">ساختار اصلی html - ابزار های مورد نیاز برای یادگیری - معرفی نرم افزار</span>
                            </div>

                            <div class=""mb-2 course-items px-2 py-4 d-flex align-items-center"">
                                <span class=""bg-info count text-center text-white mr-3 font-13"">2</span>
                                <span class=""mr-3 font-13"">آشنایی با تگ ها ، معرفی برخی از تگ ها ، دسته بندی تگ ها ، ساختار تگ های Index </span>
                            </div>

                            <div class=""mb-2 course-items px-2 py-4 d-flex align-items-center"">
                                <span class=""bg-info c");
            WriteLiteral(@"ount text-center text-white mr-3 font-13"">3</span>
                                <span class=""mr-3 font-13"">نرم ا فزار استفاده شده در اموزش ، ایجاد سند ، tag a و tag p و تشریح کد های html - t head body </span>
                            </div>

                            <div class=""mb-2 course-items px-2 py-4 d-flex align-items-center"">
                                <span class=""bg-info count text-center text-white mr-3 font-13"">4</span>
                                <span class=""mr-3 font-13"">آشنایی کامل با اَتریبیوت ها در Html 5 </span>
                            </div>

                            <div class=""mb-2 course-items px-2 py-4 d-flex align-items-center product-link"">
                                <span class=""bg-info count text-center text-white mr-3 font-13"">5</span>
                                <span class=""mr-3 font-13"">کار با متون در html 5 ، تگ p ، تگ h ، تگ span ، تگ hr و بررسی تفاوت ها و کاربرد های مخصوص هر تگ </span>
                            </div>

       ");
            WriteLiteral("                 </div><!-- End course info -->\r\n\r\n                        <div class=\"tab-pane fade\" id=\"comment\">\r\n                            <!-- Start comment -->\r\n");
            WriteLiteral(@"
                            <div class=""bg-light my-3 p-2 pb-4"">
                                <div class=""d-flex align-items-center"">
                                    <p class=""text-danger mb-0 vazir font-13"">arash</p>
                                    <small class=""mx-5 text-muted"">15 تیر 1398</small>
                                </div>
                                <p class=""text-justify my-2 vazir font-13"">آیا آموزش های این دوره تموم شده یا هنوز ادامه داره ؟! </p>

                                <div class="" shadow-sm mr-5 w-75 mt-3 p-2 bg-white"">
                                    <div class=""d-flex align-items-center"">
                                        <p class=""text-danger mb-0 vazir font-13"">Admin</p>
                                        <small class=""mx-5 text-muted"">15 تیر 1398</small>
                                    </div>
                                    <p class=""text-justify my-2 vazir font-13"">سلام بزودی قسمت های جدید آپلود خواهد شد.</p>
            ");
            WriteLiteral(@"                    </div>

                            </div>


                        </div><!-- End comment -->

                        <div class=""tab-pane fade"" id=""teacher-info"">
                            <!-- Start teacher info -->

                            <img src=""images/teacher.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8796, "\"", 8802, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid d-block mx-auto"">

                            <p class=""text-justify mt-5 vazir font-14"">
                                اول داستان، طراح گرافیک بودم و ۲ سالی به عنوان طراح مشغول بودم،
                                بعد به برنامه‌نویسی علاقمند شدم و الان بیشتر
                                از ۱۰ ساله که عاشق کدزنی و چالش‌های پروژه‌های مختلفم. به تدریس علاقه خاصی دارم
                                و دوست دارم دانشی که در این راه بدست آوردم را در اختیار دیگران هم قرار بدم.
                            </p>

                            <table class=""table table-striped table-bordered text-center my-5  font-14"">
                                <tr>
                                    <td>نام مدرس</td>
                                    <td>مقطع تحصیلی</td>
                                    <td>رشته</td>
                                    <td>دانشگاه</td>
                                </tr>
                                <tr>
                                    <td>ع");
            WriteLiteral(@"لی نوروزی</td>
                                    <td>لیسانس</td>
                                    <td>گرافیک</td>
                                    <td>آزاد</td>
                                </tr>
                            </table>

                            <h6 class=""mb-4"">مهارت ها :</h6>

                            <div class=""progress mb-4"">
                                <div class=""progress-bar bg-success"" style=""width: 95%;"">Html (95%)</div>
                            </div>
                            <div class=""progress mb-4"">
                                <div class=""progress-bar bg-success"" style=""width: 98%;"">Css (98%)</div>
                            </div>
                            <div class=""progress mb-4"">
                                <div class=""progress-bar bg-success"" style=""width: 80%;"">Javascript (80%)</div>
                            </div>
                            <div class=""progress mb-4"">
                                <div class=""pr");
            WriteLiteral(@"ogress-bar bg-success"" style=""width: 70%;"">Jquery (70%)</div>
                            </div>

                        </div><!-- End teacher info -->

                    </div>
                </div>
            </div>
        </div>

    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BE.course> Html { get; private set; }
    }
}
#pragma warning restore 1591
