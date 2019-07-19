using BikeDistributor.Discount;
using System.Collections.Generic;

namespace BikeDistributor.Receipt
{
    public class HtmlReceipt : ReceiptFormat
    {
        public override void CompanyOrder(string company)
        {
            receipt.Append("<html><body><h1>");
            base.CompanyOrder(company);
            receipt.Append("</h1>");
        }

        public override void CompanyLine(IList<Line> line, DiscountRule dRule)
        {
            receipt.Append("<ul>");

            foreach (var _line in line)
            {
                receipt.Append("<li>");
                base.CompanyLine(_line, dRule);
                receipt.Append("</li>");
            }

            receipt.Append("</ul>");
        }

        public override void SubTotal()
        {
            receipt.Append("<h3>");
            base.SubTotal();
            receipt.Append("</h3>");
        }

        public override void TaxInfo(double taxRate)
        {
            receipt.Append("<h3>");
            base.TaxInfo(taxRate);
            receipt.Append("</h3>");
        }

        public override void Total()
        {
            receipt.Append("<h2>");
            base.Total();
            receipt.Append("</h2>");
            receipt.Append("</body></html>");
        }

        public override string FinalReceipt(string company, IList<Line> lines, double taxrate, DiscountRule dRule)
        {
            return base.FinalReceipt(company, lines, taxrate, dRule);
        }
    }
}