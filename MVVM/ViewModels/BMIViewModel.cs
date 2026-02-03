using System;
using BMICalculator.MVVM.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BMICalculator.MVVM.ViewModels;

public partial class BMIViewModel : ObservableObject
{
    private readonly BMI _bmi = new();

    [NotifyPropertyChangedFor(nameof(Result))]
    [NotifyPropertyChangedFor(nameof(ResultCategory))]
    [ObservableProperty]
    public float height = 25f;

    [NotifyPropertyChangedFor(nameof(Result))]
    [NotifyPropertyChangedFor(nameof(ResultCategory))]
    [ObservableProperty]
    public float weight = 50f;

    public float Result
    {
        get
        {
            var h = Height / 100f;
            if (h <= 0) return 0;
            return Weight / (h*h);
        }
    }

    public string ResultCategory
    {
        get
        {
            var bmi = Result;
            if (bmi == 0) return "Desnutrition";
            if (bmi < 18.5f) return "Underweight";
            if (bmi < 24.9f) return "Normal weight";
            if (bmi < 29.9f) return "Overweight";
            return "Obesity";
        }
    }

    // partial void OnHeightChanged(float value)
    // {
    //     _bmi.Height = height;
    //     OnPropertyChanged(nameof(Result));
    // }

    // partial void OnWeightChanged(float value)
    // {
    //     _bmi.Weight = weight;
    //     OnPropertyChanged(nameof(Result));
    // }

}
