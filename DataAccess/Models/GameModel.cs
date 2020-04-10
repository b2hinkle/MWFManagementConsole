using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Game { get; set; }

        public string Map { get; set; }

        public int MaxPlayers { get; set; }
    }
}
