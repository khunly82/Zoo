using Zoo;

using ZooContext context = new ZooContext();

//context.Add(new Lion
//{
//    Nom = "Moufassa",
//    Sexe = Genre.Male,
//    Couleur = "Beige"
//});

//context.SaveChanges();

//foreach (var animal in context.Animals
//    .Where(a => a.Sexe == Genre.Male)
//    .Select(a => new Animal { Nom = a.Nom })
//    )
//{
//    Console.WriteLine(animal.Id);
//    Console.WriteLine(animal.Nom);
//    Console.WriteLine(animal.Sexe);
//}