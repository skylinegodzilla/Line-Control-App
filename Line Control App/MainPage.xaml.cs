using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Line_Control_App
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        int min = 0;
        int targit = 1;
        int max = 2;
        void Add_Clicked(object sender, System.EventArgs e)
        {
            count++;
            LabelOne.Text = $"{count}";
            CountColour();
        }

        void Sub_Clicked(object sender, System.EventArgs e)
        {
            count--;
            LabelOne.Text = $"{count}";
            CountColour();
        }

        void UpdateMinMax(object sender, System.EventArgs e)
        {
            int minInt;
            if (int.TryParse(MinEdt.Text, out minInt))
            {
                min = minInt;
            }
            int targitInt;
            if (int.TryParse(TargitEdt.Text, out targitInt))
            {
                targit = targitInt;
            }
            int maxInt;
            if (int.TryParse(MaxEdt.Text, out maxInt))
            {
                max = maxInt;
            }

            CountColour();
        }

        void NewCount(object sender, System.EventArgs e)
        {
            int newCountInt;
            if (int.TryParse(NewCountEdt.Text, out newCountInt))
            {
                count = newCountInt;
            }

            LabelOne.Text = "XX";
            LabelOne.Text = $"{count}";
            CountColour();
        }

        void CountColour()
        {
            if (count >= max)
            {
                LabelOne.TextColor = Color.FromHex("#AA2222");
            }
            else if (count >= targit)
            {
                LabelOne.TextColor = Color.FromHex("#FF8200");
            }
            else if (count >= min)
            {
                LabelOne.TextColor = Color.FromHex("#097100");
            }
            else
            {
                LabelOne.TextColor = Color.FromHex("#999999");
            }
        }
    }
}