namespace EmployeeBonus
{
    class Salary : Employee
    {

        public double Compensation { get; set; }

        public Salary(string firstName, string lastName, string typeEmployment, double salary) : base(firstName, lastName, typeEmployment)
        {
            Compensation = salary;
        }

        public override string ToString()
        {
            if (CalculateBonus() < 0)
            {
                return null;
            }
            return base.ToString() + ", the bonus amount is: $" + CalculateBonus();
        }

        public double CalculateBonus()
        {
            return Compensation * 0.10;
        }

        public override void WriteToFile(StreamWriter streamWriter)
        {
            streamWriter.WriteLine(FirstName);
            streamWriter.WriteLine(LastName);
            streamWriter.WriteLine(TypeEmployment);
            streamWriter.WriteLine(Compensation);
        }
        public override void UpdateCompensation(double compensation)
        {
            Compensation = compensation;
        }


    } // end class
} // end namespace 