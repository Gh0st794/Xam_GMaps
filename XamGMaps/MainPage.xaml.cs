using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace XamGMaps
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Pin pinUdla = new Pin()
            {
                Type = PinType.Place,
                Label = "Udla",
                Address = "Udla, AV. granados, Av. de los colimes",
                Position = new Position(-0.16720865592050496, -78.47262167400834),
                Rotation = 33.3f,
                Tag = "id_udla",

            };
            map.Pins.Add(pinUdla);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(pinUdla.Position, Distance.FromMeters(5000)));

        }
    }
}
