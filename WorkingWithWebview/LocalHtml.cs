using Xamarin.Forms;

namespace WorkingWithWebview
{
    public class LocalHtml : ContentPage
    {
        public LocalHtml()
        {
            //Using Html to load embedded link of domain restricted YouTube Video will show "Video Unavailable" message.

            var browser = new WebView();
            var htmlSource = new HtmlWebViewSource();

            //Embedded Domain Restricted YouTube Video, will get "Video Unavailable" error message
            htmlSource.Html = @"<html>
                                    <body>  
                                        <div style=' position: relative; padding-bottom: 56.25%; padding-top: 25px; overflow: hidden;'> 
                                            <iframe style='position: absolute; top: 0; left: 0; width: 100%; height: 100%;' src='https://www.youtube.com/embed/ssP0GrK8Uws' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>
                                        </div> 
                                    </body>
                                </html>";

            //Embedded Unrestricted YouTube video, works fine
            //htmlSource.Html = @"<html>
            //                        <body>  
            //                            <div style=' position: relative; padding-bottom: 56.25%; padding-top: 25px; overflow: hidden;'> 
            //                                <iframe style='position: absolute; top: 0; left: 0; width: 100%; height: 100%;' src='https://www.youtube.com/embed/dOgwQ5pmSiQ' frameborder='0' allow='accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>
            //                            </div> 
            //                        </body>
            //                    </html>";
            browser.Source = htmlSource;
            Content = browser;
        }
    }
}
