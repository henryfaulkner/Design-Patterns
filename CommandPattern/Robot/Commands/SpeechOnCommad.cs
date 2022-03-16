namespace Robot
{
    public class SpeechOnCommand : ICommand
    {
        Voice voice;

        public SpeechOnCommand(Voice voice)
        {
            this.voice = voice;
        }

        public void Execute()
        {
            voice.On();
        }
    }
}