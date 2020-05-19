using System;
using System.Collections.Generic;
using System.Text;

namespace First_and_Reserve_Team
{
    class Person

    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;


        public Person(string firstName, string lastName, int age, Decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
        }
        public string LasttName
        {
            get
            {
                return this.lastName;
            }
        }
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
        }
    }
}
