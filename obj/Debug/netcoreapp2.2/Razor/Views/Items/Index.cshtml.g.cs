#pragma checksum "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aff1b5a84082177653cb2cfeb1e430c54bd6c2dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Index.cshtml", typeof(AspNetCore.Views_Items_Index))]
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
#line 5 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
using ToDoList.Models;

#line default
#line hidden
#line 6 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aff1b5a84082177653cb2cfeb1e430c54bd6c2dc", @"/Views/Items/Index.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToDoList.Models.Item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(123, 15, true);
            WriteLiteral("\n<h1>Items for ");
            EndContext();
            BeginContext(139, 18, false);
#line 9 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
         Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(157, 7, true);
            WriteLiteral("</h1>\n\n");
            EndContext();
#line 11 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(184, 7, true);
            WriteLiteral("  <ul>\n");
            EndContext();
#line 14 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
     foreach (Item item in Model)
    {

#line default
#line hidden
            BeginContext(231, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(242, 75, false);
#line 16 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
     Write(Html.ActionLink($"{item.Description}", "Details", new { id = item.ItemId }));

#line default
#line hidden
            EndContext();
            BeginContext(317, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 17 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(329, 8, true);
            WriteLiteral("  </ul>\n");
            EndContext();
#line 19 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
} 
else
{

#line default
#line hidden
            BeginContext(347, 41, true);
            WriteLiteral("  <h3>No items have been added yet!</h3>\n");
            EndContext();
#line 23 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
}

#line default
#line hidden
            BeginContext(390, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(395, 41, false);
#line 25 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
Write(Html.ActionLink("Add new item", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(436, 9, true);
            WriteLiteral("</p>\n\n<p>");
            EndContext();
            BeginContext(446, 40, false);
#line 27 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(486, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToDoList.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591