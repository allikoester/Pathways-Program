namespace EmployeeBonus
{
    class Employee
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TypeEmployment { get; set; }

        public double Bonus { get; set; }

        public double Compensation;


        public Employee()
        {
            FirstName = " ";
            LastName = " ";
            TypeEmployment = " ";

        }

        public Employee(string firstName, string lastName, string typeEmployment)
        {
            FirstName = firstName;
            LastName = lastName;
            TypeEmployment = typeEmployment;

        }

        public override string ToString()
        {
            return "The employee is: " + FirstName + " " + LastName + ", employment type: " + TypeEmployment;
        }

        public virtual double CalculateBonus(double compensation)
        {
            double bonus = 0.0;
            Bonus = Bonus;
            return bonus;
        }

    } // end class
} // end namespace