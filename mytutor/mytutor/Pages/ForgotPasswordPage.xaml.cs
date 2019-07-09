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
    public partial class ForgotPasswordPage : ContentPage
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
        }

        private async void BtnSend_Clicked(object sender, EventArgs e)
        {
            ApiService apiService = new ApiService();
            bool response = await apiService.PasswordRecovery(EntEmail.Text);
            if (!response)
            {
                await DisplayAlert("Opps", "Iko shida mahali", "Cancel");
            }
            else
            {
                await DisplayAlert("Hi", "A new password has been sent to your email. Kindly type the new password", "Alright");
                await Navigation.PopToRootAsync();
            }
        }
    }
}