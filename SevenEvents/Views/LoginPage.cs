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
                BackgroundColor = Color.Black,
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
                                TextColor = Color.Orange,
                                FontAttributes = FontAttributes.Italic | FontAttributes.Bold
                            }.FormattedText(
                                new Span(){
                                    Text = "Seven Events"
                                }).CenterVertical().FontSize(40),
                            new Frame
                            {
                                Content = new StackLayout()
                                {
                                    Children =
                                    {
                                        new Label(){ Text = "Test" }
                                    }
                                }.Assign(out LoginControlsStackLayout)
                            }
                        }
                    }.Row(Row.LoginControlsFrame).CenterExpand().Paddings(0,40,0,0).Assign(out TitleStack)
                }
            }.FillExpand().Invoke((e)=>
            {   
                Shell.SetNavBarIsVisible(this, false);
            })
        };
    }
}
