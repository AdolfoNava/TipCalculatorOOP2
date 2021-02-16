using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipCalculator;

namespace Calculator_Tester
{
    [TestClass]
    public class CalculatorTester
    {
        Calculator calculator;

        public CalculatorTester()
        {
            calculator = new Calculator();
        }
        [TestMethod]
        public void TipPercentageRate()
        {
            Calculator c = calculator;
            int tipRateChoice = 1;//insert other values for switchcase
            c.chosenTipRate = c.ChooseTipRate(tipRateChoice);
            Assert.AreEqual(.3,c.chosenTipRate);
            Assert.AreEqual(4, c.tipRateChoice);
        }
        [TestMethod]
        public void ItemPrice()
        {
            Calculator c = calculator;
            int itemsnum = 1;//input values
            c.ItemPrice(itemsnum);
            Assert.AreEqual(24.99 * 10,c.itemPrice);
        }
        [TestMethod]
        public void Calculate()
        {
            Calculator c = calculator;
            double itemAmount;
            double tipAmount;

            itemAmount = c.totalItemPrice;
            tipAmount = c.chosenTipRate;
            double total;
            total = c.Calculate(itemAmount, tipAmount);
            c.grandTotal = c.totalItemPrice + c.tipTotal;
            Assert.AreEqual(total, c.grandTotal);
        }
        [TestMethod]
        public void CalculatorEndResult()
        {
            Calculator c = calculator;
            string EndResultText;

            EndResultText = $"The total price of items is ${c.totalItemPrice}. Your selected tip amount comes to: ${c.tipTotal}. Your new total with tip included is: ${c.grandTotal}.";
            Assert.AreEqual(EndResultText, c.PrintResults());
        }
    }

}
