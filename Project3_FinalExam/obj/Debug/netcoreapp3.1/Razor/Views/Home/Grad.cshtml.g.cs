#pragma checksum "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "083556a4e2d2d899d321cabfef6c1c976be42435"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Grad), @"mvc.1.0.view", @"/Views/Home/Grad.cshtml")]
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
#line 1 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\_ViewImports.cshtml"
using Project3_FinalExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\_ViewImports.cshtml"
using Project3_FinalExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"083556a4e2d2d899d321cabfef6c1c976be42435", @"/Views/Home/Grad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb26fd86b6b4d21c48708c3be3589307986ac32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Grad : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GradMajors>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"myGradDegrees\"  style=\"  background: #edfcf0;\">\r\n");
#nullable restore
#line 4 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
     foreach (var grad in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
         if (grad.degreeName != "graduate advanced certificates")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3");
            BeginWriteAttribute("id", " id=", 219, "", 264, 1);
#nullable restore
#line 8 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
WriteAttributeValue("", 223, String.Concat("myHdng", grad.degreeName), 223, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-width: 1px; border-style:outset;padding:10px\"><b>&#127891;");
#nullable restore
#line 8 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
                                                                                                                                Write(grad.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n");
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=", 377, "", 421, 1);
#nullable restore
#line 10 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
WriteAttributeValue("", 381, String.Concat("myDiv", grad.degreeName), 381, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <b>");
#nullable restore
#line 11 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
              Write(grad.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                <p>");
#nullable restore
#line 12 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
              Write(grad.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <br />\r\n                <ul>\r\n");
#nullable restore
#line 15 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
                     foreach (var conc in grad.concentrations)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h4><li>&#128073;");
#nullable restore
#line 17 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
                                    Write(conc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li></h4>\r\n");
#nullable restore
#line 18 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul><br />\r\n            </div>\r\n");
#nullable restore
#line 22 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3");
            BeginWriteAttribute("id", " id=", 818, "", 863, 1);
#nullable restore
#line 25 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
WriteAttributeValue("", 822, String.Concat("myHdng", grad.degreeName), 822, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"border-width: 1px; border-style:outset;padding:10px\"><b>");
#nullable restore
#line 25 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
                                                                                                                       Write(grad.degreeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3>\r\n            <div");
            BeginWriteAttribute("id", " id=", 970, "", 1014, 1);
#nullable restore
#line 26 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
WriteAttributeValue("", 974, String.Concat("myDiv", grad.degreeName), 974, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <br />\r\n                <ul>\r\n");
#nullable restore
#line 29 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
                     foreach (var ac in grad.availableCertificates)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>");
#nullable restore
#line 31 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
                       Write(ac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 32 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                </ul><br />\r\n            </div>\r\n");
#nullable restore
#line 37 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Grad.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GradMajors>> Html { get; private set; }
    }
}
#pragma warning restore 1591
