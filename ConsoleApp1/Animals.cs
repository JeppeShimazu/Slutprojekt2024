public class Animal 
{
private int hunger;
private int boredom;
private bool isAlive;
private Random generator;
public string name;
public string type;
public string description;

public Animal()
{
generator = new Random();
isAlive = true;
}

    public void Feed()
    {
    Console.WriteLine($" [{name}] eats and becomes less hungry");
    hunger -= 2;
    if (hunger < 0)
    {
    hunger = 0;
    }

  }
        public void Tick()
        {
        hunger++;
        boredom++;
        if (hunger > 10 || boredom > 10)
        {
        isAlive = false;
        }

}

}