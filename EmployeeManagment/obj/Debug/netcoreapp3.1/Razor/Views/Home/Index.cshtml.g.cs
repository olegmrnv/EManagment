#pragma checksum "C:\Users\omironov\source\repos\EmployeeManagment\EmployeeManagment\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c148e28cb390e124b4fa0bbfbf387f669e01ac75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\omironov\source\repos\EmployeeManagment\EmployeeManagment\Views\_ViewImports.cshtml"
using EmployeeManagment.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\omironov\source\repos\EmployeeManagment\EmployeeManagment\Views\_ViewImports.cshtml"
using EmployeeManagment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c148e28cb390e124b4fa0bbfbf387f669e01ac75", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"615fb4c34cd2135983ee2f44467720df9a4cf9c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\omironov\source\repos\EmployeeManagment\EmployeeManagment\Views\Home\Index.cshtml"
      
    ViewBag.Title = "Employee List";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <thead>\r\n        <tr>\r\n            <th>ID</th>\r\n            <th>Name</th>\r\n            <th>Department</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 14 "C:\Users\omironov\source\repos\EmployeeManagment\EmployeeManagment\Views\Home\Index.cshtml"
         foreach (var employee in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\omironov\source\repos\EmployeeManagment\EmployeeManagment\Views\Home\Index.cshtml"
               Write(employee.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\omironov\source\repos\EmployeeManagment\EmployeeManagment\Views\Home\Index.cshtml"
               Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\omironov\source\repos\EmployeeManagment\EmployeeManagment\Views\Home\Index.cshtml"
               Write(employee.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 21 "C:\Users\omironov\source\repos\EmployeeManagment\EmployeeManagment\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
