#pragma checksum "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Minors.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f02d89764813620be91d96157a2a831586958d4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Minors), @"mvc.1.0.view", @"/Views/Home/Minors.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f02d89764813620be91d96157a2a831586958d4c", @"/Views/Home/Minors.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb26fd86b6b4d21c48708c3be3589307986ac32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Minors : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3_FinalExam.ViewModels.MinorsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f02d89764813620be91d96157a2a831586958d4c4356", async() => {
                WriteLiteral(@"
	<!-- Required meta tags -->
	<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
	<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
	<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
	<link rel=""stylesheet"" href=""assets/css/style-starter.css""> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f02d89764813620be91d96157a2a831586958d4c5716", async() => {
                WriteLiteral(@"
	<!-- top header -->
	<!-- //top header -->
	<!-- inner banner -->
	<section class=""inner-banner py-lg-4 pt-lg-0 pt-5"">
		<div class=""w3l-breadcrumb py-5 mt-lg-0 mt-3"">
			<div class=""container py-xl-5 py-md-4"">
				<h4 class=""inner-text-title font-weight-bold mb-md-2 mb-1"">Minors Offered</h4>
				<ul class=""breadcrumbs-custom-path"">
					<li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f02d89764813620be91d96157a2a831586958d4c6336", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>
					<li class=""active""><span class=""fa fa-chevron-right mx-2"" aria-hidden=""true""></span>Minors</li>
				</ul>
			</div>
		</div>
	</section>
	<!-- //inner banner -->
	<!-- contact -->
	<section class=""w3l-team py-5"" style=""background-color:#ddedd8"">
		<div class=""container py-md-5 py-4"">
			<div class=""title-main text-center mx-auto mb-md-5 mb-4"" style=""max-width:500px;"">
				<h3 class=""title-style"">Explore Various <span>Minors</span>
                </h3> </div>
			<div class=""row team-row pt-lg-3"">
				<!-- end team member -->");
#nullable restore
#line 33 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Minors.cshtml"
                                         for (var i = 0; i
				< Model.Minors.Count; i++) {

#line default
#line hidden
#nullable disable
                WriteLiteral(" <div class=\"col-lg-3 col-sm-6 team-wrap\" style=\"padding-top:20px\">\r\n\t\t\t\t\t<div class=\"team-info\" style=\"min-height:50px\">\r\n\t\t\t\t\t\t<div data-toggle=\"modal\" data-target=");
#nullable restore
#line 36 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Minors.cshtml"
                                                        Write(String.Concat( "#myModal", @Model.Minors[i].name));

#line default
#line hidden
#nullable disable
                WriteLiteral(" class=\"column position-relative img-circle\">\r\n\t\t\t\t\t\t\t<a href=\"#url\"><img");
                BeginWriteAttribute("src", " src=", 1775, "", 1858, 1);
#nullable restore
#line 37 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Minors.cshtml"
WriteAttributeValue("", 1780, String.Concat( "/images/", (@Model.Minors[i].name).Replace( " ", ""), ".jpg"), 1780, 78, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1858, "\"", 1864, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid team-image\" /></a>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"column-btm\">\r\n\t\t\t\t\t\t\t<h3 style=\"text-align: center\" ;>");
#nullable restore
#line 40 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Minors.cshtml"
                                                        Write(Model.Minors[i].name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\t\t\t\t\t\t\t<!-- Modal -->\r\n\t\t\t\t\t\t\t<div class=\"modal fade\"");
                BeginWriteAttribute("id", " id=", 2070, "", 2123, 1);
#nullable restore
#line 42 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Minors.cshtml"
WriteAttributeValue("", 2074, String.Concat( "myModal", @Model.Minors[i].name), 2074, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" role=\"dialog\">\r\n\t\t\t\t\t\t\t\t<div class=\"modal-dialog\" style=\"min-width:45%\">\r\n\t\t\t\t\t\t\t\t\t<!-- Modal content-->\r\n\t\t\t\t\t\t\t\t\t<div class=\"modal-content\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"modal-header\">\r\n\t\t\t\t\t\t\t\t\t\t\t<h2 style=\"text-align: center\">");
#nullable restore
#line 47 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Minors.cshtml"
                                                                      Write(Model.Minors[i].title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n\t\t\t\t\t\t\t\t\t\t\t<button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"modal-body\">\r\n\t\t\t\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 51 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Minors.cshtml"
                                          Write(Model.Minors[i].description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> ");
#nullable restore
#line 51 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Minors.cshtml"
                                                                                 foreach(var cit in @Model.Minors[i].courses){

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t<p style=\"text-align: center\">&#9658;");
#nullable restore
#line 52 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Minors.cshtml"
                                                                            Write(cit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>");
#nullable restore
#line 52 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Minors.cshtml"
                                                                                         }

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </div>
										<div class=""modal-footer flex-center"" style=""padding-right:50%""> <a type=""button"" class=""btn btn-outline-info waves-effect"" data-dismiss=""modal"" style=""font-size:xx-large;height:60px;width:100px"">Close</a> </div>
									</div>
								</div>
							</div>
						</div>
					</div>
			</div> ");
#nullable restore
#line 59 "C:\Users\15853\Downloads\Project3\Project3EnahncedCode\Project3_FinalExam\Views\Home\Minors.cshtml"
                   }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"			<!-- end team member -->
		</div>
		</div>
	</section>
	<!-- //contact -->
	<!-- Js scripts -->
	<!-- move top -->
	<button onclick=""topFunction()"" id=""movetop"" title=""Go to top""> <span class=""fas fa-level-up-alt"" aria-hidden=""true""></span> </button>
	<script>
	// When the user scrolls down 20px from the top of the document, show the button
	window.onscroll = function() {
		scrollFunction()
	};

	function scrollFunction() {
		if(document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
			document.getElementById(""movetop"").style.display = ""block"";
		} else {
			document.getElementById(""movetop"").style.display = ""none"";
		}
	}
	// When the user clicks on the button, scroll to the top of the document
	function topFunction() {
		document.body.scrollTop = 0;
		document.documentElement.scrollTop = 0;
	}
	</script>
	<!-- //move top -->
	<!-- common jquery plugin -->
	<script src=""assets/js/jquery-3.3.1.min.js""></script>
	<!-- //common jquery plugin -->
	<script src");
                WriteLiteral("=\"assets/js/counter.js\"></script>\r\n\t<!-- //MENU-JS -->} ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3_FinalExam.ViewModels.MinorsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591