using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace MegaDesk_3_JeaninaLao
{
    class DeskQuote
    {
        public Desk Desk { get; set; }
        public string CustomerName { get; set; }
        public string RushOption { get; set; }
        public decimal FinalQuote { get; set; }
        public string QuoteDate { get; set; }

        const decimal basePrice = 200.00M;
        const decimal drawerPrice = 50.00M;
        const decimal surfaceAreaPrice = 1.00M;
        const decimal oakPrice = 200.00M;
        const decimal laminatePrice = 100.00M;
        const decimal pinePrice = 50.00M;
        const decimal rosewoodPrice = 300.00M;
        const decimal veneerPrice = 200.00M;

        public decimal GetRushOrder (string rushOrder, int deskSurfaceArea)
        {
            decimal rushOrderRate = 0;
            decimal[,] priceTable = new decimal[3, 3];
            using (StreamReader rushOrderFile = new StreamReader(@"rushOrderPrices.txt"))
            {
                // Thank you CodeGuru for giving us a chance TT^TT
                for (int row = 0; row < 3; row++)
                {
                    for (int column = 0; column < 3; column++)
                    {
                        Decimal.TryParse(rushOrderFile.ReadLine(), out priceTable[row,column]);
                    }
                }

            }

            switch (rushOrder)
            {
                case "3-Day Delivery":
                    if (deskSurfaceArea < 1000)
                    {
                        rushOrderRate = priceTable[0,0];
                    }
                    else if (deskSurfaceArea > 1000 && deskSurfaceArea < 2000)
                    {
                        rushOrderRate = priceTable[0,1];
                    }
                    else if (deskSurfaceArea > 2000)
                    {
                        rushOrderRate = priceTable[0,2];
                    }
                    break;

                case "5-Day Delivery":
                    if (deskSurfaceArea < 1000)
                    {
                        rushOrderRate = priceTable[1, 0];
                    }
                    else if (deskSurfaceArea > 1000 && deskSurfaceArea < 2000)
                    {
                        rushOrderRate = priceTable[1,1];
                    }
                    else if (deskSurfaceArea > 2000)
                    {
                        rushOrderRate = priceTable[1,2];
                    }
                    break;

                case "7-Day Delivery":
                    if (deskSurfaceArea < 1000)
                    {
                        rushOrderRate = priceTable[2,0];
                    }
                    else if (deskSurfaceArea > 1000 && deskSurfaceArea < 2000)
                    {
                        rushOrderRate = priceTable[2,1];
                    }
                    else if (deskSurfaceArea > 2000)
                    {
                        rushOrderRate = priceTable[2,2];
                    }
                    break;

                default:
                    rushOrderRate = 0;
                    break;
            }
            return rushOrderRate;

        }

        public decimal CalcQuote()
        {
            // find surface area of desk
            int surfaceArea = Desk.Depth * Desk.Width;
            decimal surfaceAreaRate = 0;
            decimal materialPrice = 0;
            decimal rushOrderPrice = 0;

            // read rushOrdertxt and place into two dimensional array

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
            rushOrderPrice = GetRushOrder(RushOption, surfaceArea);
           

            decimal quote = basePrice + surfaceAreaRate + drawerNumberRate + materialPrice + rushOrderPrice;
            return quote;
        }

        public void WriteQuote(string customer, string rushOption, decimal finalQuote, string quoteDate)
        {
            
            using (StreamWriter quoteFile = new StreamWriter(@"quotes.txt", append: true))
            {
                quoteFile.WriteLine(customer + ',' + Desk.Width + ',' + Desk.Depth + ',' + Desk.NumberOfDrawers + ',' + Desk.DeskMaterial + ',' + rushOption + ',' + "$" + finalQuote + ',' + quoteDate);
            }
        }

        public void WriteQuote(DeskQuote deskQuote)
        {

           
            var quotesFile = @"quotes.json";
            var deskQuotes = new List<DeskQuote>();

            if (File.Exists(quotesFile))
            {
                using (StreamReader reader = new StreamReader(quotesFile))
                {
                    string quotes = reader.ReadToEnd();
                    if (quotes.Length > 0)
                    {
                        deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    }
                    deskQuotes.Add(deskQuote);
                }
               
            }
            else
            {
                deskQuotes.Add(deskQuote);
            }

            var convertedJson = JsonConvert.SerializeObject(deskQuotes, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(quotesFile, convertedJson);
            
        }
    }
}
