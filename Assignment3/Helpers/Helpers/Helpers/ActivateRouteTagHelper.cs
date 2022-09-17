using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Helpers.Helpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement(Attributes = "asp-active-route")]
    public class ActivateRouteTagHelper : TagHelper
    {
        [ViewContext]
        public ViewContext ViewContext { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var currentController = ViewContext.RouteData.Values["Controller"].ToString();
            var currentAction = ViewContext.RouteData.Values["Action"].ToString();

            var tagController = context.AllAttributes.First(a => a.Name == "asp-controller").Value.ToString();
            var tagAction = context.AllAttributes.First(a => a.Name == "asp-action").Value.ToString();
            if (currentController == tagController && currentAction == tagAction)
            { 
                var activeClass = context.AllAttributes.First(a => a.Name == "asp-active-route").Value.ToString();
                var existingClass = context.AllAttributes.First(a => a.Name == "class").Value.ToString();
                var css = existingClass + " " + activeClass;
                output.Attributes.SetAttribute("class", css);


            }

        }
    }
}
