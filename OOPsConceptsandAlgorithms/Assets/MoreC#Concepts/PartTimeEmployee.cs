using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTimeEmployee : Employee
{
    public int hoursWork;
    public int hourlyRate;
    private void Start()
    {
        CalculateMonthlySalary();
    }
    public override void CalculateMonthlySalary()
    {
        Debug.Log("Salary: "+(hourlyRate * hoursWork));
    }
}