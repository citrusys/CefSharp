using System.Threading.Tasks;
using System.Windows;
using Fluxonaut.Browser.Example.JavascriptBinding;

namespace Fluxonaut.Browser.Wpf.Example
{
    /// <summary>
    /// Interaction logic for JavascriptCallbackMainWindow.xaml
    /// </summary>
    public partial class JavascriptCallbackMainWindow : Window
    {
        private JavascriptCallbackBoundObject boundObjectOne;
        private JavascriptCallbackBoundObject boundObjectTwo;

        public JavascriptCallbackMainWindow()
        {
            InitializeComponent();

            boundObjectOne = new JavascriptCallbackBoundObject(BrowserOne);
            boundObjectTwo = new JavascriptCallbackBoundObject(BrowserTwo);

            BrowserOne.JavascriptObjectRepository.Register("boundObject", boundObjectOne, false);
            BrowserTwo.JavascriptObjectRepository.Register("boundObject", boundObjectTwo, false);
        }

        private void ExecuteCallbackImmediatelyClick(object sender, RoutedEventArgs e)
        {
            boundObjectOne.RunCallback();
            boundObjectTwo.RunCallback();

            BrowserOne.Reload();
            BrowserTwo.Reload();
        }

        private void ExecuteCallbackInThreeSeconds(object sender, RoutedEventArgs e)
        {
            BrowserOne.Address = "custom://cefsharp/SchemeTest.html";
            BrowserTwo.Address = "custom://cefsharp/SchemeTest.html";

            Task.Delay(3000).ContinueWith(t =>
            {
                boundObjectOne.RunCallback();
                boundObjectTwo.RunCallback();
            });

        }
    }
}
