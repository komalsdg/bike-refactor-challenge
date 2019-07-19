using System.Collections.Generic;
using System.Linq;
using static BikeDistributor.Discount.DiscountList;

namespace BikeDistributor.Discount
{
    public class DiscountRule
    {
        public IList<Line> Line { get; set; }
        public IList<Discounts> Discountlist { get; set; }
        public double DiscountAmount { get; set; }

        public void ApplyDiscountRule()
        {
            foreach (var line in Line)
            {
                var addDiscount = (from dl in Discountlist
                                   where line.Bike.Price == dl.BikePrice &&

                                         (dl.Operator == OperatorEnum.GreaterThanOrEqual.ToString() ? line.Quantity >= dl.Quantity :
                                         (dl.Operator == OperatorEnum.LessThanOrEqual.ToString() ? line.Quantity <= dl.Quantity :
                                         line.Quantity == dl.Quantity))

                                   select dl).FirstOrDefault();
                if (addDiscount != null)
                    DiscountAmount = line.Quantity * line.Bike.Price * addDiscount.Amount;
                else
                    DiscountAmount = line.Quantity * line.Bike.Price;
            }
        }
    }
}
