using ZooTzarLibrary;

Animal animal = new Animal();
animal.Name = "Bonzo";
animal.Age = 2;
animal.LimbCount = -4;

Animal animal1 = new Animal();
animal1.Name = "Fifi";
animal1.Age = 3;
animal1.LimbCount = -123;

Console.WriteLine($"I'm an animal called {animal.Name}. I am {animal.Age} years old and I have {animal.LimbCount} limbs.");
Console.WriteLine($"I'm an animal called {animal1.Name}. I am {animal1.Age} years old and I have {animal1.LimbCount} limbs.");

Console.WriteLine(animal.Eat("Biscuits"));
Console.WriteLine(animal.Move(8));
Console.WriteLine(animal1.Move("North", 10));
Console.WriteLine(animal1.Eat("Cheese"));
