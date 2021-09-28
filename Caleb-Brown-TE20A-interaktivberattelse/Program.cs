using System;

string answer = "";

    if(answer == "")
    {
        Intro();
    }

    if(answer == "start")
    {
        Console.Clear();
        storyStart();
    }

 
    



    
    
    
    
    
    

void Intro()
{
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine("Sleeping Simulator 2021");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("On your way home from work you feel a bit tired.");
    Console.WriteLine("Maybe you should sleep once you get home.");
    Console.WriteLine("But you also have a lot to do");
    Console.WriteLine("You'll decide when you get home, for now you just need to get there");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("Press Enter to Continue");
    Console.ReadLine();
    answer = "start";
}

void storyStart()
{
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("When you get home you feel even more tired");
    Console.WriteLine("You want to sleep badly but still need to put some finishing touches on a project");
    Console.WriteLine();
    Console.WriteLine("When walking by your kitchen to get to your bedroom you notice that there's some coffee left");
    Console.WriteLine("If you were to drink the coffee then you could stay awake to finish the project though it might be too much");
    Console.WriteLine("Do you drink the coffee or not?");
    Console.WriteLine();
    
    while(answer != "drink" && answer != "sleep1")
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Enter \"drink\" or \"sleep\"");
        answer = Console.ReadLine().ToLower();

        if(answer == "sleep")
        {
            answer = "sleep1";
        }
    }
}

   if(answer == "sleep1")
    {
        Console.Clear();
        noCoffee();
    }


void noCoffee()
{
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("You decide not to drink any coffee and leave the project unfinished");
    Console.WriteLine("Waltzing towards your bedroom you somehow manage to get to your basement");
    Console.WriteLine("Knowing what's inside there you wonder if it was fate that willed you to go down there");
    Console.WriteLine("Something might have gone wrong and that's why you're there but that would also take time that you could be using to sleep");
    Console.WriteLine();
    Console.WriteLine("Do you check what's going on in the basement or continue going to sleep?");
    Console.WriteLine();

    while(answer != "basement" && answer != "sleep2")
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Enter \"basement\" or \"sleep\"");
        answer = Console.ReadLine().ToLower();

        if(answer == "sleep")
        {
            answer = "sleep2";
        }
    }
}

    if(answer == "sleep2")
    {
        Console.Clear();
        noBasement();
    }

void noBasement()
{
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("After finally deciding to not go into the basement you head towards your bedroom again hoping you'll finally get your sleep");
    Console.WriteLine();
    Console.WriteLine("You start getting anxious that something is going to happen but you don't know why");
    Console.WriteLine("Still you get into bed though you forgot to turn your light off before you lay down");
    Console.WriteLine("Do you turn them off or continue laying in bed and go to sleep?");
    Console.WriteLine();
    
    while(answer != "lightsoff" && answer != "sleep3")
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Enter \"lightsoff\" or \"sleep\"");
        answer = Console.ReadLine().ToLower();

        if(answer == "sleep")
        {
            answer = "sleep3";
        }        
    }
}

    if(answer == "sleep3")
    {
        Console.Clear();
        sleepEnding();
    }
    

void sleepEnding()
{
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("You decided to do nothing but go straight to sleep");
    Console.WriteLine("This made an impact on your life which would never go away");
    Console.WriteLine("You proceeded to never do anything out of the ordinary");
    Console.WriteLine("Living every day as if it were the same until the day you died.");
    Console.ReadLine();
}



