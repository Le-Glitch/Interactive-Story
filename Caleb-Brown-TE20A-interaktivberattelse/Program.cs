using System;

class Program
{

    static void Main()
    {
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
        Console.WriteLine("If no options are given press enter to continue");
        Console.ReadLine();
        answer = "storyPrelude";
    }

    void prelude()
    {
        
    }

}
}