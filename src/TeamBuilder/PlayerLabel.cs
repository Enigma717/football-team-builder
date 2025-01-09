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

        public int CalculateOverall(int startingOverall, string playerPosition)
        {
            if (
                (playerPosition == "GK" && DefaultPosition != "GK") ||
                (playerPosition != "GK" && DefaultPosition == "GK")) 
            {
                return (int)(startingOverall * 0.8);
            }
            else if (playerPosition == "DEF")
            {
                if (DefaultPosition == "MID")
                    return (int)(startingOverall * 0.95);
                else if (DefaultPosition == "ATT")
                    return (int)(startingOverall * 0.9);
            }
            else if (playerPosition == "MID" && DefaultPosition != "MID")
            {
                return (int)(startingOverall * 0.95);
            }
            else if (playerPosition == "ATT")
            {
                if (DefaultPosition == "DEF")
                    return (int)(startingOverall * 0.9);
                else if (DefaultPosition == "MID")
                    return (int)(startingOverall * 0.95);
            }

            return startingOverall;
        }

        public string DefaultPosition { get; set; }
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
