using ZooTzarLibrary;

Animal animal = new Elephant("Tina", 43, 4, 112);
Animal animal2 = new Raccoon( );
//animal.Name = "Bonzo";
//animal.Age = 2;
//animal.LimbCount = -4;

Animal animal1 = new Elephant() { Name = "Fifi", Age = 3, LimbCount = 6 };
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

List<IAnimal> animals = new List<IAnimal>();
animals.Add(animal);
animals.Add(animal1);
animals.Add(new Elephant() { Name = "Bob", Age = 1, LimbCount = 0 });

Elephant nellie = new Elephant("Dumbo", 44, 5, 123);
//nellie.Name = "Nellie";
//nellie.Age = 72;
//nellie.LimbCount = 5;
//nellie.TrunkLength = 134;
animals.Add(nellie);
Console.WriteLine(nellie);
Console.WriteLine(nellie.Trumpet(10));
Console.WriteLine(nellie.Eat("Bun"));

animals.Add(new Raccoon() { Name="Rocky", Age=1, LimbCount = 3 });

foreach (IAnimal ani in animals)
{
    Console.WriteLine(ani);
}

Console.WriteLine("*************************************");
animals.Sort();

foreach (IAnimal ani in animals)
{
    Console.WriteLine(ani);
}

Console.WriteLine("*************************************");
animals.Sort(Animal.IAnimalNameComparer);

foreach (Animal ani in animals)
{
    Console.WriteLine(ani);
}

Console.WriteLine("*************************************");
animals.Sort(Animal.IAnimalAgeComparer);

foreach (Animal ani in animals)
{
    Console.WriteLine(ani);
}

//foreach (Animal ani in animals)
//{
//    Console.WriteLine(ani.Eat("Biscuits"));
//    Console.WriteLine(ani);
//    if (ani is Raccoon)
//    {
//        //Raccoon r = (Raccoon)ani;
//        Console.WriteLine(((Raccoon)ani).Scavenge("Jelly Babies"));
//    }
//    Elephant e = ani as Elephant;
//    //if (e != null)
//    //{
//    //    Console.WriteLine(e.Trumpet(9));
//    //}
//    Console.WriteLine(e?.Trumpet(10));
//    Console.WriteLine($"There are {Animal.AnimalCount} animals");


//}


