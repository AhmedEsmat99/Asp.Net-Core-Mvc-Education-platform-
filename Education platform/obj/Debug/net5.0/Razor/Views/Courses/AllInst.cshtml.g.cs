#pragma checksum "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8184b3c38ba47b29dc748c81e8c489c277a5b88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_AllInst), @"mvc.1.0.view", @"/Views/Courses/AllInst.cshtml")]
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
#line 1 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\_ViewImports.cshtml"
using Education_platform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\_ViewImports.cshtml"
using Education_platform.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\_ViewImports.cshtml"
using Education_platform.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8184b3c38ba47b29dc748c81e8c489c277a5b88", @"/Views/Courses/AllInst.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ac0a5990a95b6b886f8d7b2659a14080988fcf2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Courses_AllInst : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:#007bff"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsDepartment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Courses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
  
    ViewData["Title"] = "AllInst";
    Layout = "_StudentLayout";
	ProjectDb db =new ProjectDb();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("NavbarLinks", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
     if (User.Identity.IsAuthenticated)
	{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t<li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8184b3c38ba47b29dc748c81e8c489c277a5b886201", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n\t\t<li><a href=\"#\">About us</a></li>\r\n\t\t<li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8184b3c38ba47b29dc748c81e8c489c277a5b887688", async() => {
                    WriteLiteral("Courses");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                       WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n\t\t<li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8184b3c38ba47b29dc748c81e8c489c277a5b8810056", async() => {
                    WriteLiteral("Profile");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                                                WriteLiteral(Model.Id);

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
                WriteLiteral("</li>\r\n");
#nullable restore
#line 15 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
	}
	else
	{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t<li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8184b3c38ba47b29dc748c81e8c489c277a5b8812809", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n\t\t<li><a href=\"#\">About us</a></li>\r\n\t\t<li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8184b3c38ba47b29dc748c81e8c489c277a5b8814297", async() => {
                    WriteLiteral("Courses");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n");
#nullable restore
#line 21 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
	}

#line default
#line hidden
#nullable disable
            }
            );
            DefineSection("LinkExist", async() => {
                WriteLiteral("\r\n\tCourses / AllInst\r\n");
            }
            );
            WriteLiteral("<style>\r\n\t.Inst:hover{\r\n\t\ttransition: .5s;\r\n\t\tbox-shadow: 0px 0px 12px 0px #0000003b;\r\n\t}\r\n</style>\r\n<div class=\"row course-items-area\">\r\n");
#nullable restore
#line 33 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
         if (User.Identity.IsAuthenticated)
	{
		

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
         foreach (var item in ViewBag.AllInstInDept as List<Instructor>)
		{
			Department Dept = db.Departments.FirstOrDefault(d=>d.Id == item.IdDept);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"Inst mix col-lg-3 col-md-4 col-sm-6 m-1\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8184b3c38ba47b29dc748c81e8c489c277a5b8816837", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<div class=\"course-item \">\r\n\t\t\t\t\t\t<div class=\"course-thumb set-bg d-flex justify-content-center align-items-end\" data-setbg=\"/image/Department/");
#nullable restore
#line 41 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                                                                                                                Write(Dept.image);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n\t\t\t\t\t\t<div class=\"price position-absolute\" style=\"top:0;left:0;\">Price: Free</div>\r\n\t\t\t\t\t\t<div class=\"text-center\">\r\n\t\t\t\t\t\t\t<img width=\"100\" style=\"height: 6rem;\" class=\"rounded-circle imageinst\"");
                BeginWriteAttribute("src", " src=\"", 1614, "\"", 1649, 2);
                WriteAttributeValue("", 1620, "/image/instructor/", 1620, 18, true);
#nullable restore
#line 44 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
WriteAttributeValue("", 1638, item.Image, 1638, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"course-info\">\r\n\t\t\t\t\t\t\t<div class=\"course-text\">\r\n\t\t\t\t\t\t\t\t<h5>");
#nullable restore
#line 49 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\t\t\t\t\t\t\t\t<p class=\"m-0\" >Courses:</p>\r\n\t\t\t\t\t\t\t\t<div class=\" row\"> \r\n");
#nullable restore
#line 52 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                      var AllCourse = db.InstructorCourses.Where(c => c.InstructorId == item.Id).ToList();

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                     foreach (var courses in AllCourse)
									{
										var Crs = db.Courses.FirstOrDefault(c => c.Id == courses.CoursesId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t<p class=\"m-2 \"> ");
#nullable restore
#line 56 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                                    Write(Crs.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\n");
#nullable restore
#line 57 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
									}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"course-author\">\r\n\t\t\t\t\t\t\t\t<div class=\"ca-pic set-bg\" data-setbg=\"/image/instructor/");
#nullable restore
#line 61 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                                                                    Write(item.Image);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"></div>\r\n\t\t\t\t\t\t\t\t<p><span>");
#nullable restore
#line 62 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                    Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idDept", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                                                                 WriteLiteral(item.IdDept);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idDept"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idDept", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idDept"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idInst"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idInst", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idInst"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                                                                                                                            WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idStd"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idStd", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idStd"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</div>\r\n");
#nullable restore
#line 68 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
         
	}
	else
	{
		

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
         foreach (var item in ViewBag.AllInstInDept as List<Instructor>)
		{
			Department Dept = db.Departments.FirstOrDefault(d=>d.Id == item.IdDept);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"Inst mix col-lg-3 col-md-4 col-sm-6 m-1\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8184b3c38ba47b29dc748c81e8c489c277a5b8825677", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<div class=\"course-item \">\r\n\t\t\t\t\t\t<div class=\"course-thumb set-bg d-flex justify-content-center align-items-end\" data-setbg=\"/image/Department/");
#nullable restore
#line 78 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                                                                                                                Write(Dept.image);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n\t\t\t\t\t\t<div class=\"price position-absolute\" style=\"top:0;left:0;\">Price: Free</div>\r\n\t\t\t\t\t\t<div class=\"text-center\">\r\n\t\t\t\t\t\t\t<img width=\"100\" class=\"rounded-circle\"");
                BeginWriteAttribute("src", " src=\"", 3069, "\"", 3104, 2);
                WriteAttributeValue("", 3075, "/image/instructor/", 3075, 18, true);
#nullable restore
#line 81 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
WriteAttributeValue("", 3093, item.Image, 3093, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"course-info\">\r\n\t\t\t\t\t\t\t<div class=\"course-text\">\r\n\t\t\t\t\t\t\t\t<h5>");
#nullable restore
#line 86 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\t\t\t\t\t\t\t\t<p class=\"m-0\" >Courses:</p>\r\n\t\t\t\t\t\t\t\t<div class=\" row\"> \r\n");
#nullable restore
#line 89 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                      var AllCourse = db.InstructorCourses.Where(c => c.InstructorId == item.Id).ToList();

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                     foreach (var courses in AllCourse)
									{
										var Crs = db.Courses.FirstOrDefault(c => c.Id == courses.CoursesId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t<p class=\"m-2 \"> ");
#nullable restore
#line 93 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                                    Write(Crs.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\n");
#nullable restore
#line 94 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
									}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"course-author\">\r\n\t\t\t\t\t\t\t\t<div class=\"ca-pic set-bg\" data-setbg=\"/image/instructor/");
#nullable restore
#line 98 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                                                                    Write(item.Image);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"></div>\r\n\t\t\t\t\t\t\t\t<p><span>");
#nullable restore
#line 99 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                    Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idDept", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                                                                 WriteLiteral(item.IdDept);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idDept"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idDept", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idDept"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
                                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idInst"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idInst", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idInst"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</div>\r\n");
#nullable restore
#line 105 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\Ahmed Esmat\source\repos\Education platform\Education platform\Views\Courses\AllInst.cshtml"
         
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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