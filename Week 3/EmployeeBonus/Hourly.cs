namespace EmployeeBonus
{
    class Hourly : Employee
    {

        public double HourlyRate { get; set; }

        public double Bonus { get; set; }

        public Hourly(string firstName, string lastName, string typeEmployment, double hourlyRate) : base(firstName, lastName, typeEmployment)
        {
            HourlyRate = hourlyRate;
        }

        public override string ToString()
        {
            return base.ToString() + ", the bonus amount is: $" + Bonus;
        }

        public override double CalculateBonus(double hourlyRate)
        {
            double bonus = hourlyRate * 80;
            Bonus = bonus;
            return bonus;
        }

    } // end class
} // end namespace 