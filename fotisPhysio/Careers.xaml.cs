﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace fotisPhysio
{
    public partial class Careers : ContentPage
    {
        public Careers()
        {
            InitializeComponent();
        }


        async void Apply(object sender, System.EventArgs e)
        {
            var newPage = new Careerform();
            await Navigation.PushAsync(newPage);
        }

    }
}