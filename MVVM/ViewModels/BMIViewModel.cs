using System;
using BMICalculator.MVVM.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BMICalculator.MVVM.ViewModels;

public partial class BMIViewModel : ObservableObject
{
    private readonly BMI _bmi = new();

    [NotifyPropertyChangedFor(nameof(Result))]
    [ObservableProperty]
    public float height = 0f;


    [NotifyPropertyChangedFor(nameof(Result))]
    [ObservableProperty]
    public float weight = 0f;

    public float Result
    {
        get
        {
            var h = Height / 100f;
            if (h <= 0) return 0;
            return Weight / (h*h);
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
