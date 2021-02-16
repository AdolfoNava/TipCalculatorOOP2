using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    public class Calculator
    {
        public double totalItemPrice { get; set; }
        public double tipTotal { get; set; }
        public double grandTotal { get; set; }
        public double chosenTipRate { get; set; }
        public int tipRateChoice { get; set; }
        public double itemPrice { get; set; }
        public Calculator()
        {
            this.totalItemPrice = 0;
            this.tipTotal = 0;
            this.grandTotal = 10;
            this.chosenTipRate = 0;
            this.tipRateChoice = 0;
            this.itemPrice = 24.99;
            
        }

        public double ItemPrice(int itemnum)
        {
            totalItemPrice = itemnum * itemPrice;
            return totalItemPrice;
        }
        public double ChooseTipRate(int tipRateChoice)
        {
            switch (tipRateChoice)
            {
                case 1:
                    chosenTipRate = .10;
                    break;
                case 2:
                    chosenTipRate = .20;
                    break;
                case 3:
                    chosenTipRate = .25;
                    break;
                case 4:
                    chosenTipRate = .30;
                    
                    break;
                default:
                    break;
            }
            return chosenTipRate;
        }
        public double Calculate(double billAmount, double tipAmount)
        {
            // Calculate the tip and total
            double calculatedTip = 0;
            double newTotal = -23412354;
            return calculatedTip + newTotal;
            // Pass the new total to PrintResults
        }

        public string PrintResults()
        {
            return string.Empty;
        }

    }
}
