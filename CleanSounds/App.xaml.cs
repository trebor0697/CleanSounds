using CleanSounds.ViewModels;
using CleanSounds.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace CleanSounds
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/HomePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>("HomePage");
            containerRegistry.RegisterForNavigation<BreathePage, BreathePageViewModel>("BreathePage");
            containerRegistry.RegisterForNavigation<DailyMeditationCard, DailyMeditationCardViewModel>("RainingSidewalk");
            containerRegistry.RegisterForNavigation<BeachParadise, BeachParadiseViewModel>("BeachParadise");
        }
    }
}
