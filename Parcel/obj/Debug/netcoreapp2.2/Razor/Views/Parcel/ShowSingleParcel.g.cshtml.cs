#pragma checksum "/Users/Guest/Desktop/Parcel.Solution/Parcel/Views/Parcel/ShowSingleParcel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14a7275bd3bcafc261895aae32aa125c9859f81d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parcel_ShowSingleParcel), @"mvc.1.0.view", @"/Views/Parcel/ShowSingleParcel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Parcel/ShowSingleParcel.cshtml", typeof(AspNetCore.Views_Parcel_ShowSingleParcel))]
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
#line 1 "/Users/Guest/Desktop/Parcel.Solution/Parcel/Views/Parcel/ShowSingleParcel.cshtml"
using Shipping.Models;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/Parcel.Solution/Parcel/Views/Parcel/ShowSingleParcel.cshtml"
using System.IO;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14a7275bd3bcafc261895aae32aa125c9859f81d", @"/Views/Parcel/ShowSingleParcel.cshtml")]
    public class Views_Parcel_ShowSingleParcel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 58, true);
            WriteLiteral("\n<h1>Parcel Volume and CostToShip</h1>\n<li> Total Volume: ");
            EndContext();
            BeginContext(101, 18, false);
#line 5 "/Users/Guest/Desktop/Parcel.Solution/Parcel/Views/Parcel/ShowSingleParcel.cshtml"
              Write(Parcel.totalVolume);

#line default
#line hidden
            EndContext();
            BeginContext(119, 24, true);
            WriteLiteral("</li>\n<li> Total Price: ");
            EndContext();
            BeginContext(144, 17, false);
#line 6 "/Users/Guest/Desktop/Parcel.Solution/Parcel/Views/Parcel/ShowSingleParcel.cshtml"
             Write(Parcel.totalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(161, 93, true);
            WriteLiteral("</li>\n\n<a href=\'/parcels/new\'>Add a new parcel</a>\n<a href=\'/parcels\'>See list of parcels</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
