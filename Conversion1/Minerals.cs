using System;
using System.Drawing.Text;

namespace ChamaBasinMiner
{
    internal class Minerals
    {
        String symbol;
        String name;
        double marketRate;
        int tonnage;
        int min = 1;
        int max = 200;
        public Minerals()
        {
            symbol = "";
            name = "";
            marketRate = setMarketRate();
            tonnage = 0;
        }

        public Minerals(String symbol, String name, int tonnage)
        {
            this.symbol = symbol;
            this.name = name;
            this.tonnage = tonnage;
            marketRate = setMarketRate();
        }

        //SC12
        private double setMarketRate()
        {
            Random r = new Random();

            return Math.Round(r.NextDouble() * 200, 2);
        }
        
        //SC13
        public double getValue()  
        {
            double value = marketRate * tonnage;

            return Math.Round(value, 2);
        }

        //SC14
        public String ToString()  
        {
            return "[Mineral Symbol: " + symbol + "] Mineral Name: " + name + "] [Market $/ton: $" + marketRate +
                "] [Total Tonnage Mined: " + tonnage + "] [Estimated Market Value: $" + getValue() + "]";
        }
    }
}
