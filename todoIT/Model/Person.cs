using System;

namespace Todoit.Model
{
    class Person
    {
        private readonly int personId;
        string firstName;
        string lastName;
        static int idCounter = 0;
        public static int Counter { get { return idCounter; } }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))  //prevent names from saving NULL & Empty 
                {
                    throw new ArgumentException("Empty or null is not allowed.");
                }

                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))   //prevent names from saving NULL & Empty 
                {
                    throw new ArgumentException("Empty or null is not allowed.");
                }
                lastName = value;
            }
        }
        public string FullName { get { return firstName + ' ' + lastName; } }

        public Person(string firstName, string lastName)
        {
            personId = ++idCounter;
            FirstName = firstName;
            LastName = lastName;
        }

        public string Details()
        {
            return $"PersonID: {personId}\nName: {FullName}";
        }
    }
}
