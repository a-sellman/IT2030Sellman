using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace BlackJack.Models
{
    [HtmlTargetElement("my-temp-message")]
    public class TempMessageTagHelper : TagHelper
    {
        [ViewContext]
        [HtmlAttributeNotBoundAttribute]
        public ViewContext ViewCtx { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var tempdata = ViewCtx.TempData;

            if (tempdata.ContainsKey("message"))
            {
                string background = tempdata["background"]?.ToString() ?? "info";
                output.BuildTag("h4", $"bg-{background} text-center text-white p-2");
                output.Content.SetContent(tempdata["message"].ToString());
            }
            else
            {
                output.SuppressOutput();
            }
        }
    }
}