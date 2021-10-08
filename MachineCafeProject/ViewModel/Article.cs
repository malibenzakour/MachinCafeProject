using System;
namespace MachineCafeProject.ViewModel
{
    public class Article
    {
        public Article() { }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prix { get; set; }
        public string UrlImage { get; set; }
        public int? Quantite { get; set; }
        public string TypeArticle { get; set; }
        public string CodePostal { get; set; }
        public int? Cl { get; set; }
    }
}
