using BikeDistributor.Discount;
using System.Collections.Generic;
using System.Text;

namespace BikeDistributor.Receipt
{
    public class ReceiptFormat
    {
        public readonly StringBuilder receipt = new StringBuilder();
        private double totalAmount;
        public double Tax { get; set; }

        public virtual void CompanyOrder(string company)
        {
            receipt.Append($"Order Receipt for {company}");
        }

        public virtual void CompanyLine(IList<Line> line, DiscountRule DRule){}

        public virtual void CompanyLine(Line line, DiscountRule DRule)
        {
            totalAmount += DRule.DiscountAmount;
            receipt.Append($"{line.Quantity} x {line.Bike.Brand} {line.Bike.Model} = {DRule.DiscountAmount.ToString("C")}");
        }

        public virtual void SubTotal()
        {
            receipt.Append($"Sub-Total: {totalAmount.ToString("C")}");
        }

        public virtual void TaxInfo(double taxRate)
        {
            Tax = totalAmount * taxRate;
            receipt.Append($"Tax: {Tax.ToString("C")}");
        }

        public virtual void Total()
        {
            receipt.Append($"Total: {(totalAmount + Tax).ToString("C")}");
        }

        public virtual string FinalReceipt(string company, IList<Line> lines, double taxrate, DiscountRule dRule)
        {
            CompanyOrder(company);
            CompanyLine(lines, dRule);
            SubTotal();
            TaxInfo(taxrate);
            Total();

            return receipt.ToString();
        }
    }
}
