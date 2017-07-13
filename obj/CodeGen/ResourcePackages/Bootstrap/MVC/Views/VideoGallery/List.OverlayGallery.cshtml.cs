#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.VideoGallery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.VideoGallery;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/VideoGallery/List.OverlayGallery.cshtml")]
    public partial class List_OverlayGallery : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_OverlayGallery()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
Write(Html.StyleSheet(Url.WidgetContent("assets/magnific/magnific-popup.css"), "head", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
Write(Html.Script(Url.WidgetContent("assets/magnific/jquery.magnific-popup.min.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 11 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/VideoGallery/overlay-gallery.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteLiteral(" class=\"sf-Gallery-thumbs-container\"");

WriteLiteral(">\n    <div");

WriteAttribute("class", Tuple.Create(" class=\"", 629), Tuple.Create("\"", 704)
, Tuple.Create(Tuple.Create("", 637), Tuple.Create("sf-Gallery-thumbs", 637), true)
, Tuple.Create(Tuple.Create(" ", 654), Tuple.Create("sf-Gallery-thumbs--video", 655), true)
, Tuple.Create(Tuple.Create(" ", 679), Tuple.Create("clearfix", 680), true)
            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create(" ", 688), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 689), false)
);

WriteLiteral(">\n    \n");

            
            #line 16 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
        
            
            #line default
            #line hidden
            
            #line 16 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
         foreach (var item in Model.Items)
        {
            var title = item.Fields.Title;
            var alternativeText = System.Text.RegularExpressions.Regex.Replace(title, @"[^\w\d_-]", "");

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">\n            <a");

WriteLiteral(" class=\"video-link\"");

WriteAttribute("href", Tuple.Create("\n                href=\"", 978), Tuple.Create("\"", 1022)
            
            #line 22 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1001), Tuple.Create<System.Object, System.Int32>(item.Fields.MediaUrl
            
            #line default
            #line hidden
, 1001), false)
);

WriteAttribute("title", Tuple.Create("\n                title=\"", 1023), Tuple.Create("\"", 1063)
            
            #line 23 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1047), Tuple.Create<System.Object, System.Int32>(alternativeText
            
            #line default
            #line hidden
, 1047), false)
);

WriteLiteral(">\n\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1087), Tuple.Create("\"", 1140)
            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1093), Tuple.Create<System.Object, System.Int32>(((VideoThumbnailViewModel)item).ThumbnailUrl
            
            #line default
            #line hidden
, 1093), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 1141), Tuple.Create("\"", 1163)
            
            #line 25 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1147), Tuple.Create<System.Object, System.Int32>(alternativeText
            
            #line default
            #line hidden
, 1147), false)
);

WriteLiteral(" \n                    data-detail-url=\"");

            
            #line 26 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
                                Write(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" />\n            </a>\n            <h3>");

            
            #line 28 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
           Write(title);

            
            #line default
            #line hidden
WriteLiteral("</h3>\n        </div>\n");

            
            #line 30 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"

        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\n</div>\n\n");

            
            #line 35 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 37 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 42 "..\..\ResourcePackages\Bootstrap\MVC\Views\VideoGallery\List.OverlayGallery.cshtml"
         
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
