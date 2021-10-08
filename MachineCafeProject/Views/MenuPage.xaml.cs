using System;
using System.Collections.Generic;
using MachineCafeProject.Service;
using MachineCafeProject.ViewModel;
using Xamarin.Forms;

namespace MachineCafeProject.Views
{
    public partial class MenuPage : ContentPage
    {
        public const string THE = "THE";
        public const string CHOCOLAT = "CHOCOLAT";
        public const string SOUPE = "SOUPE";
        public const string CAFE = "CAFE";

        public MenuPage()
        {
            InitializeComponent();
        }

        void MenuCategorieClicked_The(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new MenuCategorie(THE));
        }
        void MenuCategorieClicked_Cafe(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new MenuCategorie(CAFE));
        }
        void MenuCategorieClicked_Soupe(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new MenuCategorie(SOUPE));
        }
        void MenuCategorieClicked_Chocolat(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new MenuCategorie(CHOCOLAT));
        }
    }
}
