using MarvelPortable;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MarvelPortablePlayground
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly IMarvelClient _client;

        public MainPage()
        {
            this.InitializeComponent();
            InitializeComponent();
            _client = new MarvelClient("ec29a219e0defb6f73a726f9aa1413e0", "c1c321f48ea81fb194a5772803d00f561d4c9d5d");
        }

        private async void DoSomethingButton_OnClick(object sender, RoutedEventArgs e)
        {
            var response = await _client.GetCharactersAsync("Captain America");
        }
    }
}
