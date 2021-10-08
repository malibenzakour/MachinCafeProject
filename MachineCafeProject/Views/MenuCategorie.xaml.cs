using System.Collections.Generic;
using MachineCafeProject.Service;
using MachineCafeProject.ViewModel;
using Xamarin.Forms;

namespace MachineCafeProject.Views
{


    public partial class MenuCategorie : ContentPage
    {

        List<Article> Articles;
        ServiceMachine _service=new ServiceMachine();

        public MenuCategorie(string cat)
        {
            InitializeComponent();
            Articles = new List<Article>();
            Articles = AsyncToSync.ConvertToSync<List<Article>>(() => _service.GetItems(cat));
            maListView.ItemsSource = Articles;
            Categorie.Text = cat;

            maListView.ItemSelected += (sender, e) =>
            {
                if (maListView.SelectedItem != null)
                {
                    var item = maListView.SelectedItem as Article;
                    this.Navigation.PushAsync(new ArticleView(item));
                }
            };
        }
    }
}
