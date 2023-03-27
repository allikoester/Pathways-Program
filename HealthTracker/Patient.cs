namespace HealthTracker
{
    class Patient
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DateOfBirth { get; set; }

        public Patient(string firstName, string lastName, string monthDOB, int dayDOB, int yearDOB)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = monthDOB + " " + dayDOB + ", " + yearDOB;
        }

        public override string ToString()
        {
            return "The patient is: " + FirstName + " " + LastName + ", date of birth is: " + DateOfBirth;
        }

    } // end class
} // end namespace