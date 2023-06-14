using Zoo;

using ZooContext context = new ZooContext();

context.Add(new Lion
{
    Nom = "Moufassa",
    Sexe = Genre.Male,
    Couleur = "Beige"
});

context.SaveChanges();

foreach (var animal in context.Otaries)
{
    Console.WriteLine(animal.Id);
    Console.WriteLine(animal.Nom);
}
