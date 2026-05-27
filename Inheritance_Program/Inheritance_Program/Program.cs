class Animals
{
    public void Eat()
    {
        Console.WriteLine("Animal is Eating");
    }
}
class Dog : Animals
{
    public void Bark()
    {
        Console.WriteLine("Dog is Barking");
    }
}
class Cat : Animals
{
    public void Moew() 
    {
        Console.WriteLine("Cat is Moewing");
    }
}
public class Mains
{
    public static void Main(String[] args)
    {
        Dog d = new Dog();
        Cat c = new Cat();
        d.Bark();
        d.Eat();
        c.Moew();
        c.Eat();
    }
}