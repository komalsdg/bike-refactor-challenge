using System.Collections.Generic;

namespace BikeDistributor.Discount
{
    public class DiscountList
    {
        public enum OperatorEnum
        {
            GreaterThanOrEqual,
            LessThanOrEqual,
            Equal
        }

        public IEnumerable<Discounts> AllDiscount = new List<Discounts>
        {
           new Discounts("CODE109",OperatorEnum.GreaterThanOrEqual.ToString(),20,Bike.OneThousand,.9d),
           new Discounts("CODE208",OperatorEnum.GreaterThanOrEqual.ToString(),10,Bike.TwoThousand,.8d),
           new Discounts("CODE508",OperatorEnum.GreaterThanOrEqual.ToString(),5,Bike.FiveThousand,.8d),
           new Discounts("CODE3506",OperatorEnum.LessThanOrEqual.ToString(),2,3500,.6d)
        };
    }
}
