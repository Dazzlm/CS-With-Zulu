namespace CS_With_Zulu
{
    public class BaseCommissionEmployee : CommissionEmployee
    {
        public decimal Base { get; set; }

        public override decimal GetValueToPay()
        {
            return base.GetValueToPay() + Base;
        }

        public override string ToString()
        {

            return $"{base.ToString()}" +
                   $"\n\tBase.................: {$"{CommissionPercentaje:P2}",18} \n";
        }
    }
}
