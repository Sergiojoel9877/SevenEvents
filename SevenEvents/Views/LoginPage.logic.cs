using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SevenEvents.Views
{
    public partial class LoginPage : ContentPage
    {
        StackLayout TitleStack;
        StackLayout LoginControlsStackLayout;

        public LoginPage()
        {
            Build();
            //CompressLayouts(TitleStack, LoginControlsStackLayout);
            Visual = VisualMarker.Material;
        }

        void CompressLayouts(params Layout[] layouts)
        {
            for (int i = 0; i < layouts.Length; i++)
            {
                CompressedLayout.SetIsHeadless(layouts[i], true);
            }
        }
    }
}
