using BikeDistributor.Discount;
using BikeDistributor.Receipt;
using System.Collections.Generic;
using System.Linq;

namespace BikeDistributor
{
    public class Order
    {
        private const double TaxRate = .0725d;
        private readonly IList<Line> _lines = new List<Line>();
        private DiscountRule DRule = new DiscountRule();

        public Order(string company)
        {
            Company = company;
        }

        public Order(string company, IList<Discounts> discounts)
        { }

        public string Company { get; private set; }

        public void AddLine(Line line)
        {
            _lines.Add(line);
        }

        public void CountDiscount()
        {
            DiscountList ds = new DiscountList();
            DRule = new DiscountRule { Line = _lines, Discountlist = ds.AllDiscount.ToList() };
            DRule.ApplyDiscountRule();
        }

        public string GetReceiptFormat(ReceiptEnum.ReceiptType type)
        {
            CountDiscount();

            switch (type)
            {
                case ReceiptEnum.ReceiptType.text:
                    TextReceipt treceipt = new TextReceipt();
                    return treceipt.FinalReceipt(Company, _lines, TaxRate, DRule);
                case ReceiptEnum.ReceiptType.Html:
                    HtmlReceipt hreceipt = new HtmlReceipt();
                    return hreceipt.FinalReceipt(Company, _lines, TaxRate, DRule);
                default:
                    break;
            }

            return "";
        }

        public string Receipt()
        {
            return GetReceiptFormat(ReceiptEnum.ReceiptType.text);
        }

        public string HtmlReceipt()
        {
            return GetReceiptFormat(ReceiptEnum.ReceiptType.Html);
        }

    }
}
