using Microsoft.AspNetCore.Mvc;
using BlackJack.Models;

namespace BlackJack.Models
{
    public class HandDisplay : ViewComponent
    {
        public IViewComponentResult Invoke(Hand hand) => View(hand);
    }
}