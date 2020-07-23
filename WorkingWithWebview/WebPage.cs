using Xamarin.Forms;

namespace WorkingWithWebview
{
    public class WebPage : ContentPage
    {
        public WebPage()
        {
            var browser = new WebView();

            //Using Url works fine (not embedded link, but normal Url)

            //Original webpage of the sample
            //browser.Source = "http://xamarin.com";

            //Unrestricted YouTube video
            //browser.Source = "https://www.youtube.com/watch?v=4OZip0cgOho";

            //Domain Restricted YouTube video
            browser.Source = "https://www.youtube.com/watch?v=ssP0GrK8Uws";

            Content = browser;
        }
    }
}

