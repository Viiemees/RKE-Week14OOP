Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Girl");


Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours gogs name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy");

while (myDog.LevelOfHappiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();


class Dog
{
    private string _name; //field
    private int _LevelOfHappiness;

    //constructor
    public Dog(string name) // name - lets user name the dog
    {
        _name = name;
        _LevelOfHappiness = 0;
    }

    //getter
    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHappiness
    {
        get { return _LevelOfHappiness; }
    }
   
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _LevelOfHappiness++;
    }

    public void WagTail()
    {

        Console.WriteLine("Wiggle-wiggle!");
    }

}