namespace Zoo.Web.Models
{
    public class AnimalListViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Nom { get; set; }
        public AnimalListViewModel(Animal a)
        {
            Id = a.Id;
            Nom = a.Nom;
            Type = a.GetType().Name;
        }
    }
}
