using mytutor.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mytutor.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private async void BtnSignUp_Clicked(object sender, EventArgs e)
        {
            ApiService apiService = new ApiService();
            bool response = await apiService.RegisterUser(EntEmail.Text, EntPassword.Text, EntConfirmPassword.Text);
            if (!response)
            {
                await DisplayAlert("Oops", "Iko shida mahali", "Cancel");
            }
            else
            {
                await DisplayAlert("Hi", "Your account has been created. Now you need to go back and Log in", "Alright");
                await Navigation.PopToRootAsync();
            }
        }
    }
}