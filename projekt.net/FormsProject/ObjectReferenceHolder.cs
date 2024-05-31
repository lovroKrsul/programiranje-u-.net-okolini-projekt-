using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace FormsProject
{
    public class ObjectReferenceHolder
    {
        public static Form form1;
        public static Form2 form2;
        public static Panel page1;
        public static Panel page2;
        public static Panel rankingsByMatch;
        public static Panel rankingsByPlayer;
        public static Panel favReps;
        public static DAL.Player[] favPlayers=new DAL.Player[3];
        public static Control DNDsender;
        public static Label DNDsenderStar;
        public static Label DNDsenderName;
        public static Label DNDsenderNum;
        public static Label DNDsenderCap;
        public static string DNDsenderPath;
        public static Label DNDsenderPos;
        public static ContextMenuStrip DNDsenderCMS;
        public static List<player> selected= new List<player>();
        public static List<player> favPlayersList = new List<player>();
        public static List<player> PlayersList = new List<player>();
        public static FlowLayoutPanel flp_players;
        public static FlowLayoutPanel flp_favPlayers;
        public static ContextMenuStrip playerCMS;
        public static Panel settings;
        public static FlowLayoutPanel Flp;
        public static RadioButton langHR;
        public static RadioButton langEN;
        public static RadioButton leagueM;
        public static RadioButton leagueF;
        public static RadioButton fileF;
        public static RadioButton fileW;
    }
}
