using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zodiac_Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InnerZodiac : ContentPage
    {
        private static int indexForCreation = 0;
        private string[] attributeListofZodiac;
        public InnerZodiac()
        {
            InitializeComponent();
            attributeListofZodiac = Properties.Resources.ResourceManager.GetString("_" + indexForCreation.ToString()).Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            TapGestureRecognizer tap = new TapGestureRecognizer { NumberOfTapsRequired = 2 };
            tap.Tapped += Tap_Tapped;
            img.Source = "_"+indexForCreation.ToString()+".jpg";
            img.GestureRecognizers.Add(tap);
            this.Title = attributeListofZodiac[0];
            dateA.Text = attributeListofZodiac[1];
            traitA.Text = attributeListofZodiac[2];
            gemA.Text = attributeListofZodiac[3];
            indexForCreation++;
        }
        private void Tap_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(attributeListofZodiac[4]));
        }
    }
}