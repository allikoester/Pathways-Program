namespace EmployeeBonusList
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

        public override double CalculateBonus()
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

        internal static void Add(string firstName, string lastName, string employmentType, double compensation)
        {
            throw new NotImplementedException();
        }
    } // end class
} // end namespace 