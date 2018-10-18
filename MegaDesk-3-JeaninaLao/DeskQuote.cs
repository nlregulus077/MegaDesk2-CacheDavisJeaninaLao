using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_3_JeaninaLao
{
    class DeskQuote
    {
        public Desk Desk { get; set; }
        public string CustomerName { get; set; }
        public string RushOption { get; set; }
        public decimal FinalQuote { get; set; }

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

        public decimal CalcQuote(string rushOrder)
        {
            // find surface area of desk
            int surfaceArea = Desk.Depth * Desk.Width;
            decimal surfaceAreaRate = 0;
            decimal materialPrice = 0;
            decimal rushOrderPrice = 0;

            // get surface area rate
            if (surfaceArea > 1000)
            {
                surfaceAreaRate = surfaceArea * surfaceAreaPrice;
            }
           

            // get drawer rate
            decimal drawerNumberRate = Desk.NumberOfDrawers * drawerPrice;

            // get material rate
            if (Desk.DeskMaterial == Desk.SurfaceMaterial.Laminate)
            {
                materialPrice = laminatePrice;
            }
            
            else if (Desk.DeskMaterial == Desk.SurfaceMaterial.Oak)
            {
                materialPrice = oakPrice;
            }

            else if (Desk.DeskMaterial == Desk.SurfaceMaterial.Rosewood)
            {
                materialPrice = rosewoodPrice;
            }

            else if (Desk.DeskMaterial == Desk.SurfaceMaterial.Veneer)
            {
                materialPrice = veneerPrice;
            }
            else if (Desk.DeskMaterial == Desk.SurfaceMaterial.Pine)
            {
                materialPrice = pinePrice;
            }

            // get rush order rate
            switch (rushOrder)
            {
                case "3-Day Delivery" :
                    if (surfaceArea < 1000)
                    {
                        rushOrderPrice = threeDayPrice;
                    }
                    else if (surfaceArea > 1000 && surfaceArea < 2000)
                    {
                        rushOrderPrice = threeDayPrice2;
                    }
                    else if (surfaceArea > 2000)
                    {
                        rushOrderPrice = threeDayPrice3;
                    }
                    break;

                case "5-Day Delivery":
                    if (surfaceArea < 1000)
                    {
                        rushOrderPrice = fiveDayPrice;
                    }
                    else if (surfaceArea > 1000 && surfaceArea < 2000)
                    {
                        rushOrderPrice = fiveDayPrice2;
                    }
                    else if (surfaceArea > 2000)
                    {
                        rushOrderPrice = fiveDayPrice3;
                    }
                    break;

                case "7-Day Delivery":
                    if (surfaceArea < 1000)
                    {
                        rushOrderPrice = sevenDayPrice;
                    }
                    else if (surfaceArea > 1000 && surfaceArea < 2000)
                    {
                        rushOrderPrice = sevenDayPrice2;
                    }
                    else if (surfaceArea > 2000)
                    {
                        rushOrderPrice = sevenDayPrice3;
                    }
                    break;

                default:
                    rushOrderPrice = 0;
                    break;
            }

            decimal quote = basePrice + surfaceAreaRate + drawerNumberRate + materialPrice + rushOrderPrice;
            return quote;
        }

        public void WriteQuote(string customer, string rushOption, decimal finalQuote)
        {
            string quoteDate = DateTime.Now.ToString("MM/dd/yyyy");
            using (StreamWriter quoteFile = new StreamWriter(@"quotes.txt", append: true))
            {
                quoteFile.WriteLine(customer + ',' + Desk.Width + ',' + Desk.Depth + ',' + Desk.NumberOfDrawers + ',' + Desk.DeskMaterial + ',' + rushOption + ',' + "$" + finalQuote + ',' + quoteDate);
            }
        }

        public void WriteQuote(DeskQuote deskQuote)
        {
            var quotes = @"quotes.json";
            var list = JsonConvert.DeserializeObject<List<DeskQuote>>(@"quotes.json");
            list.Add(deskQuote);
            var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
        }
    }
}
