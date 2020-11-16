using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Lab09.Models
{
    public class GameSession
    {
        public ISession session;

        private const string GameKey = "PigGame";

        public GameSession(ISession session)
        {
            this.session = session;
        }

        public Game GetGame()
        {
            return session.GetObject<Game>(GameKey) ?? new Game();
        }

        public void SetGame(Game game)
        {
            session.SetObject(GameKey, game);
        }
    }
}