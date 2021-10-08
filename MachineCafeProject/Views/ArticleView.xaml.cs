using System;
using System.Collections.Generic;
using System.Windows.Input;
using MachineCafeProject.ViewModel;
using Xamarin.Forms;

namespace MachineCafeProject.Views
{
    public partial class ArticleView : ContentPage
    {
        public Article article;
        public ArticleView(Article item)
        {
            InitializeComponent();
            article = item;
            Label.Text = item.Nom;
            Image.Source = item.UrlImage;
            Prix.Text = item.Prix;
            slideNumber.Text = "0";
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            slideNumber.Text = args.NewValue.ToString();
        }


        void OnButtonClicked(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new PayementView(article));
        }
    }
}
