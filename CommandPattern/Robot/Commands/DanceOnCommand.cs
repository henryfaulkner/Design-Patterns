namespace Robot
{
    public class DanceOnCommand : ICommand
    {
        Body body;
        public DanceOnCommand(Body body)
        {
            this.body = body;
        }

        public void Execute()
        {
            body.On();
        }
    }
}