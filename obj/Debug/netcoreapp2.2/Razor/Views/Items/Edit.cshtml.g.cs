#pragma checksum "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89be9adc7a4a779282238fd4a1b643fffc4c5e98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Edit), @"mvc.1.0.view", @"/Views/Items/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Edit.cshtml", typeof(AspNetCore.Views_Items_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89be9adc7a4a779282238fd4a1b643fffc4c5e98", @"/Views/Items/Edit.cshtml")]
    public class Views_Items_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(56, 36, true);
            WriteLiteral("\n<h2>Edit</h2>\n\n<h4>Edit this task: ");
            EndContext();
            BeginContext(93, 43, false);
#line 9 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Edit.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(136, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(176, 37, false);
#line 13 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Edit.cshtml"
Write(Html.HiddenFor(model => model.ItemId));

#line default
#line hidden
            EndContext();
            BeginContext(220, 41, false);
#line 15 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Edit.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(267, 42, false);
#line 16 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Edit.cshtml"
Write(Html.EditorFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(316, 29, false);
#line 18 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Edit.cshtml"
Write(Html.Label("Select category"));

#line default
#line hidden
            EndContext();
            BeginContext(351, 31, false);
#line 19 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Edit.cshtml"
Write(Html.DropDownList("CategoryId"));

#line default
#line hidden
            EndContext();
            BeginContext(384, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 22 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(427, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(432, 40, false);
#line 24 "/Users/juliaseidman/Documents/Epicodus/Week_12/ToDoList.Solution/ToDoList/Views/Items/Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(472, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591