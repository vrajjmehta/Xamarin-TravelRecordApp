using System;

using Xamarin.Forms;

namespace TravelRecordAp
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void registerButton_Clicked(object sender, EventArgs e)
        {
            if (passwordEntry.Text == confirmPasswordEntry.Text)
            {


            }
            else
            {
                DisplayAlert("Error", "Password dont match","OK");
            }
        }
    }
}
