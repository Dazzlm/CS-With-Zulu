﻿namespace CS_With_Zulu
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {

            return $"{base.ToString()}" +
                   $"\n\tValue to pay.........: {$"{GetValueToPay():C2}",18} \n";
        }

    }
}
