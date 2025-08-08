using System;

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Animal genericAnimal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        Console.WriteLine("Generic Animal Sound:");
        genericAnimal.MakeSound();
        Console.WriteLine("Dog Sound:");
        dog.MakeSound();
        Console.WriteLine("Cat Sound:");
        cat.MakeSound();
    }
}