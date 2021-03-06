﻿namespace DemoSite.Models {
    using KalikoCMS.Attributes;
    using KalikoCMS.Core;

    /// <summary>
    /// This is a page type for the search page. As you can see there's no properties defined, so the page only uses the builtin ones.
    /// </summary>
    [PageType("SearchPage", "Search page", "~/Templates/Pages/SearchPage.aspx", PageTypeDescription = "Used for search page", PreviewImage = "/Assets/Images/searchpage.png")]
    public class SearchPageType : CmsPage {
    }
}