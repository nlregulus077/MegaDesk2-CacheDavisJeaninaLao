﻿using System.Collections.Generic;

namespace MegaDesk_3_JeaninaLao
{
    class DeskQuote
    {
        public Desk desk;

        const decimal basePrice = 200.00M;
        const decimal drawerPrice = 50.00M;
        const decimal surfaceAreaPrice = 1.00M;
        const decimal oakPrice = 200.00M;
        const decimal laminatePrice = 100.00M;
        const decimal pinePrice = 50.00M;
        const decimal rosewoodPrice = 300.00M;
        const decimal veneerPrice = 200.00M;
        const decimal threeDayPrice = 60.00M;
        const decimal threeDayPrice2 = 70.00M;
        const decimal threeDayPrice3 = 80.00M;
        const decimal fiveDayPrice = 40.00M;
        const decimal fiveDayPrice2 = 50.00M;
        const decimal fiveDayPrice3 = 60.00M;
        const decimal sevenDayPrice = 30.00M;
        const decimal sevenDayPrice2 = 35.00M;
        const decimal sevenDayPrice3 = 40.00M;


        public enum RushOrderDelivery
        {
            ThreeDay = 3,
            FiveDay = 5,
            SevenDay = 7,
            NormalShipping = 14

        }

        public void calcQuote()
        {
            // find surface area of desk
            int surfaceArea = desk.Depth * desk.Width;

            // get number of drawers
        }
    }
}
