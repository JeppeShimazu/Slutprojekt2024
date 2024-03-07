using System;

Console.WriteLine("Hej! Det här är din Tiger!");

Tiger myTiger = new Tiger();

Console.WriteLine("Välj ett passande namn till din Tiger! :) ");
myTiger.name = Console.ReadLine();

Console.WriteLine($",{myTiger.name}!?! Wow vilket bra namn för en Tiger");

while (myTiger.GetLiving())
{
  Console.Clear();
  myTiger.PrintStats();
  Console.WriteLine($"Vad vill du göra med {myTiger.name}?");
  Console.WriteLine($"1. Lär {myTiger.name} något nytt!");
  Console.WriteLine($"2. Prata med {myTiger.name}!");
  Console.WriteLine($"3. Mata {myTiger.name}!");
  Console.WriteLine("4. Gör ingenting alls");

  string doWhat = Console.ReadLine();

  if (doWhat == "1")
  {
    Console.WriteLine($"Vilket ord vill du lära {myTiger.name}?");
    string word = Console.ReadLine();
    myTiger.words.Add(word);
    //Console.WriteLine($"{myTiger.name} har lärt sig {word}!");
    //myTiger.Lär(word);
  }

  if (doWhat == "2")
  {
    myTiger.Hej();
  }
  if (doWhat == "3")
  {
    myTiger.Mata();
  }
  if (doWhat == "4")
  {
    Console.WriteLine("Gör ingenting.");
  }
  //if (hunger > 9) 

  Console.ReadLine();
  myTiger.Tick();

}
//Tamagotchi dies when hunger reaches 10
if (myTiger.GetDead())
{
  Console.WriteLine($"NEEEEEEEJ! {myTiger.name} har dött!!!!!!");
  Console.WriteLine("Klicka ENTER för att lämna... :(");
}

Console.ReadLine();