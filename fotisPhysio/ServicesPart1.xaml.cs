using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class ServicesPart1 : ContentPage
    {
        public ServicesPart1(String Title,String Service_Description)
        {
            InitializeComponent();
            title.Text = Title;
            Title_Description.Text = Service_Description;
        }
    }
}
