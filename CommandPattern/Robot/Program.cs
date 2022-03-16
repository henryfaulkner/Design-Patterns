using System;

namespace Robot
{
    class Program
    {
        //Integrate multithreading:
        //Robot must continually do our bidding.
        //Never stopping, unless to say to.
        //He is our servant. We are master.
        public static void Main(string[] args)
        {
            Robot r = new Robot();
            Voice v = new Voice();
            Body b = new Body();

            Console.Write("Speaker: Welcome to Robot.\n");
            Console.Write("Robot: Sup, I'm Robot. Pick one of my features.\n\n");

            while (true)
            {
                Console.Write("1 for your fortune told.\n2 for a barade of obsenities.\n3 for a dance.\n4 to leave the machine.\n\n");
                char input = Console.ReadKey(true).KeyChar;

                //Defining speechOnCommand twice in different switch cases causes 
                //already declared errors. 
                SpeechOnCommand speechOnCommand = new SpeechOnCommand(v);
                SpeechOffCommand speechOffCommand = new SpeechOffCommand(v);
                DanceOnCommand danceOnCommand = new DanceOnCommand(b);
                DanceOffCommand danceOffCommand = new DanceOffCommand(b);

                switch (input)
                {
                    case '1':
                        v.SetCurrentVocalType(ActionConstants.VocalType.Fortunes);
                        r.SetCommand(speechOnCommand);
                        r.ActivateCommand();
                        r.SetCommand(speechOffCommand);
                        r.ActivateCommand();
                        break;
                    case '2':
                        v.SetCurrentVocalType(ActionConstants.VocalType.Obsenities);
                        r.SetCommand(speechOnCommand);
                        r.ActivateCommand();
                        r.SetCommand(speechOffCommand);
                        r.ActivateCommand();
                        break;
                    case '3':
                        r.SetCommand(danceOnCommand);
                        r.ActivateCommand();
                        r.SetCommand(danceOffCommand);
                        r.ActivateCommand();
                        break;
                    case '4':
                        Driver.DriverHelper.ExitToDriver();
                        return;
                }
            }
        }
    }
}
