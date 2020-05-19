using System;
using System.Collections.Generic;
using System.Text;

namespace Salary_Increase
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        


        public Person(string firstName, string lastName, int age,decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
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
        public void IncreaseSalary(decimal percentage)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * percentage / 100;
            }
            else
            {
                this.salary += this.salary * percentage / 200;
            }
        }
        public override string ToString()
        {
            return $"{this.firstName}{this.lastName} receives {this.salary} dollers";
        }
    }
}
