namespace Robot
{
    public class DanceOffCommand : ICommand
    {
        Body body;
        public DanceOffCommand(Body body)
        {
            this.body = body;
        }

        public void Execute()
        {
            body.On();
        }
    }
}