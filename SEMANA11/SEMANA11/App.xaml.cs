﻿using SEMANA11.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEMANA11
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View.Operacion();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
