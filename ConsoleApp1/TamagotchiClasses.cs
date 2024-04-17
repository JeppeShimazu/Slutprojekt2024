using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Tiger 
{
private int hunger;
private int boredom;
public List<string> words = new List<string>() {"Gud va kul att prata!!!"};
 public List<string> learnedWords = new List<string>();
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

public void Lär()
{
    Console.WriteLine($"Vilket ord vill du lära {name}?");
    string newWord = Console.ReadLine();
    LearnNewWord(newWord);
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
    Console.WriteLine($"{name} Är nu mindre uttråkad!!!");

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


    public void LearnNewWord(string word)
    {
        learnedWords.Add(word);
        Console.WriteLine($"Djuret har lärt sig ordet: {word}");
    }

  public void ShowLearnedWords()
  {
  Console.WriteLine("Djuret har lärt sig följande ord:");
  foreach (var word in learnedWords)
  {
  Console.WriteLine(word);
  }
  }

}