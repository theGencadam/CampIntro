using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class CampaignManager : ICampaignandSellService
    {
        public void Add()
        {
            Console.WriteLine("Tebrikler! Oyun satın aldığınız için indirim kampanyası eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Sell()
        {

        }

        public void Update()
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }

}



