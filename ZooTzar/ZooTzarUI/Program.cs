using ZooTzarLibrary;

Animal animal = new Animal();
Animal animal2 = new Animal("Brian");
//animal.Name = "Bonzo";
//animal.Age = 2;
//animal.LimbCount = -4;

Animal animal1 = new Animal() { Name = "Fifi", Age = 3, LimbCount = 6 };
//animal1.Name = "Fifi";
//animal1.Age = 3;
//animal1.LimbCount = -123;

Console.WriteLine("**************************");

Console.WriteLine(animal);
Console.WriteLine(animal1);

Console.WriteLine("**************************");

Console.WriteLine(animal.Eat("Biscuits"));
Console.WriteLine(animal.Move(distance:8));
Console.WriteLine(animal1.Move("South", 5));
Console.WriteLine(animal1.Eat("Cheese"));

List<Animal> animals = new List<Animal>();
animals.Add(animal);
animals.Add(animal1);
animals.Add(new Animal() { Name = "Bob", Age = 1, LimbCount = 0 });

Elelphant nellie = new Elelphant("Dumbo", 44, 5, 123);
//nellie.Name = "Nellie";
//nellie.Age = 72;
//nellie.LimbCount = 5;
//nellie.TrunkLength = 134;
animals.Add(nellie);
Console.WriteLine(nellie);
Console.WriteLine(nellie.Trumpet(10));
Console.WriteLine(nellie.Eat("Bun"));

animals.Add(new Raccoon() { Name="Rocky", Age=1, LimbCount = 3 });


foreach (Animal ani in animals)
{
    Console.WriteLine(ani.Eat("Biscuits"));
    Console.WriteLine(ani);
    if (ani is Raccoon)
    {
        //Raccoon r = (Raccoon)ani;
        Console.WriteLine(((Raccoon)ani).Scavenge("Jelly Babies"));
    }
    Elelphant e = ani as Elelphant;
    //if (e != null)
    //{
    //    Console.WriteLine(e.Trumpet(9));
    //}
    Console.WriteLine(e?.Trumpet(10));
}


