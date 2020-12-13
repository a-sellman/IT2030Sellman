using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using BlackJack.Models;

namespace BlackJack.Models.TagHelpers
{
    [HtmlTargetElement("h5", Attributes = "my-player")]
    [HtmlTargetElement("h5", Attributes = "my-dealer")]
    public class PlayerHeadingTagHelper : TagHelper
    {
        public Dealer MyDealer { get; set; }
        public Player MyPlayer { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string text = string.Empty;
            if (this.MyDealer != null)
            {
                text = MyDealer.MustShowCards ? $"Dealer: {MyDealer.Hand.Total}" : "Dealer";
            }
            else if (this.MyPlayer != null)
            {
                text = MyPlayer.Hand.HasCards ? $"PLayer: {MyPlayer.Hand.Total}" : "Player";
            }

            output.Content.Append(text);
        }
    }
}