using System;
using System.Collections.Generic;
using DevOpsTestApplication.ViewModels;
using Xamarin.Forms;

namespace DevOpsTestApplication.Pages
{
    public partial class CalculatorPage : ContentPage
    {
        public CalculatorPage()
        {
            InitializeComponent();
            BindingContext = new CalculateViewModel();
        }
    }
}
