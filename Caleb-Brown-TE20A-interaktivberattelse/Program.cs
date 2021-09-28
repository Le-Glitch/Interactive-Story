using System;

string answer = "";

    while(answer == "")
    {
        Start();
    }

    while(answer == "storyPrelude")
    {
        prelude();
    }
    
    
    
    
    
    
    
    
void Start()
{
    Console.WriteLine("Sleeping Simulator 2021");
    Console.WriteLine();
    Console.WriteLine("If No Options Are Given Press Enter to Continue");
    Console.ReadLine();
    answer = "storyPrelude";
}

void prelude()
{
    Console.WriteLine("On your way home from work you feel a bit tired.");
    Console.WriteLine("Maybe you should sleep once you get home.");
    Console.WriteLine("But you also have a lot to do");
    Console.WriteLine("You'll decide when you get home, for now you just need to get there");
    Console.ReadLine();
}


