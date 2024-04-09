using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mod04Act02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPage1 : CarouselPage
    {
        public CarouselPage1()
        {
            InitializeComponent();
        }

        private async void NavigateToNextPage(object sender, EventArgs e)
        {
          
            if (CurrentPage != null)
            {
                var nextPageIndex = Children.IndexOf(CurrentPage) + 1;
                if (nextPageIndex < Children.Count)
                    await CurrentPage.Navigation.PushAsync(Children[nextPageIndex]);
            }
        }

        private async void NavigateBack(object sender, EventArgs e)
        {
          
            await Navigation.PopAsync();
        }
    }
}
