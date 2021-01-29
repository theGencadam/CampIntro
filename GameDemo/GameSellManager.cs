using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class GameSellManager
    {
        public void Sell()
        {
            Console.WriteLine("Oyun satışı gerçekleşti");
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add();

        }


    }
}
