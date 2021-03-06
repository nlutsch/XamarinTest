﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Testapp
{
	public partial class XamlPlusCodePage : ContentPage
	{
		public XamlPlusCodePage ()
		{
			InitializeComponent ();
		}

		void OnSliderValueChanged(object sender, ValueChangedEventArgs args) 
		{
			valueLabel.Text = args.NewValue.ToString ("F3");
		}

		async void OnButtonClicked(object sender, EventArgs args)
		{
			Button button = (Button)sender;
			await DisplayAlert ("Clicked!", 
				"The button labeled " + button.Text + " was clicked!",
				"OK");
		}
	}
}

