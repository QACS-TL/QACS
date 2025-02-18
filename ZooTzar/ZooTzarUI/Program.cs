using ZooTzarLibrary;

Animal animal = new Animal();
animal.Name = "Bonzo";
animal.Age = 2;
animal.LimbCount = -4;

Animal animal1 = new Animal() { Name = "Fifi", Age = 3, LimbCount = 6 };
//animal1.Name = "Fifi";
//animal1.Age = 3;
//animal1.LimbCount = -123;

Console.WriteLine("**************************");

Console.WriteLine(animal);
Console.WriteLine(animal1);

Console.WriteLine("**************************");

Console.WriteLine(animal.Eat("Biscuits"));
Console.WriteLine(animal.Move(8));
Console.WriteLine(animal1.Move("North", 10));
Console.WriteLine(animal1.Eat("Cheese"));

List<Animal> animals = new List<Animal>();
animals.Add(animal);
animals.Add(animal1);
animals.Add(new Animal() { Name = "Bob", Age = 1, LimbCount = 0 });

foreach(Animal ani in animals)
{
    Console.WriteLine(ani.Eat("Biscuits"));
}
