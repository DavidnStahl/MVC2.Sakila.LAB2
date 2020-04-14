#pragma checksum "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43034282f9bac10f91f44592ac5b9d549066ed12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_View), @"mvc.1.0.view", @"/Views/Movie/View.cshtml")]
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
#line 1 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\_ViewImports.cshtml"
using MVC2.Sakila.Lab2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\_ViewImports.cshtml"
using MVC2.Sakila.Lab2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43034282f9bac10f91f44592ac5b9d549066ed12", @"/Views/Movie/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25d5d088cbf183aa7fc0862fa44dd88f1a0373bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC2.Sakila.Lab2.ViewModels.MovieViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Title: ");
#nullable restore
#line 6 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
      Write(Model.movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h4>Description: ");
#nullable restore
#line 7 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
            Write(Model.movie.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>FilmCategory: </h4>\r\n<ul>\r\n");
#nullable restore
#line 10 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
     foreach (var category in Model.movie.FilmCategory)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 12 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
       Write(category.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 13 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<h4>FilmActor:</h4>\r\n<ul>\r\n");
#nullable restore
#line 17 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
     foreach (var actor in Model.movie.FilmActor)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 19 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
   Write(actor.Actor.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 19 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
                          Write(actor.Actor.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 20 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<h4>Inventory: ");
#nullable restore
#line 22 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
          Write(Model.movie.Inventory.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>Release Year ");
#nullable restore
#line 23 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
            Write(Model.movie.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>Language: ");
#nullable restore
#line 24 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
         Write(Model.movie.Language.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>Length: ");
#nullable restore
#line 25 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
       Write(Model.movie.Length.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>Rating: ");
#nullable restore
#line 26 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
       Write(Model.movie.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>SpecialFeatures: ");
#nullable restore
#line 27 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
                Write(Model.movie.SpecialFeatures);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>RentalRate: ");
#nullable restore
#line 28 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
           Write(Model.movie.RentalRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>RentalDuration: ");
#nullable restore
#line 29 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
               Write(Model.movie.RentalDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>ReplacementCost: ");
#nullable restore
#line 30 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
                Write(Model.movie.ReplacementCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<h4>LastUpdate: ");
#nullable restore
#line 31 "C:\Users\dns20\source\repos\MVC2.Sakila.Lab2\MVC2.Sakila.Lab2\Views\Movie\View.cshtml"
           Write(Model.movie.LastUpdate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC2.Sakila.Lab2.ViewModels.MovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591