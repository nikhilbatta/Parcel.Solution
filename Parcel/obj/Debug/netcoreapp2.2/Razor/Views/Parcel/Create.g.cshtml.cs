#pragma checksum "/Users/Guest/Desktop/Parcel.Solution/Parcel/Views/Parcel/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e04d909c959d1ee714c35867fb855817274a5077"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parcel_Create), @"mvc.1.0.view", @"/Views/Parcel/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Parcel/Create.cshtml", typeof(AspNetCore.Views_Parcel_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e04d909c959d1ee714c35867fb855817274a5077", @"/Views/Parcel/Create.cshtml")]
    public class Views_Parcel_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 554, true);
            WriteLiteral(@"<form action=""/singleparcel"" method=""post"">
  <label for=""ParcelHeight"">Add Height of Parcel</label>
 
  <input id=""ParcelHeight"" name=""ParcelHeight"" type=""text"">
  <label for=""Weight"">Add weight off Parcel</label>
  <input id=""ParcelWeight"" name=""ParcelWeight"" type=""text"">
  <label for=""ParcelLength"">Add Length off Parcel</label>
  <input id=""ParcelLength"" name=""ParcelLength"" type=""text"">
  <label for=""ParcelWidth"">Add width off Parcel</label>
  <input id=""ParcelWidth"" name=""ParcelWidth"" type=""text"">
  <button type=""submit"">Submit</button>
</form>");
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