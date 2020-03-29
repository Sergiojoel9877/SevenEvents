using System;
using SevenEvents.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using static Xamarin.Forms.Markup.GridRowsColumns;

namespace SevenEvents.Views
{
    public partial class LoginPage : ContentPage
    {
        enum Row
        {
            Title, LoginControlsFrame, NotRegisterStack
        }
        
        void Build() => Content = new ScrollView
 	    {
            Content = new Grid
	        {
                BackgroundColor = Color.White,
                RowDefinitions = Rows.Define
                (
                    (Row.Title, 0),
                    (Row.LoginControlsFrame, 1),
                    (Row.NotRegisterStack, 2)
                ),
                Children =
		        {
                    new StackLayout()
	                {
                        Children =
		                {
                            new Label()
         	                {
                                VerticalOptions = LayoutOptions.Center,
                                TextColor = Color.Black
                            }.FormattedText(
                                new Span(){
                                    Text = ConstantsValues.AppName
                                }).CenterVertical(),
                        }
                    }.Row(Row.LoginControlsFrame).CenterExpand()
                }
            }.FillExpand().Invoke((e)=>
            {
                Shell.SetNavBarIsVisible(this, false);
            })
        };

        //Frame CreateFrameWithControls() => new Frame
        //{

        //};
    }
}
