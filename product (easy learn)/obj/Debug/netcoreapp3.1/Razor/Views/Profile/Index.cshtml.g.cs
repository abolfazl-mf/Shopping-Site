#pragma checksum "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "88f00312d8d683d85bc559ebfceaaba32994fe867de355ef22773f7c70d43dda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
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
#line 1 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\_ViewImports.cshtml"
using product__easy_learn_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\_ViewImports.cshtml"
using product__easy_learn_.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
using BE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"88f00312d8d683d85bc559ebfceaaba32994fe867de355ef22773f7c70d43dda", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de20cf02c31bd1df3f7fa9ab4e54e06e2dbdf63c389217437e3f4630d9568377", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Peyment1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-block mt-3 font-14"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 10 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
         if (ViewBag.SuccessPayment != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 309, "\"", 317, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size:50px;margin-right:10px;\">\r\n                ");
#nullable restore
#line 13 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
           Write(ViewBag.SuccessPayment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 15 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n");
#nullable restore
#line 17 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
              
                var user = await usermanager.FindByNameAsync(User.Identity.Name);
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-12 col-lg-3"">
                <div class=""card bg-info my-5 p-5"">
                    <img src=""images/user.png"" class=""img-fluid rounded-circle d-block mx-auto"" width=""120px"" height=""120px"" alt=""user-image"">
                    <h5 class=""text-white text-center mt-3"">کاربر:");
#nullable restore
#line 23 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
                                                             Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
                                                                             Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                </div>
                <div class=""text-right"">
                    <div class=""list-group p-0 mb-5 profile"">
                        <a href=""#vaziyat"" class=""list-group-item list-group-item-action font-14"" data-toggle=""list""> <i class=""fa fa-cog align-middle ml-2""></i>مرور وضعیت </a>
                        <a href=""#dore-signup"" class=""list-group-item list-group-item-action"" data-toggle=""list""> <i class=""fa fa-server  align-middle ml-2""></i>دوره هایی که ثبت نام کرده اید </a>
                        <a href=""#shopping-cart""");
            BeginWriteAttribute("class", " class=\"", 1471, "\"", 1538, 4);
#nullable restore
#line 29 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
WriteAttributeValue("", 1479, ViewBag.showBasket, 1479, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1498, "list-group-item", 1499, 16, true);
            WriteAttributeValue(" ", 1514, "list-group-item-action", 1515, 23, true);
            WriteAttributeValue(" ", 1537, "", 1538, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" data-toggle=""list""><i class=""fa fa-shopping-cart align-middle ml-2""></i>سبد خرید </a>
                        <a href=""#ticket"" class=""list-group-item list-group-item-action "" data-toggle=""list""><i class=""fa fa-tags align-middle ml-2""></i>تیکت ها </a>
                        <a href=""#user-change"" class=""list-group-item list-group-item-action"" data-toggle=""list""><i class=""fa fa-address-card align-middle ml-2""></i> تغییر مشخصات  </a>
                        <a href=""index.html"" class=""list-group-item list-group-item-action""> <i class="" fa fa-window-close align-middle ml-2""></i> خروج</a>
                    </div>
                </div>
            </div>

            <div class=""col-12 col-lg-9"">

                <div class=""tab-content"">

                    <div class=""tab-pane fade show"" id=""vaziyat"">
                        <!----- Start vaziyat ----->
                        <div class=""card my-5 pb-4 text-right"">
                            <div class=""card-header text-center"">
         ");
            WriteLiteral(@"                       <h6 class=""mt-2""> مرور وضعیت </h6>
                            </div>
                            <div class=""card-body"">
                                <div class=""row"">

                                    <div class=""col-12 col-md-6"">
                                        <div class=""card mb-2"">
                                            <div class=""card-body d-flex justify-content-between align-items-center"">
                                                <img src=""images/university-campus.png"" class=""img-fluid d-inline-block p-2 rounded bg-warning"" alt=""courses"">
                                                <div class=""d-inline-block text-center"">
                                                    <p class=""mb-0""> 12 دوره  </p>
                                                    <small> در سایت وجود دارد </small>
                                                </div>
                                            </div>
                                        </");
            WriteLiteral(@"div>
                                    </div>

                                    <div class=""col-12 col-md-6"">
                                        <div class=""card mb-2"">
                                            <div class=""card-body d-flex justify-content-between align-items-center"">
                                                <img src=""images/a.png"" class=""img-fluid d-inline-block p-2 rounded bg-warning"" alt=""courses"">
                                                <div class=""d-inline-block text-center"">
                                                    <p class=""mb-0""> 3 دوره  </p>
                                                    <small> ثبت نام کرده اید </small>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""col-12 col-md-6"">
                                        <div cla");
            WriteLiteral(@"ss=""card mb-2"">
                                            <div class=""card-body d-flex justify-content-between align-items-center"">
                                                <img src=""images/shopping-cart.png"" class=""img-fluid d-inline-block p-2 rounded bg-warning"" alt=""courses"">
                                                <div class=""d-inline-block text-center"">
                                                    <p class=""mb-0""> 0 دوره  </p>
                                                    <small>  در انتظار پرداخت  </small>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""col-12 col-md-6"">
                                        <div class=""card mb-2"">
                                            <div class=""card-body d-flex justify-content-between align-items-center"">
                 ");
            WriteLiteral(@"                               <img src=""images/wallet-filled-money-tool.png"" class=""img-fluid d-inline-block p-2 rounded bg-warning"" alt=""courses"">
                                                <div class=""d-inline-block text-center"">
                                                    <p class=""mb-0"">  0 تومان   </p>
                                                    <small>  موجودی قابل تسویه شما  </small>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""col-12"">
                                        <div class=""card mt-3"">
                                            <div class=""card-body bg-light"">
                                                <p class=""mb-2""> <i class=""fa fa-bell align-middle""></i>  جدیدترین اعلان ها  </p>
                                                <small> در تاریخ 1398/");
            WriteLiteral(@"01/25 </small>
                                                <div class=""alert alert-info mt-3"">
                                                    <p class=""font-13 text-center mt-3"">کد تخفیف 30 % : Takhfif</p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>

                        </div>
                    </div><!----- End vaziyat ----->


                    <div class=""tab-pane fade show text-center"" id=""dore-signup"">
                        <!----- Start dore signup ----->
                        <div class=""card my-5 pb-4 text-center"">
                            <div class=""card-header"">
                                <h6 class=""mt-2 font-14""> دوره هایی که ثبت نام کرده اید  </h6>
                            </div>
                            <div class=""ca");
            WriteLiteral(@"rd-body"">

                                <div class=""card mb-3 pb-4 shadow-sm"">
                                    <div class=""card-body d-md-flex"">
                                        <img src=""images/html-2.png"" class=""img-fluid float-lg-right mb-2"" alt=""html"" width=""250px"" height=""300px"">
                                        <div class=""d-inline-block pr-3 text-justify my-course"">
                                            <a href=""Category.html"" class=""mb-3 d-block text-center text-dark"">آموزش HTML</a>
                                            <small>
                                                بخش اول متخصص طراحی سایت :
                                                زبان نشانه گذاری HTML به عنوان اولین پایه برای هر دوره آموزش طراحی سایت در نظر گرفته می‌شود.
                                                این زبان چیست و چه کاربردی دارد؟ HTML مخفف عبارت Hypertext Markup Language است.
                                            </small>
                                        ");
            WriteLiteral(@"    <button class=""btn btn-primary rounded-pill float-left mt-3 font-12"" data-toggle=""collapse"" data-target=""#download1"">مشاهده لینک دانلود</button>

                                        </div>
                                    </div>
                                    <div class=""mt-5 collapse"" id=""download1"">
                                        <table class=""table table-borderless text-right font-13"">
                                            <tr>
                                                <td>آموزش HTML جلسه 1 - 3</td>
                                                <td><button class=""btn btn-success float-left font-12""><i class=""fa fa-download align-middle ml-2""></i>دانلود</button></td>
                                            </tr>
                                            <tr>
                                                <td>آموزش HTML جلسه 3 - 6</td>
                                                <td><button class=""btn btn-success float-left font-12""><i class=""fa f");
            WriteLiteral(@"a-download align-middle ml-2""></i>دانلود</button></td>
                                            </tr>
                                            <tr>
                                                <td>آموزش HTML جلسه 7 - 10</td>
                                                <td><button class=""btn btn-success float-left font-12""><i class=""fa fa-download align-middle ml-2""></i>دانلود</button></td>
                                            </tr>
                                            <tr>
                                                <td>آموزش HTML جلسه 11 - 13</td>
                                                <td><button class=""btn btn-success float-left font-12""><i class=""fa fa-download align-middle ml-2""></i>دانلود</button></td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>

                                <div class=""card mb-3 pb-4 shadow-sm"">");
            WriteLiteral(@"
                                    <div class=""card-body d-md-flex"">
                                        <img src=""images/html-2.png"" class=""img-fluid float-lg-right mb-2"" alt=""html"" width=""250px"" height=""300px"">
                                        <div class=""d-inline-block pr-3 text-justify my-course"">
                                            <a href=""Category.html"" class=""mb-3 d-block text-center text-dark"">آموزش HTML</a>
                                            <small>
                                                بخش اول متخصص طراحی سایت :
                                                زبان نشانه گذاری HTML به عنوان اولین پایه برای هر دوره آموزش طراحی سایت در نظر گرفته می‌شود.
                                                این زبان چیست و چه کاربردی دارد؟ HTML مخفف عبارت Hypertext Markup Language است.
                                            </small>
                                            <button class=""btn btn-primary rounded-pill float-left mt-3 font-12"" data-toggl");
            WriteLiteral(@"e=""collapse"" data-target=""#download2"">مشاهده لینک دانلود</button>

                                        </div>
                                    </div>
                                    <div class=""mt-5 collapse"" id=""download2"">
                                        <table class=""table table-borderless text-right font-13"">
                                            <tr>
                                                <td>آموزش HTML جلسه 1 - 3</td>
                                                <td><button class=""btn btn-success float-left font-12""><i class=""fa fa-download align-middle ml-2""></i>دانلود</button></td>
                                            </tr>
                                            <tr>
                                                <td>آموزش HTML جلسه 3 - 6</td>
                                                <td><button class=""btn btn-success float-left font-12""><i class=""fa fa-download align-middle ml-2""></i>دانلود</button></td>
                           ");
            WriteLiteral(@"                 </tr>
                                            <tr>
                                                <td>آموزش HTML جلسه 7 - 10</td>
                                                <td><button class=""btn btn-success float-left font-12""><i class=""fa fa-download align-middle ml-2""></i>دانلود</button></td>
                                            </tr>
                                            <tr>
                                                <td>آموزش HTML جلسه 11 - 13</td>
                                                <td><button class=""btn btn-success float-left font-12""><i class=""fa fa-download align-middle ml-2""></i>دانلود</button></td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>


                                <div class=""card mb-3 pb-4 shadow-sm"">
                                    <div class=""card-body d-md-flex"">
        ");
            WriteLiteral(@"                                <img src=""images/html-2.png"" class=""img-fluid float-lg-right mb-2"" alt=""html"" width=""250px"" height=""300px"">
                                        <div class=""d-inline-block pr-3 text-justify my-course"">
                                            <a href=""Category.html"" class=""mb-3 d-block text-center text-dark"">آموزش HTML</a>
                                            <small>
                                                بخش اول متخصص طراحی سایت :
                                                زبان نشانه گذاری HTML به عنوان اولین پایه برای هر دوره آموزش طراحی سایت در نظر گرفته می‌شود.
                                                این زبان چیست و چه کاربردی دارد؟ HTML مخفف عبارت Hypertext Markup Language است.
                                            </small>
                                            <button class=""btn btn-primary rounded-pill float-left mt-3 font-12"" data-toggle=""collapse"" data-target=""#download3"">مشاهده لینک دانلود</button>

            ");
            WriteLiteral(@"                            </div>
                                    </div>
                                    <div class=""mt-5 collapse"" id=""download3"">
                                        <table class=""table table-borderless text-right font-13"">
                                            <tr>
                                                <td>آموزش HTML جلسه 1 - 3</td>
                                                <td><button class=""btn btn-success float-left font-12""><i class=""fa fa-download align-middle ml-2""></i>دانلود</button></td>
                                            </tr>
                                            <tr>
                                                <td>آموزش HTML جلسه 3 - 6</td>
                                                <td><button class=""btn btn-success float-left font-12""><i class=""fa fa-download align-middle ml-2""></i>دانلود</button></td>
                                            </tr>
                                            <tr>
       ");
            WriteLiteral(@"                                         <td>آموزش HTML جلسه 7 - 10</td>
                                                <td><button class=""btn btn-success float-left font-12""><i class=""fa fa-download align-middle ml-2""></i>دانلود</button></td>
                                            </tr>
                                            <tr>
                                                <td>آموزش HTML جلسه 11 - 13</td>
                                                <td><button class=""btn btn-success float-left font-12""><i class=""fa fa-download align-middle ml-2""></i>دانلود</button></td>
                                            </tr>
                                        </table>
                                    </div>
                                </div>


                            </div>
                        </div>
                    </div><!----- End dore signup ----->


                    <div");
            BeginWriteAttribute("class", " class=\"", 16821, "\"", 16879, 5);
            WriteAttributeValue("", 16829, "tab-pane", 16829, 8, true);
            WriteAttributeValue(" ", 16837, "fade", 16838, 5, true);
            WriteAttributeValue(" ", 16842, "show", 16843, 5, true);
            WriteAttributeValue(" ", 16847, "text-center", 16848, 12, true);
#nullable restore
#line 240 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
WriteAttributeValue(" ", 16859, ViewBag.showBasket, 16860, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"shopping-cart\">\r\n                        <!----- Start shopping cart----->\r\n\r\n");
#nullable restore
#line 243 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
                          
                            var courseIds = new List<int>();
                            if (httpcontextaccessor.HttpContext.Session.GetString("basket") != null)
                            {
                                courseIds = JsonConvert.DeserializeObject<List<int>>(httpcontextaccessor.HttpContext.Session.GetString("basket"));
                            }
                            var blc = new BLL.blcourse();
                            var courses = blc.serachById(courseIds);
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""card my-5 pb-4 text-center"">

                            <div class=""card-header"">
                                <h6>سبد خرید</h6>
                            </div>

                            <div class=""card-body mt-5"">

                                <div class=""table-responsive"">
                                    <table id=""myTable"" class=""table"">
                                        <thead>
                                            <tr>
                                                <th>عکس</th>
                                                <th>نام دوره</th>
                                                <th>تعداد دوره</th>
                                                <th>قیمت دوره</th>
                                                <th>قیمت کل</th>

                                            </tr>
                                        </thead>
                                        <tbody>

");
#nullable restore
#line 275 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
                                             foreach (var item in courses)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <tr>
                                                    <td>
                                                        <div class=""product-img"">
                                                            <div class=""img-prdct""><img");
            BeginWriteAttribute("src", " src=\"", 18921, "\"", 18956, 2);
            WriteAttributeValue("", 18927, "/images/course1/", 18927, 16, true);
#nullable restore
#line 280 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
WriteAttributeValue("", 18943, item.picture, 18943, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                                        </div>\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        <p>");
#nullable restore
#line 284 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
                                                      Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                    </td>
                                                    <td>
                                                        <div class=""button-container"">
                                                            <button class=""cart-qty-plus"" type=""button"" value=""+"">+</button>
                                                            <input type=""text"" name=""qty"" min=""0"" class=""qty form-control"" value=""1"" />
                                                            <button class=""cart-qty-minus"" type=""button"" value=""-"">-</button>
                                                        </div>
                                                    </td>
                                                    <td>
                                                        <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 20073, "\"", 20092, 1);
#nullable restore
#line 294 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"
WriteAttributeValue("", 20081, item.price, 20081, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""price form-control"" disabled>
                                                    </td>
                                                    <td> <span id=""amount"" class=""amount"">0</span>تومان</td>

                                                </tr>
");
#nullable restore
#line 299 "E:\Users\PGSHCO\source\repos\product (easy learn)\product (easy learn)\Views\Profile\Index.cshtml"

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </tbody>
                                    </table>

                                    <span class=""font-13"">قیمت کل :</span><span id=""total"" class=""total mx-2"">0</span><span class=""font-13"">تومان</span>

                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88f00312d8d683d85bc559ebfceaaba32994fe867de355ef22773f7c70d43dda30938", async() => {
                WriteLiteral(" پرداخت");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                </div>\r\n\r\n                            </div>\r\n\r\n\r\n                        </div>\r\n\r\n                    </div><!----- End shopping cart ----->\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<UserApp> usermanager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor httpcontextaccessor { get; private set; } = default!;
        #nullable disable
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
