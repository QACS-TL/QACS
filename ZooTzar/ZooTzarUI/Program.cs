using ZooTzarLibrary;

Animal animal = new Animal();
animal.name = "Bonzo";
animal.age = 2;
animal.limbCount = 4;

Animal animal1 = new Animal();
animal1.name = "Fifi";
animal1.age = 3;
animal1.limbCount = 6;

Console.WriteLine($"I'm an animal called {animal.name}. I am {animal.age} years old and I have {animal.limbCount} limbs.");
Console.WriteLine($"I'm an animal called {animal1.name}. I am {animal1.age} years old and I have {animal1.limbCount} limbs.");

Console.WriteLine(animal.Eat("Biscuits"));
Console.WriteLine(animal.Move(8));
Console.WriteLine(animal1.Move("North", 10));
Console.WriteLine(animal1.Eat("Cheese"));
