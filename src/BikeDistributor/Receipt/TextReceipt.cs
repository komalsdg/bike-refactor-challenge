using BikeDistributor.Discount;
using System.Collections.Generic;

namespace BikeDistributor.Receipt
{
    public class TextReceipt : ReceiptFormat
    {
        public override void CompanyOrder(string company)
        {
            base.CompanyOrder(company);
        }

        public override void CompanyLine(IList<Line> line, DiscountRule dRule)
        {
            foreach (var _line in line)
            {
                receipt.AppendLine();
                receipt.Append("\t");
                base.CompanyLine(_line, dRule);
            }
        }

        public override void SubTotal()
        {
            receipt.AppendLine();
            base.SubTotal();
        }

        public override void TaxInfo(double taxRate)
        {
            receipt.AppendLine();
            base.TaxInfo(taxRate);
        }

        public override void Total()
        {
            receipt.AppendLine();
            base.Total();
        }

        public override string FinalReceipt(string company, IList<Line> lines, double taxrate, DiscountRule dRule)
        {
            return base.FinalReceipt(company,lines,taxrate,dRule);
        }
    }
}
