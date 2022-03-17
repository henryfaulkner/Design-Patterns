namespace Robot
{
    public class Robot
    {
        public ICommand action { get; set; }

        public Robot() { }

        public void SetCommand(ICommand command)
        {
            action = command;
        }

        public void ActivateCommand()
        {
            action.Execute();
        }
    }
}