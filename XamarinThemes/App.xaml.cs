using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinThemes.Styles;

namespace XamarinThemes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static AppTheme ActualTheme { get; set; } = AppTheme.Unspecified;

        protected override void OnStart()
        {
            SetAppTheme();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            SetAppTheme();
        }

        // Aplica o tema ao app de acordo com o tema solicitado pelo sistema
        private void SetAppTheme()
        {
            // Verifica se o tema do sistema é o Dark
            if (AppInfo.RequestedTheme == AppTheme.Dark)
            {
                // Verifica se o tema atual do nosso app já é o solicitado pelo sistema
                if (ActualTheme == AppTheme.Dark)
                {
                    return;
                }

                // Aplica o tema Dark ao nosso aplicativo
                Current.Resources = new DarkTheme();
                // Altera nossa propriedade para refletir o tema atual do nosso aplicativo
                ActualTheme = AppTheme.Dark;
            }
            else // Se não for o tema Dark vamos aplicar o tema Light ao nosso aplicativo
            {
                // Verifica se o tema atual do nosso app já é o solicitado pelo sistema
                if (ActualTheme == AppTheme.Light)
                {
                    return;
                }

                // Aplica o tema Light ao nosso aplicativo
                Current.Resources = new LightTheme();
                // Altera nossa propriedade para refletir o tema atual do nosso aplicativo
                ActualTheme = AppTheme.Light;
            }
        }
    }
}
