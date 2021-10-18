using System;
namespace CleanSounds.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BreathePage(), true);
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BeachParadise(), true);
        }
    }
}
