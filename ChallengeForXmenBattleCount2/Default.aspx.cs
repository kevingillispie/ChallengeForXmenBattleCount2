using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] xMen = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] count = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            int high = 0;
            int low = 0;

            for (int i = 0; i < xMen.Length; i++)
            {
                if (count[i] > count[high])
                {
                    high = i;
                }
            }

            for (int j = 0; j < xMen.Length; j++)
            {
                if (count[j] < count[low])
                {
                    low = j;
                }
            }

            battleLabel.Text = String.Format("{0} only has {1} battles, but {2} has a whopping {3} battles!", 
                xMen[low], count[low], xMen[high], count[high]);
        }
    }
}