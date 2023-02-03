﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prov11
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            Button Entry_btn=new Button
            {
              Text="Ava Entry leht",
              TextColor = Color.DarkGoldenrod,
              BackgroundColor=Color.LightSkyBlue
             };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { Entry_btn },
                BackgroundColor = Color.MediumPurple
            };
            Content= st;
            Entry_btn.Clicked += Entry_btn_Clicked;
        }
        private async void Entry_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_Page());
        }
    }
}