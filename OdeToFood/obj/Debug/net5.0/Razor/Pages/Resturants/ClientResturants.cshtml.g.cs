#pragma checksum "/Users/Abusdal/ASPNET/OdeToFood/OdeToFood/Pages/Resturants/ClientResturants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b1b4f8ede65dca09bfc2602de77d875c4b32517"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Resturants.Pages_Resturants_ClientResturants), @"mvc.1.0.razor-page", @"/Pages/Resturants/ClientResturants.cshtml")]
namespace OdeToFood.Pages.Resturants
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
#line 1 "/Users/Abusdal/ASPNET/OdeToFood/OdeToFood/Pages/_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b1b4f8ede65dca09bfc2602de77d875c4b32517", @"/Pages/Resturants/ClientResturants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b2f3b51b3673bb472003b5131e3274d92bac785", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Resturants_ClientResturants : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/Abusdal/ASPNET/OdeToFood/OdeToFood/Pages/Resturants/ClientResturants.cshtml"
  
    ViewData["Title"] = "ClientResturants";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Client Resturants</h1>\r\n\r\n<table class=\"table\" id=\"resturants\">\r\n\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/v/bs4-4.1.1/dt-1.10.24/datatables.min.css"" />

<script type=""text/javascript"" src=""https://cdn.datatables.net/v/bs4-4.1.1/dt-1.10.24/datatables.min.js""></script>

<script>
    var cousines = [""Unknown"", ""Mexican"", ""Italian"", ""Indian""];

    $(function () {
        $.ajax(""/api/resturant/"", { method: ""get"" })
            .then(function (response) {
                $(""#resturants"").dataTable({
                    data: response,
                    columns: [
                        { ""data"": ""name"" },
                        { ""data"": ""location"" },
                        {
                            ""data"": ""cousine"", ""render"": function (data) {
                                return cousines[data];
                            }
                        }
                    ]
                });
            });
    });
</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Pages.Resturants.ClientResturantsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Resturants.ClientResturantsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Resturants.ClientResturantsModel>)PageContext?.ViewData;
        public OdeToFood.Pages.Resturants.ClientResturantsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
