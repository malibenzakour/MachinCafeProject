using System;
using System.Collections.Generic;
using MachineCafeProject.Service;
using MachineCafeProject.ViewModel;
using Xamarin.Forms;

namespace MachineCafeProject.Views
{
    public partial class PayementView : ContentPage
    {
        ServiceMachine _service = new ServiceMachine();
        Article article = new Article();
        public PayementView(Article item)
        {
            InitializeComponent();
            article = item;
            Prix.Text = item.Prix;

        }

        void OnButtonClicked(System.Object sender, System.EventArgs e)
        {
            string ok = AsyncToSync.ConvertToSync<string>(() => _service.AddItem(article.Id));
            this.Navigation.PushAsync(new MenuPage());
        }
    }
}
