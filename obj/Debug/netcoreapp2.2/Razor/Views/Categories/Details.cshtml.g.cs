#pragma checksum "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b09bc8e413ba3397789784fe7f1e13855850207"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Details), @"mvc.1.0.view", @"/Views/Categories/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Details.cshtml", typeof(AspNetCore.Views_Categories_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b09bc8e413ba3397789784fe7f1e13855850207", @"/Views/Categories/Details.cshtml")]
    public class Views_Categories_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(61, 38, true);
            WriteLiteral("\n<h2>Category Details</h2>\n<hr />\n<h3>");
            EndContext();
            BeginContext(100, 40, false);
#line 9 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(140, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(143, 36, false);
#line 9 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(179, 7, true);
            WriteLiteral("</h3>\n\n");
            EndContext();
#line 11 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Details.cshtml"
 if(@Model.Items.Count == 0)
{

#line default
#line hidden
            BeginContext(217, 50, true);
            WriteLiteral("  <p>This category does not contain any items</p>\n");
            EndContext();
#line 14 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(276, 47, true);
            WriteLiteral("  <h4>Items the category contains:</h4>\n  <ul>\n");
            EndContext();
#line 19 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Details.cshtml"
   foreach(var join in Model.Items)
  {

#line default
#line hidden
            BeginContext(363, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(372, 21, false);
#line 21 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Details.cshtml"
   Write(join.Item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(393, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 22 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Details.cshtml"
  }

#line default
#line hidden
            BeginContext(403, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 24 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Details.cshtml"
}

#line default
#line hidden
            BeginContext(413, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(418, 46, false);
#line 26 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Details.cshtml"
Write(Html.ActionLink("Back to categories", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(464, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(473, 71, false);
#line 27 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Details.cshtml"
Write(Html.ActionLink("Edit Category", "Edit", new { id = Model.CategoryId }));

#line default
#line hidden
            EndContext();
            BeginContext(544, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(553, 75, false);
#line 28 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Categories/Details.cshtml"
Write(Html.ActionLink("Delete Category", "Delete", new { id = Model.CategoryId }));

#line default
#line hidden
            EndContext();
            BeginContext(628, 4, true);
            WriteLiteral("</p>");
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
