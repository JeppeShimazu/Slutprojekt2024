using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Tiger 
{
private int hunger;
private int boredom;
public List<string> words = new List<string>() {"Gud va kul att prata!!!"};
private bool isLiving;
private Random generator;
public string name;

public Tiger()
{
generator = new Random();
isLiving = true;
}

public void Mata()
{
    Console.WriteLine($"Du matar [{name}], din tiger är inte lika hungrig längre");
    hunger -= 2;
    if (hunger < 0)
    {
        hunger = 0;
    }
}

public void Hej()
{
    int wordNum = generator.Next(words.Count);
    Console.WriteLine($"[{name}] says: {words[wordNum]}");
    ReduceBoredom();
}

public void Lär(string word)
{
    Console.WriteLine($" [{name}] lär sig: {word}");
    words.Add(word);
    ReduceBoredom();
}


  public void PrintStats()
  {
    Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom} || Vocabulary: {words.Count} words");
  }
public bool GetLiving(){
    if (isLiving)
    {   
        return true;
    }
    return false;
}

public void ReduceBoredom()
  {
    Console.WriteLine($"[{name}] Är nu mindre uttråkad!!!");

    boredom -= 2;
    if (boredom < 0)
    {
      boredom = 0;
    }
  }

 public void Tick()
  {
    hunger++;
    boredom++;
    if (hunger > 10 || boredom > 10)
    {
      isLiving = false;
    }
  }

public bool GetDead()
{
    if (hunger > 9)
    {   
        return true;
    }
    return false;
}

}