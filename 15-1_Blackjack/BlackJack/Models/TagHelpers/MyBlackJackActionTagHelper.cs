using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using BlackJack.Models;
using Microsoft.AspNetCore.Razor.Runtime;

using Microsoft.AspNetCore.Routing;

namespace BlackJack.Models.TagHelpers
{
    public class MyBlackJackActionTagHelper : TagHelper
    {
        private LinkGenerator linkBuilder;

        public MyBlackJackActionTagHelper(LinkGenerator lg) => this.linkBuilder = lg;

        public string Action { get; set; }

        public bool IsOff { get; set; }

        [ViewContext]
        [HtmlAttributeNotBoundAttribute]
        public ViewContext ViewCtx { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "form";
            output.TagMode = TagMode.StartTagAndEndTag;
            string controller = ViewCtx.RouteData.Values["controller"].ToString();
            string url = linkBuilder.GetPathByAction(this.Action, controller);
            output.Attributes.SetAttribute("action", url);
            output.Attributes.SetAttribute("method", "post");
            output.Attributes.SetAttribute("class", "col");

            TagBuilder button = new TagBuilder("button");
            button.Attributes.Add("type", "submit");
            button.Attributes.Add("class", "btn btn-primary");
            button.InnerHtml.Append(this.Action);

            if (this.IsOff)
            {
                button.Attributes.Add("disabled", "disabled");
            }

            output.Content.AppendHtml(button);
        }
    }
}