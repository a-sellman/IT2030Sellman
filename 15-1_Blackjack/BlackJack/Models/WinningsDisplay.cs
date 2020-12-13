using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlackJack.Models;

namespace BlackJack.Models

{
    public class WinningsDisplay : ViewComponent
    {
        public WinningsDisplay(IGame g) => this.game = g;

        private IGame game { get; set; }

        public IViewComponentResult Invoke() => View(game.Player.TotalWinnings);
    }
}