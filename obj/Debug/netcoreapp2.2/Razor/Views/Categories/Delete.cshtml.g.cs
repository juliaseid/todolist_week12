#pragma checksum "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a3c5c3597cd1844700923e7d7c5605aef55ba44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Delete), @"mvc.1.0.view", @"/Views/Categories/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Delete.cshtml", typeof(AspNetCore.Views_Categories_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a3c5c3597cd1844700923e7d7c5605aef55ba44", @"/Views/Categories/Delete.cshtml")]
    public class Views_Categories_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 49, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this?</h2>\n\n");
            EndContext();
            BeginContext(110, 40, false);
#line 9 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(150, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(153, 36, false);
#line 9 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Delete.cshtml"
                                      Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(189, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 10 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(218, 43, true);
            WriteLiteral("    <input type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 13 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(264, 46, false);
#line 14 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Delete.cshtml"
Write(Html.ActionLink("Back to categories", "Index"));

#line default
#line hidden
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
