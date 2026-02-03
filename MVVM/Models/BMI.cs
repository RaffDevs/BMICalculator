using System;

namespace BMICalculator.MVVM.Models;

public class BMI
{
    public float Height { get; set; }
    public float Weight { get; set; }
    public float Result
    {
        get
        {
            return ((Weight / Height) / Height) * 10000;
        }
    }
}
