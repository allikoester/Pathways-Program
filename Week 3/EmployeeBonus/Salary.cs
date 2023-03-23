namespace EmployeeBonus
{
    class Salary : Employee
    {

        public double AnnualSalary { get; set; }

        public double Bonus { get; set; }

        public Salary(string firstName, string lastName, string typeEmployment, double salary) : base(firstName, lastName, typeEmployment)
        {
            AnnualSalary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + ", the bonus amount is: $" + Bonus;
        }

        public override double CalculateBonus(double salary)
        {
            double bonus = salary * 0.10;
            Bonus = bonus;
            return bonus;
        }

    } // end class
} // end namespace 