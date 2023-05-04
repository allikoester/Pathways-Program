namespace EmployeeBonusList
{
    class Hourly : Employee
    {

        public double Compensation { get; set; }


        public Hourly(string firstName, string lastName, string typeEmployment, double hourlyRate) : base(firstName, lastName, typeEmployment)
        {
            Compensation = hourlyRate;
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
            return Compensation * 80;
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