﻿using System;

namespace mod2
{
    class BusinessEmployee : Employee
    {
        // Creates double variable called "bonusBudget" and assigns value to 1000
        public double bonusBudget = 1000;

        // Calls upon base-class (Employee Class) constructor from within derived class (BusinessEmployee Class)
        // Sets baseSalary to 50000 for all BusinessEmployee objects
        public BusinessEmployee(String name) : base(name, 50000)
        {
        }

        // This method returns the toString() method - which is the employee's ID number and name - and prints the bonus budget
        // This method needs to use the override keyword to "override" the base class's method
        public override String employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
        }
    }
}
