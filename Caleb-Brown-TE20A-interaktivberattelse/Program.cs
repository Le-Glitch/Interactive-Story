using System;

string answer = "";


    //changing "rooms"

    if(answer == "")
    {
        intro();
    }

    if(answer == "start")
    {
        Console.Clear();
        storyStart();
    }



    if(answer == "sleep1")
    {
        Console.Clear();
        noCoffee();
    }

    if(answer == "sleep2")
    {
        Console.Clear();
        noBasement();
    }

    if(answer == "sleep3")
    {
        Console.Clear();
        lightsOn();
    }


    if(answer == "basement")
    {
        basement();
    }

    if(answer == "run")
    {
        Console.Clear();
        run();
    }

    if(answer == "stay")
    {
        Console.Clear();
        stay();
    }

    if(answer == "help")
    {
        Console.Clear();
        help();
    }

    if(answer == "preserved")
    {
        Console.Clear();
        preserved();
    }

    if(answer == "destroy")
    {
        Console.Clear();
        destroy();
    }

    if(answer == "drink")
    {
        Console.Clear();
        coffee();
    }
    



    
    
    
    
    
    //Different methods that get called on depending on choices made

void intro()
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


void noBasement()
{
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("After finally deciding to not go into the basement you head towards your bedroom again hoping you'll finally get your sleep");
    Console.WriteLine();
    Console.WriteLine("You start getting anxious that something is going to happen but you don't know why");
    Console.WriteLine("Still you get into bed though you forgot to turn your light off before you lay down");
    Console.WriteLine("Do you turn them off or keep them on and go to sleep?");
    Console.WriteLine();
    
    while(answer != "lightsoff" && answer != "lightson")
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Enter \"lightsoff\" or \"lightson\"");
        answer = Console.ReadLine().ToLower();
    }
}

    

void lightsOn()
{
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("You decided to do nothing but go straight to sleep");
    Console.WriteLine("This made an impact on your life which would never go away");
    Console.WriteLine("You proceeded to never do anything out of the ordinary");
    Console.WriteLine("Living every day as if it were the same until the day you died.");
    Console.ReadLine();
}


void basement()
{
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("You decide that checking out the basement is the best course of action");
    Console.WriteLine("Slowly you open the door and walk down the creaking steps and see an ominous light coming from the corner of the room");
    Console.WriteLine("Once you're fully down in the basement you see an otherworldly portal type thing");
    Console.WriteLine();
    Console.WriteLine("You go to inspect the portal when suddenly an arm of what is presumably an alien drags you through it");
    Console.WriteLine("When you're through the portal you start being transported somewhere unknown to you but you see an opportunity to escape");
    Console.WriteLine("Do you make a run for it or stay and face what awaits you?");
    Console.WriteLine();

    while(answer != "run" && answer != "stay")
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Enter \"run\" or \"stay\"");
        answer = Console.ReadLine().ToLower();
    }
}

void run()
{
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("You decide to take the opportunity and run for the portal");
    Console.WriteLine("Running towards it you can hear your heart racing and you're certain that you'll make it");
    Console.WriteLine("You're nearly there, just a few more steps until freedom");
    Console.WriteLine("Just as you think you've made it you hear some sort of laser weapon fire and then you feel it hit you");
    Console.WriteLine("You fall down, gasping for air but it's too late, you just lay there until your inevitable death.");
    Console.ReadLine();
}

void stay()
{
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("Instead of ceasing the opportunity to run for the portal you decide to stay and see what awaits you");
    Console.WriteLine();
    Console.WriteLine("After a while you arrive to a door which you subsequently get forced through");
    Console.WriteLine("In the room you see what is presumably the leader of this species sitting in a chair across a table");
    Console.WriteLine("There is an empty chair on your side of the table and you're asked to sit in it so you obey");
    Console.WriteLine("The aliens explain to you their plans to conquer earth and humanity and the reason they saved you");
    Console.WriteLine("They want to keep you alive to preserve a part of the human race as a sort of historical artifact");
    Console.WriteLine("You are given two options");
    Console.WriteLine("Be cryofrozen so that you'll be preserved");
    Console.WriteLine("Help them by giving them information about earth and humans and you'll be able to live out a good life");
    Console.WriteLine();
    Console.WriteLine("You have formulated your own plan to hijack their spacecraft and destroy their race though which adds another alternative");
    Console.WriteLine();

    if(answer != "help" && answer != "preserved" && answer != "destroy")
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Enter \"help\" or \"preserved\" or \"destroy\"");
        answer = Console.ReadLine().ToLower();
    }
}

void help()
{
    Console.WriteLine("You decide to help the aliens destroy earth and humanity to live out a better life yourself in this alien society");
    Console.WriteLine("This was an elaborate ruse by the aliens though and once they're done wiping out humanity they put you in cryofreeze");
    Console.WriteLine("The last thing you see is the ice obscuring your vision of the outside and even though not dead you'll never wake up again");
}

void preserved()
{
    Console.WriteLine("The aliens admire your loyalty to your species and decide that you'd be better off assimilating into their society");
    Console.WriteLine("Even though your entire species was wiped out you live out the rest of your days surrouned by creatures you learnt to love");
    Console.WriteLine("When your time eventually came you once again volunteeringly let them preserve you to keep the history of your people alive");
}

void destroy()
{
    Console.WriteLine("Unlike the opportunity you had earlier to escape you now take this chance to seize control of the ship");
    Console.WriteLine("After fighting off the guards you have control over everything and start preparing to destroy the aliens planet");
    Console.WriteLine();
    Console.WriteLine("You do this and return to earth as a hero");
    Console.WriteLine("Though before this day no one knew that aliens existed and therefore once you stepped out of the ship you instantly got shot");
}


void coffee()
{
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("After having a cup of coffee you work on your project and finish it after a few hours");
    Console.WriteLine("You then try to sleep and even though it takes a while due to the caffeine you eventually manage");
    Console.WriteLine();
    Console.WriteLine("The next day when you go into work and present the project you know that you're about to get shouted at because the presentation is horrible");
    Console.WriteLine("Due to you completing the project so late at night your brain wasn't functioning well and that worsened your work");
    Console.WriteLine("This bad presentation resulted in your company losing it's biggest client and due to that you got fired");
    Console.WriteLine("Once you lost your job you could no longer pay rent and got evicted shortly after");
    Console.WriteLine("Now you're homeless and can't get any work in the one field you're qualified to work in because of the bad reputation you have");
}