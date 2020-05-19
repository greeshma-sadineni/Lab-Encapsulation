using System;
using System.Collections.Generic;
using System.Text;

namespace Validation_of_Data
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;



        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("salary canot be less than 460 dollers");
                }
                this.salary = value;
            }
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
               
                if (value.Length < 3)
                {
                    throw new System.ArgumentException("First name have min 3 letters");
                }
                this.firstName = value;

            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new System.ArgumentException("last name have min 3 letters");
                }
                    this.lastName = value;
                
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {

                if (value <=0)
                {
                    throw new ArgumentException("Age cant be non zero or negitive");
                }
               
                
                    this.age = value;
                
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
