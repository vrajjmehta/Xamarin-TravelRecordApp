using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace TravelRecordAp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : Xamarin.Forms.TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom).SetBarItemColor(Color.Black).SetBarSelectedItemColor(Color.Red);
        }
    

        private void ToolbarItem_Clicked(object sender, EventArgs e) {
            Navigation.PushAsync(new NewTravelPage());
        }
    }
}