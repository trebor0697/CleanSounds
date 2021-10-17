using System;
namespace CleanSounds.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void GoToHotelPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotelPage(), true);
        }
    }
}
