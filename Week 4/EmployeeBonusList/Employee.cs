namespace EmployeeBonusList
{
    abstract class Employee
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string TypeEmployment { get; set; }


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

        public virtual string ToString()
        {
            return "The employee is: " + FirstName + " " + LastName + ", employment type: " + TypeEmployment;
        }

        public abstract double CalculateBonus();

        public abstract void WriteToFile(StreamWriter streamWriter);


        public abstract void UpdateCompensation(double compensation);



    } // end class
} // end namespace