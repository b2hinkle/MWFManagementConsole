using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class GameInstanceModel
    {
        public int Id { get; set; }
        public string Game { get; set; }
        public string Args { get; set; }
        public string AssociatedServer { get; set; }
    }
}
