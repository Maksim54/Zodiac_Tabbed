using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zodiac_Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedZodiac : TabbedPage
    {
        public TabbedZodiac()
        {
            Children.Add(createTabforTab("Fire"));
            Children.Add(createTabforTab("Earth"));
            Children.Add(createTabforTab("Air"));
            Children.Add(createTabforTab("Water"));
            BarBackground = new SolidColorBrush(Color.DarkSlateBlue);
            pick();
        }
        private TabbedPage createTabforTab(string title)
        {
            TabbedPage page = new TabbedPage
            {
                Title = title,
                Children = { new InnerZodiac(), new InnerZodiac(), new InnerZodiac() },
                BackgroundColor = Color.DarkSlateBlue,
                BarBackground = new SolidColorBrush(Color.DarkSlateBlue),
            };
            return page;
        }
        public async void pick()
        {
            List<string> zods = new List<string> { "Fire", "Earth", "Air", "Water" };
            var a = await DisplayActionSheet("Pick your starting page", "Cancel", null, new string[] { "Fire", "Earth", "Air", "Water"});
            this.CurrentPage = this.Children[zods.IndexOf(a)];
        }
    }
}