#pragma checksum "C:\Users\Kevin\Desktop\WordCounter.Solution\WordCounter\Views\RepeatCounters\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "055f79ad97f00506bfe810e0c20b47a888e31508"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RepeatCounters_Index), @"mvc.1.0.view", @"/Views/RepeatCounters/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RepeatCounters/Index.cshtml", typeof(AspNetCore.Views_RepeatCounters_Index))]
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
#line 5 "C:\Users\Kevin\Desktop\WordCounter.Solution\WordCounter\Views\RepeatCounters\Index.cshtml"
using WordCounter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"055f79ad97f00506bfe810e0c20b47a888e31508", @"/Views/RepeatCounters/Index.cshtml")]
    public class Views_RepeatCounters_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Kevin\Desktop\WordCounter.Solution\WordCounter\Views\RepeatCounters\Index.cshtml"
  
Layout = "_Layout";

#line default
#line hidden
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(58, 32, true);
            WriteLiteral("\r\n<h1>Word Counts</h1>\r\n<ul>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Kevin\Desktop\WordCounter.Solution\WordCounter\Views\RepeatCounters\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(117, 40, true);
            WriteLiteral("  <p>You have no saved word counts</p>\r\n");
            EndContext();
#line 13 "C:\Users\Kevin\Desktop\WordCounter.Solution\WordCounter\Views\RepeatCounters\Index.cshtml"
}

#line default
#line hidden
#line 14 "C:\Users\Kevin\Desktop\WordCounter.Solution\WordCounter\Views\RepeatCounters\Index.cshtml"
 if (Model.Count !=0)
{
  

#line default
#line hidden
#line 16 "C:\Users\Kevin\Desktop\WordCounter.Solution\WordCounter\Views\RepeatCounters\Index.cshtml"
   foreach (RepeatCounter repeatcounter in Model)
  {

#line default
#line hidden
            BeginContext(242, 12, true);
            WriteLiteral("  <li>Word: ");
            EndContext();
            BeginContext(255, 23, false);
#line 18 "C:\Users\Kevin\Desktop\WordCounter.Solution\WordCounter\Views\RepeatCounters\Index.cshtml"
       Write(repeatcounter.GetWord());

#line default
#line hidden
            EndContext();
            BeginContext(278, 19, true);
            WriteLiteral(" <br>\r\n  Sentence: ");
            EndContext();
            BeginContext(298, 27, false);
#line 19 "C:\Users\Kevin\Desktop\WordCounter.Solution\WordCounter\Views\RepeatCounters\Index.cshtml"
       Write(repeatcounter.GetSentence());

#line default
#line hidden
            EndContext();
            BeginContext(325, 20, true);
            WriteLiteral("<br>\r\n  Word Count: ");
            EndContext();
            BeginContext(346, 28, false);
#line 20 "C:\Users\Kevin\Desktop\WordCounter.Solution\WordCounter\Views\RepeatCounters\Index.cshtml"
         Write(repeatcounter.CheckMatches());

#line default
#line hidden
            EndContext();
            BeginContext(374, 15, true);
            WriteLiteral("<br>\r\n  </li>\r\n");
            EndContext();
#line 22 "C:\Users\Kevin\Desktop\WordCounter.Solution\WordCounter\Views\RepeatCounters\Index.cshtml"
  }

#line default
#line hidden
#line 22 "C:\Users\Kevin\Desktop\WordCounter.Solution\WordCounter\Views\RepeatCounters\Index.cshtml"
   
}

#line default
#line hidden
            BeginContext(397, 61, true);
            WriteLiteral("\r\n</ul>\r\n<a href=\"/repeatcounters/new\">Check a new word</a>\r\n");
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
