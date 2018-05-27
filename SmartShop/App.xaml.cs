using System;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using SmartShop.Screen;
using SmartShop.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SmartShop
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:kbcfx.App"/> class.
        /// </summary>
        /// <param name="initializer">Initializer.</param>
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        /// <summary>
        /// Ons the initialized.
        /// </summary>
        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/QRCodeScreen");


        }

        /// <summary>
        /// Registers the types.
        /// </summary>
        /// <param name="containerRegistry">Container registry.</param>
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Screen
            containerRegistry.RegisterForNavigation<NavigationPage>("NavigationPage");
            containerRegistry.RegisterForNavigation<QRCodeScreen, QRCodeViewModel>("QRCodeScreen");

            // Register for Popup page
            //containerRegistry.RegisterPopupNavigationService();

            // Interface
            //containerRegistry.Register(typeof(IPositionInquiryService), typeof(PositionInquiryService));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
