using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullTimeEmployee : Employee
{
    public int salary;
    private void Start()
    {
        CalculateMonthlySalary();
    }
    public override void CalculateMonthlySalary()
    {
        Debug.Log("Salary: "+salary);
    }
}