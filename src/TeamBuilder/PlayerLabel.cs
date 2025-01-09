using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamBuilder
{
    public sealed class PlayerLabel : Label
    {
        public PlayerLabel()
        {
        }

        public string DefaultText { get; set; }
        public string PlayerName { get; set; }
        public string PlayerPosition { get; set; }
        public string PlayerClub { get; set; }
        public string PlayerLeague { get; set; }
        public string PlayerNationality { get; set; }
        public int PlayerOverall  { get; set; }
        public int PlayerPrice  { get; set; }
        public int PlayerChemistry {  get; set; }
    }
}
